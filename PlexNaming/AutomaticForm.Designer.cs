namespace PlexNaming
{
    partial class AutomaticForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticForm));
            textBoxShow = new TextBox();
            textBoxSeason = new TextBox();
            textBoxEpisode = new TextBox();
            textBoxEpName = new TextBox();
            BtnGetName = new Button();
            textBoxOutput = new TextBox();
            buttonIncrementSeason = new Button();
            SuspendLayout();
            // 
            // textBoxShow
            // 
            textBoxShow.BackColor = Color.FromArgb(250, 210, 37);
            textBoxShow.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxShow.Location = new Point(12, 12);
            textBoxShow.Name = "textBoxShow";
            textBoxShow.PlaceholderText = "Show Name?";
            textBoxShow.Size = new Size(509, 38);
            textBoxShow.TabIndex = 0;
            // 
            // textBoxSeason
            // 
            textBoxSeason.BackColor = Color.FromArgb(250, 210, 37);
            textBoxSeason.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSeason.Location = new Point(12, 56);
            textBoxSeason.Name = "textBoxSeason";
            textBoxSeason.PlaceholderText = "Season";
            textBoxSeason.Size = new Size(155, 38);
            textBoxSeason.TabIndex = 1;
            // 
            // textBoxEpisode
            // 
            textBoxEpisode.BackColor = Color.FromArgb(250, 210, 37);
            textBoxEpisode.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEpisode.Location = new Point(366, 56);
            textBoxEpisode.Name = "textBoxEpisode";
            textBoxEpisode.PlaceholderText = "Episode";
            textBoxEpisode.Size = new Size(155, 38);
            textBoxEpisode.TabIndex = 2;
            // 
            // textBoxEpName
            // 
            textBoxEpName.BackColor = Color.FromArgb(250, 210, 37);
            textBoxEpName.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEpName.Location = new Point(12, 100);
            textBoxEpName.Name = "textBoxEpName";
            textBoxEpName.PlaceholderText = "Episode Name?";
            textBoxEpName.Size = new Size(509, 38);
            textBoxEpName.TabIndex = 3;
            // 
            // BtnGetName
            // 
            BtnGetName.BackColor = Color.FromArgb(255, 190, 40);
            BtnGetName.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGetName.Location = new Point(12, 144);
            BtnGetName.Name = "BtnGetName";
            BtnGetName.Size = new Size(509, 134);
            BtnGetName.TabIndex = 4;
            BtnGetName.Text = "Get Name";
            BtnGetName.UseVisualStyleBackColor = false;
            BtnGetName.Click += BtnGetName_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOutput.Location = new Point(12, 284);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(509, 22);
            textBoxOutput.TabIndex = 5;
            // 
            // buttonIncrementSeason
            // 
            buttonIncrementSeason.BackColor = Color.FromArgb(255, 190, 40);
            buttonIncrementSeason.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIncrementSeason.Location = new Point(173, 56);
            buttonIncrementSeason.Name = "buttonIncrementSeason";
            buttonIncrementSeason.Size = new Size(38, 38);
            buttonIncrementSeason.TabIndex = 6;
            buttonIncrementSeason.Text = "+";
            buttonIncrementSeason.UseVisualStyleBackColor = false;
            buttonIncrementSeason.Click += buttonIncrementSeason_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(533, 314);
            Controls.Add(buttonIncrementSeason);
            Controls.Add(textBoxOutput);
            Controls.Add(BtnGetName);
            Controls.Add(textBoxEpName);
            Controls.Add(textBoxEpisode);
            Controls.Add(textBoxSeason);
            Controls.Add(textBoxShow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "PlexTvNaming";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxShow;
        private TextBox textBoxSeason;
        private TextBox textBoxEpisode;
        private TextBox textBoxEpName;
        private Button BtnGetName;
        private TextBox textBoxOutput;
        private Button buttonIncrementSeason;
    }
}
