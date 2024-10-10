namespace WinForm
{
    partial class PersonalInfoSaverForm
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
            addPersonButton = new Button();
            listBoxPersonInfo = new ListBox();
            firstNameLabel = new Label();
            personalInfoLabel = new Label();
            textBoxFirstName = new TextBox();
            lastNameLabel = new Label();
            textBoxLastName = new TextBox();
            addAddressesButton = new Button();
            SuspendLayout();
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(484, 150);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Size = new Size(126, 34);
            addPersonButton.TabIndex = 3;
            addPersonButton.Text = "Add person";
            addPersonButton.UseVisualStyleBackColor = true;
            addPersonButton.Click += addPersonButton_Click;
            // 
            // listBoxPersonInfo
            // 
            listBoxPersonInfo.FormattingEnabled = true;
            listBoxPersonInfo.ItemHeight = 25;
            listBoxPersonInfo.Location = new Point(99, 266);
            listBoxPersonInfo.Name = "listBoxPersonInfo";
            listBoxPersonInfo.Size = new Size(511, 154);
            listBoxPersonInfo.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(99, 116);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(92, 25);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "FirstName";
            // 
            // personalInfoLabel
            // 
            personalInfoLabel.AutoSize = true;
            personalInfoLabel.Location = new Point(99, 238);
            personalInfoLabel.Name = "personalInfoLabel";
            personalInfoLabel.Size = new Size(114, 25);
            personalInfoLabel.TabIndex = 3;
            personalInfoLabel.Text = "Personal info";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(197, 113);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(364, 116);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 25);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "LastName";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(460, 113);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 2;
            // 
            // addAddressesButton
            // 
            addAddressesButton.Location = new Point(471, 226);
            addAddressesButton.Name = "addAddressesButton";
            addAddressesButton.Size = new Size(139, 34);
            addAddressesButton.TabIndex = 5;
            addAddressesButton.Text = "Add addresses";
            addAddressesButton.UseVisualStyleBackColor = true;
            addAddressesButton.Click += addAddressesButton_Click;
            // 
            // PersonalInfoSaverForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addAddressesButton);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(lastNameLabel);
            Controls.Add(personalInfoLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(listBoxPersonInfo);
            Controls.Add(addPersonButton);
            Name = "PersonalInfoSaverForm";
            Text = "PersonalInfoSaverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addPersonButton;
        private ListBox listBoxPersonInfo;
        private Label firstNameLabel;
        private Label personalInfoLabel;
        private TextBox textBoxFirstName;
        private Label lastNameLabel;
        private TextBox textBoxLastName;
        private Button addAddressesButton;
    }
}
