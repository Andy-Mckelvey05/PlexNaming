using static System.Net.Mime.MediaTypeNames;

namespace PlexNaming
{
    public partial class AutomaticForm : Form
    {
        private Dictionary<string, string> renameResults = new();

        public AutomaticForm()
        {
            InitializeComponent();
            buttonApplyResults.Enabled = false;
        }

        private List<string> GetVideoFiles(string folder)
        {
            string[] extensions = { ".mkv", ".mp4", ".avi", ".m4v", ".mov", ".wmv", ".ts", ".webm" };

            return Directory.GetFiles(folder)
                .Where(file => extensions.Contains(
                    Path.GetExtension(file),
                    StringComparer.OrdinalIgnoreCase))
                .OrderBy(file => Path.GetFileName(file), StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        private string RemoveInvalidFileNameCharacters(string input)
        {
            char[] invalidCharacters = Path.GetInvalidFileNameChars();

            foreach (char character in invalidCharacters)
            {
                input = input.Replace(character.ToString(), "");
            }

            input = new string(input.Where(character => character >= 32).ToArray());

            return input;
        }

        private void buttonCheckResults_Click(object? sender, EventArgs e)
        {
            try
            {
                renameResults.Clear();
                listBoxExamples.Items.Clear();

                string tvdbUrl = textBoxTVDBLink.Text.Trim();
                string folder = textBoxFilePath.Text.Trim();

                if (string.IsNullOrWhiteSpace(tvdbUrl))
                {
                    MessageBox.Show("Please enter a TVDB season URL.");
                    return;
                }

                if (!Directory.Exists(folder))
                {
                    MessageBox.Show("Please enter a valid season folder.");
                    return;
                }

                buttonCheckResults.Enabled = false;

                TVDBScraper scraper = new TVDBScraper();
                TVDBSeason season = scraper.GetSeason(tvdbUrl);

                List<string> videoFiles = GetVideoFiles(folder);

                if (videoFiles.Count != season.Episodes.Count)
                {
                    MessageBox.Show(
                        $"The number of files does not match the number of episodes.\n\n" +
                        $"Files: {videoFiles.Count}\n" +
                        $"Episodes: {season.Episodes.Count}",
                        "File Count Mismatch",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                for (int i = 0; i < season.Episodes.Count; i++)
                {
                    TVDBEpisode episode = season.Episodes[i];
                    string oldFile = videoFiles[i];

                    string formattedName =
                        $"{season.ShowName} - " +
                        $"season {season.SeasonNumber:D2} - " +
                        $"s{season.SeasonNumber:D2}e{episode.Number:D2} - " +
                        $"{episode.Name}";

                    formattedName = RemoveInvalidFileNameCharacters(formattedName);

                    string extension = Path.GetExtension(oldFile);

                    formattedName += extension;

                    string oldFileName = Path.GetFileName(oldFile);
                    string newFilePath = Path.Combine(folder, formattedName);

                    renameResults.Add(oldFile, newFilePath);
                    listBoxExamples.Items.Add($"{oldFileName}\t->  {formattedName}");
                }
                buttonApplyResults.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TVDB Scraper Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonCheckResults.Enabled = true;
            }
        }

        private void buttonManualForm_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new();
            manualForm.ShowDialog();
        }

        private void buttonApplyResults_Click(object sender, EventArgs e)
        {
            if (renameResults.Count == 0)
            {
                MessageBox.Show(
                    "There are no changes to apply.",
                    "Nothing to Apply",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to rename {renameResults.Count} files?",
                "Confirm Changes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                foreach (KeyValuePair<string, string> rename in renameResults)
                {
                    if (!File.Exists(rename.Key))
                    {
                        throw new Exception($"The source file no longer exists:\n\n{rename.Key}");
                    }

                    if (File.Exists(rename.Value))
                    {
                        throw new Exception($"The destination file already exists:\n\n{rename.Value}");
                    }
                }

                foreach (KeyValuePair<string, string> rename in renameResults)
                {
                    File.Move(rename.Key, rename.Value);
                }

                MessageBox.Show("Files renamed successfully.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                renameResults.Clear();
                buttonApplyResults.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rename Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
