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
    }
}
