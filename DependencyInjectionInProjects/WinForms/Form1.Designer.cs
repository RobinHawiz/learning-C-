namespace WinForms
{
    partial class Form1
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
            helloText = new Label();
            goodbyeText = new Label();
            SuspendLayout();
            // 
            // helloText
            // 
            helloText.AutoSize = true;
            helloText.Font = new Font("Segoe UI", 20F);
            helloText.Location = new Point(146, 145);
            helloText.Name = "helloText";
            helloText.Size = new Size(130, 54);
            helloText.TabIndex = 0;
            helloText.Text = "label1";
            // 
            // goodbyeText
            // 
            goodbyeText.AutoSize = true;
            goodbyeText.Font = new Font("Segoe UI", 20F);
            goodbyeText.Location = new Point(146, 225);
            goodbyeText.Name = "goodbyeText";
            goodbyeText.Size = new Size(130, 54);
            goodbyeText.TabIndex = 1;
            goodbyeText.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(goodbyeText);
            Controls.Add(helloText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloText;
        private Label goodbyeText;
    }
}
