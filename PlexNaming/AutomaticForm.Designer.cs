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
            textBox1 = new TextBox();
            buttonCheckResults = new Button();
            listBoxExamples = new ListBox();
            SuspendLayout();
            // 
            // buttonManualForm
            // 
            buttonManualForm.BackColor = Color.FromArgb(255, 190, 40);
            buttonManualForm.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManualForm.Location = new Point(443, 393);
            buttonManualForm.Name = "buttonManualForm";
            buttonManualForm.Size = new Size(257, 120);
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
            textBoxTVDBLink.Size = new Size(711, 38);
            textBoxTVDBLink.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(250, 210, 37);
            textBox1.Font = new Font("Courier New", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Show Name?";
            textBox1.Size = new Size(711, 38);
            textBox1.TabIndex = 9;
            // 
            // buttonCheckResults
            // 
            buttonCheckResults.BackColor = Color.FromArgb(255, 190, 40);
            buttonCheckResults.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCheckResults.Location = new Point(28, 393);
            buttonCheckResults.Name = "buttonCheckResults";
            buttonCheckResults.Size = new Size(266, 120);
            buttonCheckResults.TabIndex = 10;
            buttonCheckResults.Text = "Check Results";
            buttonCheckResults.UseVisualStyleBackColor = false;
            buttonCheckResults.Click += buttonCheckResults_Click;
            // 
            // listBoxExamples
            // 
            listBoxExamples.BackColor = Color.FromArgb(250, 210, 37);
            listBoxExamples.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxExamples.FormattingEnabled = true;
            listBoxExamples.HorizontalScrollbar = true;
            listBoxExamples.Location = new Point(12, 100);
            listBoxExamples.Name = "listBoxExamples";
            listBoxExamples.Size = new Size(711, 244);
            listBoxExamples.TabIndex = 11;
            // 
            // AutomaticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(735, 559);
            Controls.Add(listBoxExamples);
            Controls.Add(buttonCheckResults);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button buttonCheckResults;
        private ListBox listBoxExamples;
    }
}
