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
            SuspendLayout();
            // 
            // buttonManualForm
            // 
            buttonManualForm.BackColor = Color.FromArgb(255, 190, 40);
            buttonManualForm.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManualForm.Location = new Point(12, 23);
            buttonManualForm.Name = "buttonManualForm";
            buttonManualForm.Size = new Size(257, 120);
            buttonManualForm.TabIndex = 7;
            buttonManualForm.Text = "Manual";
            buttonManualForm.UseVisualStyleBackColor = false;
            buttonManualForm.Click += buttonManualForm_Click;
            // 
            // AutomaticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(289, 170);
            Controls.Add(buttonManualForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutomaticForm";
            Text = "PlexTvNaming";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonManualForm;
    }
}
