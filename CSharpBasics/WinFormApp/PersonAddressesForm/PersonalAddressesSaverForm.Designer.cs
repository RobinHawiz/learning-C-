namespace PersonAddressesForm
{
    partial class PersonalAddressesSaverForm
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
            streetAddressTextBox = new TextBox();
            cityTextBox = new TextBox();
            streetAddressLabel = new Label();
            cityLabel = new Label();
            addAddressesButton = new Button();
            SuspendLayout();
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(141, 22);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(150, 31);
            streetAddressTextBox.TabIndex = 0;
            streetAddressTextBox.TextChanged += this.textBox1_TextChanged;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(141, 59);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(150, 31);
            cityTextBox.TabIndex = 0;
            cityTextBox.TextChanged += this.textBox2_TextChanged;
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(11, 25);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(124, 25);
            streetAddressLabel.TabIndex = 1;
            streetAddressLabel.Text = "Street address";
            streetAddressLabel.Click += this.label1_Click;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(12, 62);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(42, 25);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "City";
            cityLabel.Click += this.label2_Click;
            // 
            // addAddressesButton
            // 
            addAddressesButton.Location = new Point(179, 96);
            addAddressesButton.Name = "addAddressesButton";
            addAddressesButton.Size = new Size(112, 34);
            addAddressesButton.TabIndex = 2;
            addAddressesButton.Text = "Add";
            addAddressesButton.UseVisualStyleBackColor = true;
            // 
            // PersonalAddressesSaverForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 137);
            Controls.Add(addAddressesButton);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressLabel);
            Controls.Add(cityTextBox);
            Controls.Add(streetAddressTextBox);
            Name = "PersonalAddressesSaverForm";
            Text = "Addresses form";
            Load += this.PersonalAddressesSaverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox streetAddressTextBox;
        private TextBox cityTextBox;
        private Label streetAddressLabel;
        private Label cityLabel;
        private Button addAddressesButton;
    }
}
