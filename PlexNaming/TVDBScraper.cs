using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace PlexNaming
{
    public class TVDBScraper
    {
        private readonly HttpClient _httpClient;

        public TVDBScraper()
        {
            _httpClient = new HttpClient();

            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
                "AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/120.0 Safari/537.36");
        }

        public TVDBSeason GetSeason(string url)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uri)) {
                throw new Exception("The TVDB URL is not valid.");
            }

            if (!uri.Host.Contains("thetvdb.com", StringComparison.OrdinalIgnoreCase)) 
            {
                throw new Exception("The URL does not appear to be a TVDB URL.");
            }

            string tempDirectory = Path.Combine(Path.GetTempPath(), "PlexNaming");

            Directory.CreateDirectory(tempDirectory);

            string tempFile = Path.Combine(tempDirectory, $"{Guid.NewGuid():N}.html");

            try
            {
                byte[] htmlBytes = _httpClient.GetByteArrayAsync(uri).GetAwaiter().GetResult();
                File.WriteAllBytes(tempFile, htmlBytes);

                var document = new HtmlAgilityPack.HtmlDocument();
                document.Load(tempFile);

                return ParseSeason(document, uri);
            }
            finally
            {
                try
                {
                    if (File.Exists(tempFile)) 
                    {
                        File.Delete(tempFile);
                    }
                }
                catch
                {
                    // Ignore cleanup errors.
                }
            }
        }

        private TVDBSeason ParseSeason(HtmlAgilityPack.HtmlDocument document, Uri uri)
        {
            var season = new TVDBSeason();

            Match seasonMatch = Regex.Match(uri.AbsolutePath, @"/seasons/[^/]+/(\d+)", RegexOptions.IgnoreCase);

            if (!seasonMatch.Success) 
            {
                throw new Exception("Could not determine the season number.");
            }

            season.SeasonNumber = int.Parse(seasonMatch.Groups[1].Value);

            string[] pathParts = uri.AbsolutePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
            int seriesIndex = Array.FindIndex(pathParts, part => part.Equals("series", StringComparison.OrdinalIgnoreCase));

            if (seriesIndex >= 0 && seriesIndex + 1 < pathParts.Length)
            {
                string seriesSlug = pathParts[seriesIndex + 1];

                HtmlNode? showLink = document.DocumentNode.SelectSingleNode($"//a[contains(@href, '/series/{seriesSlug}')]");

                if (showLink != null)
                {
                    season.ShowName = HtmlEntity.DeEntitize(showLink.InnerText).Trim();
                }
            }

            HtmlNodeCollection? rows = document.DocumentNode.SelectNodes("//table//tr");

            if (rows == null) 
            { 
                throw new Exception("Could not find the episode table on TVDB.");
            }

            foreach (HtmlNode row in rows)
            {
                string rowText = HtmlEntity.DeEntitize(row.InnerText).Trim();

                Match episodeMatch = Regex.Match(rowText,@"S\d+E(\d+)", RegexOptions.IgnoreCase);

                if (!episodeMatch.Success) 
                {
                    continue;
                }

                int episodeNumber = int.Parse(episodeMatch.Groups[1].Value);

                HtmlNode? episodeLink = row.SelectSingleNode(".//a");

                if (episodeLink == null) 
                {
                    continue;
                }

                string episodeName = HtmlEntity.DeEntitize(episodeLink.InnerText).Trim();

                if (string.IsNullOrWhiteSpace(episodeName)) 
                {
                    continue;
                }

                season.Episodes.Add(new TVDBEpisode
                {
                    Number = episodeNumber,
                    Name = episodeName
                });
            }

            season.Episodes = season.Episodes.OrderBy(e => e.Number).ToList();

            if (season.Episodes.Count == 0) 
            {
                throw new Exception("No episodes could be found on the TVDB page.");
            }

            return season;
        }
    }

    public class TVDBSeason
    {
        public string ShowName { get; set; } = "";
        public int SeasonNumber { get; set; }
        public List<TVDBEpisode> Episodes { get; set; } = new();
    }

    public class TVDBEpisode
    {
        public int Number { get; set; }
        public string Name { get; set; } = "";
    }
}