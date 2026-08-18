using static System.Net.Mime.MediaTypeNames;

namespace PlexNaming
{
    public partial class AutomaticForm : Form
    {
        public AutomaticForm()
        {
            InitializeComponent();
        }

        private void buttonManualForm_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new();
            manualForm.ShowDialog();
        }

        private void buttonCheckResults_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxExamples.Items.Clear();

                string tvdbUrl = textBoxTVDBLink.Text.Trim();

                if (string.IsNullOrWhiteSpace(tvdbUrl))
                {
                    MessageBox.Show("Please enter a TVDB season URL.");
                    return;
                }

                buttonCheckResults.Enabled = false;

                TVDBScraper scraper = new TVDBScraper();
                TVDBSeason season = scraper.GetSeason(tvdbUrl);

                listBoxExamples.Items.Add($"Show: {season.ShowName}");
                listBoxExamples.Items.Add($"Season: {season.SeasonNumber:D2}");
                listBoxExamples.Items.Add($"Episodes: {season.Episodes.Count}");
                listBoxExamples.Items.Add("----------------------------------------");

                foreach (TVDBEpisode episode in season.Episodes)
                {
                    string formattedName =
                        $"{season.ShowName} - " +
                        $"season {season.SeasonNumber:D2} - " +
                        $"s{season.SeasonNumber:D2}e{episode.Number:D2} - " +
                        $"{episode.Name}";

                    listBoxExamples.Items.Add(formattedName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"TVDB Scraper Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonCheckResults.Enabled = true;
            }
        }
    }
}
