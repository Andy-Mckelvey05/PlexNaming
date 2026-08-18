using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlexNaming
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
        }

        private void BtnGetName_Click(object sender, EventArgs e)
        {
            string show = textBoxShow.Text;
            string season = textBoxSeason.Text;
            string episode = textBoxEpisode.Text;
            string epName = textBoxEpName.Text;

            season = ConvertNumber(season);
            episode = ConvertNumber(episode);

            string finalString = string.Empty;
            if (epName != string.Empty)
            {
                finalString = $"{show} - season {season} - s{season}e{episode} - {epName}";
            }
            else
            {
                finalString = $"{show} - season {season} - s{season}e{episode}";
            }
            textBoxOutput.Text = finalString;
            Clipboard.SetText(finalString);

            textBoxEpisode.Text = IncrementStringNumber(episode);
        }

        private void buttonIncrementSeason_Click(object sender, EventArgs e)
        {
            string season = textBoxSeason.Text;

            textBoxSeason.Text = IncrementStringNumber(season);
            textBoxEpisode.Text = "1";
        }

        string ConvertNumber(string input)
        {
            if (!int.TryParse(input, out int number))
            {
                return "0";
            }

            return number < 10 ? number.ToString("D2") : number.ToString();
        }

        string IncrementStringNumber(string num)
        {
            if (int.TryParse(num, out int number))
            {
                return (number += 1).ToString();
            }
            else
            {
                return "1";
            }
        }
    }
}
