namespace WinForm
{
    partial class AddressEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            streetAddressesTextBox = new TextBox();
            cityTextBox = new TextBox();
            streetAddressLabel = new Label();
            cityLabel = new Label();
            addAddressesButton = new Button();
            SuspendLayout();
            // 
            // streetAddressesTextBox
            // 
            streetAddressesTextBox.Location = new Point(151, 17);
            streetAddressesTextBox.Name = "streetAddressesTextBox";
            streetAddressesTextBox.Size = new Size(150, 31);
            streetAddressesTextBox.TabIndex = 0;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(151, 66);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(150, 31);
            cityTextBox.TabIndex = 1;
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(18, 20);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(127, 25);
            streetAddressLabel.TabIndex = 2;
            streetAddressLabel.Text = "Street Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(18, 69);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(42, 25);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City";
            // 
            // addAddressesButton
            // 
            addAddressesButton.Location = new Point(148, 103);
            addAddressesButton.Name = "addAddressesButton";
            addAddressesButton.Size = new Size(153, 34);
            addAddressesButton.TabIndex = 4;
            addAddressesButton.Text = "Add Addresses";
            addAddressesButton.UseVisualStyleBackColor = true;
            addAddressesButton.Click += addAddressesButton_Click;
            // 
            // PersonAddressesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 158);
            Controls.Add(addAddressesButton);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressLabel);
            Controls.Add(cityTextBox);
            Controls.Add(streetAddressesTextBox);
            Name = "PersonAddressesForm";
            Text = "PersonAddressesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox streetAddressesTextBox;
        private TextBox cityTextBox;
        private Label streetAddressLabel;
        private Label cityLabel;
        private Button addAddressesButton;
    }
}