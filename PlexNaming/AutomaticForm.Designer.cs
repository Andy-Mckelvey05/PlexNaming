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
            buttonManualForm = new Button();
            textBoxTVDBLink = new TextBox();
            textBoxFilePath = new TextBox();
            buttonCheckResults = new Button();
            listBoxExamples = new ListBox();
            buttonApplyResults = new Button();
            SuspendLayout();
            // 
            // buttonManualForm
            // 
            buttonManualForm.BackColor = Color.FromArgb(255, 190, 40);
            buttonManualForm.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManualForm.Location = new Point(599, 286);
            buttonManualForm.Name = "buttonManualForm";
            buttonManualForm.Size = new Size(124, 60);
            buttonManualForm.TabIndex = 7;
            buttonManualForm.Text = "Manual";
            buttonManualForm.UseVisualStyleBackColor = false;
            buttonManualForm.Click += buttonManualForm_Click;
            // 
            // textBoxTVDBLink
            // 
            textBoxTVDBLink.BackColor = Color.FromArgb(250, 210, 37);
            textBoxTVDBLink.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTVDBLink.Location = new Point(12, 12);
            textBoxTVDBLink.Name = "textBoxTVDBLink";
            textBoxTVDBLink.PlaceholderText = "TVDB Season Link?";
            textBoxTVDBLink.Size = new Size(581, 38);
            textBoxTVDBLink.TabIndex = 8;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.BackColor = Color.FromArgb(250, 210, 37);
            textBoxFilePath.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFilePath.Location = new Point(12, 56);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.PlaceholderText = "Season File Path?";
            textBoxFilePath.Size = new Size(581, 38);
            textBoxFilePath.TabIndex = 9;
            // 
            // buttonCheckResults
            // 
            buttonCheckResults.BackColor = Color.FromArgb(255, 190, 40);
            buttonCheckResults.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCheckResults.Location = new Point(599, 12);
            buttonCheckResults.Name = "buttonCheckResults";
            buttonCheckResults.Size = new Size(124, 82);
            buttonCheckResults.TabIndex = 10;
            buttonCheckResults.Text = "Check Results";
            buttonCheckResults.UseVisualStyleBackColor = false;
            buttonCheckResults.Click += buttonCheckResults_Click;
            // 
            // listBoxExamples
            // 
            listBoxExamples.BackColor = SystemColors.Control;
            listBoxExamples.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxExamples.FormattingEnabled = true;
            listBoxExamples.HorizontalScrollbar = true;
            listBoxExamples.Location = new Point(12, 100);
            listBoxExamples.Name = "listBoxExamples";
            listBoxExamples.Size = new Size(711, 180);
            listBoxExamples.TabIndex = 11;
            // 
            // buttonApplyResults
            // 
            buttonApplyResults.BackColor = Color.FromArgb(255, 190, 40);
            buttonApplyResults.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApplyResults.Location = new Point(12, 286);
            buttonApplyResults.Name = "buttonApplyResults";
            buttonApplyResults.Size = new Size(581, 60);
            buttonApplyResults.TabIndex = 12;
            buttonApplyResults.Text = "Apply Results";
            buttonApplyResults.UseVisualStyleBackColor = false;
            buttonApplyResults.Click += buttonApplyResults_Click;
            // 
            // AutomaticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(735, 356);
            Controls.Add(buttonApplyResults);
            Controls.Add(listBoxExamples);
            Controls.Add(buttonCheckResults);
            Controls.Add(textBoxFilePath);
            Controls.Add(textBoxTVDBLink);
            Controls.Add(buttonManualForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutomaticForm";
            Text = "PlexTvNaming";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonManualForm;
        private TextBox textBoxTVDBLink;
        private TextBox textBoxFilePath;
        private Button buttonCheckResults;
        private ListBox listBoxExamples;
        private Button buttonApplyResults;
    }
}
