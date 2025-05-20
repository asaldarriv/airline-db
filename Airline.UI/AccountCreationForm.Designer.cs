namespace Airline.UI
{
    partial class AccountCreationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDocumentTypeId;
        private System.Windows.Forms.TextBox textBoxDocumentTypeId;
        private System.Windows.Forms.Label labelCountryId;
        private System.Windows.Forms.TextBox textBoxCountryId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelFirstLastName;
        private System.Windows.Forms.TextBox textBoxFirstLastName;
        private System.Windows.Forms.Label labelSecondLastName;
        private System.Windows.Forms.TextBox textBoxSecondLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelTrainingInstitution;
        private System.Windows.Forms.TextBox textBoxTrainingInstitution;
        private System.Windows.Forms.Label labelEducationLevel;
        private System.Windows.Forms.TextBox textBoxEducationLevel;
        private System.Windows.Forms.Label labelDegreeTitle;
        private System.Windows.Forms.TextBox textBoxDegreeTitle;
        private System.Windows.Forms.Label labelResidenceCountryId;
        private System.Windows.Forms.TextBox textBoxResidenceCountryId;
        private System.Windows.Forms.Label labelBirthCountryId;
        private System.Windows.Forms.TextBox textBoxBirthCountryId;
        private System.Windows.Forms.Label labelContractStatusId;
        private System.Windows.Forms.TextBox textBoxContractStatusId;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            labelTitle = new System.Windows.Forms.Label();
            labelDocumentTypeId = new System.Windows.Forms.Label();
            textBoxDocumentTypeId = new System.Windows.Forms.TextBox();
            labelCountryId = new System.Windows.Forms.Label();
            textBoxCountryId = new System.Windows.Forms.TextBox();
            labelEmail = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            labelFirstName = new System.Windows.Forms.Label();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            labelSecondName = new System.Windows.Forms.Label();
            textBoxSecondName = new System.Windows.Forms.TextBox();
            labelFirstLastName = new System.Windows.Forms.Label();
            textBoxFirstLastName = new System.Windows.Forms.TextBox();
            labelSecondLastName = new System.Windows.Forms.Label();
            textBoxSecondLastName = new System.Windows.Forms.TextBox();
            labelPhone = new System.Windows.Forms.Label();
            textBoxPhone = new System.Windows.Forms.TextBox();
            labelAddress = new System.Windows.Forms.Label();
            textBoxAddress = new System.Windows.Forms.TextBox();
            labelBirthDate = new System.Windows.Forms.Label();
            dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            labelTrainingInstitution = new System.Windows.Forms.Label();
            textBoxTrainingInstitution = new System.Windows.Forms.TextBox();
            labelEducationLevel = new System.Windows.Forms.Label();
            textBoxEducationLevel = new System.Windows.Forms.TextBox();
            labelDegreeTitle = new System.Windows.Forms.Label();
            textBoxDegreeTitle = new System.Windows.Forms.TextBox();
            labelResidenceCountryId = new System.Windows.Forms.Label();
            textBoxResidenceCountryId = new System.Windows.Forms.TextBox();
            labelBirthCountryId = new System.Windows.Forms.Label();
            textBoxBirthCountryId = new System.Windows.Forms.TextBox();
            labelContractStatusId = new System.Windows.Forms.Label();
            textBoxContractStatusId = new System.Windows.Forms.TextBox();
            labelUsername = new System.Windows.Forms.Label();
            textBoxUsername = new System.Windows.Forms.TextBox();
            labelPassword = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            buttonCreateAccount = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanelMain
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.RowCount = 24;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            for (int i = 0; i < 24; i++)
                tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelMain.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelMain.SetColumnSpan(labelTitle, 2);
            tableLayoutPanelMain.Controls.Add(labelDocumentTypeId, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxDocumentTypeId, 1, 1);
            tableLayoutPanelMain.Controls.Add(labelCountryId, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxCountryId, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelEmail, 0, 3);
            tableLayoutPanelMain.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanelMain.Controls.Add(labelFirstName, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxFirstName, 1, 4);
            tableLayoutPanelMain.Controls.Add(labelSecondName, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxSecondName, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelFirstLastName, 0, 6);
            tableLayoutPanelMain.Controls.Add(textBoxFirstLastName, 1, 6);
            tableLayoutPanelMain.Controls.Add(labelSecondLastName, 0, 7);
            tableLayoutPanelMain.Controls.Add(textBoxSecondLastName, 1, 7);
            tableLayoutPanelMain.Controls.Add(labelPhone, 0, 8);
            tableLayoutPanelMain.Controls.Add(textBoxPhone, 1, 8);
            tableLayoutPanelMain.Controls.Add(labelAddress, 0, 9);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 9);
            tableLayoutPanelMain.Controls.Add(labelBirthDate, 0, 10);
            tableLayoutPanelMain.Controls.Add(dateTimePickerBirthDate, 1, 10);
            tableLayoutPanelMain.Controls.Add(labelTrainingInstitution, 0, 11);
            tableLayoutPanelMain.Controls.Add(textBoxTrainingInstitution, 1, 11);
            tableLayoutPanelMain.Controls.Add(labelEducationLevel, 0, 12);
            tableLayoutPanelMain.Controls.Add(textBoxEducationLevel, 1, 12);
            tableLayoutPanelMain.Controls.Add(labelDegreeTitle, 0, 13);
            tableLayoutPanelMain.Controls.Add(textBoxDegreeTitle, 1, 13);
            tableLayoutPanelMain.Controls.Add(labelResidenceCountryId, 0, 14);
            tableLayoutPanelMain.Controls.Add(textBoxResidenceCountryId, 1, 14);
            tableLayoutPanelMain.Controls.Add(labelBirthCountryId, 0, 15);
            tableLayoutPanelMain.Controls.Add(textBoxBirthCountryId, 1, 15);
            tableLayoutPanelMain.Controls.Add(labelContractStatusId, 0, 16);
            tableLayoutPanelMain.Controls.Add(textBoxContractStatusId, 1, 16);
            tableLayoutPanelMain.Controls.Add(labelUsername, 0, 17);
            tableLayoutPanelMain.Controls.Add(textBoxUsername, 1, 17);
            tableLayoutPanelMain.Controls.Add(labelPassword, 0, 18);
            tableLayoutPanelMain.Controls.Add(textBoxPassword, 1, 18);
            tableLayoutPanelMain.Controls.Add(buttonCreateAccount, 0, 20);
            tableLayoutPanelMain.Controls.Add(buttonCancel, 1, 20);

            // labelTitle
            labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.ForeColor = System.Drawing.Color.Navy;
            labelTitle.Text = "Create Account";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            // labelDocumentTypeId
            labelDocumentTypeId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDocumentTypeId.AutoSize = true;
            labelDocumentTypeId.Text = "Document Type ID*:";
            textBoxDocumentTypeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxDocumentTypeId.Size = new System.Drawing.Size(250, 27);

            // labelCountryId
            labelCountryId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCountryId.AutoSize = true;
            labelCountryId.Text = "Country ID*:";
            textBoxCountryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxCountryId.Size = new System.Drawing.Size(250, 27);

            // labelEmail
            labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Text = "Email*:";
            textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxEmail.Size = new System.Drawing.Size(250, 27);

            // labelFirstName
            labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelFirstName.AutoSize = true;
            labelFirstName.Text = "First Name*:";
            textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxFirstName.Size = new System.Drawing.Size(250, 27);

            // labelSecondName
            labelSecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSecondName.AutoSize = true;
            labelSecondName.Text = "Second Name:";
            textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxSecondName.Size = new System.Drawing.Size(250, 27);

            // labelFirstLastName
            labelFirstLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelFirstLastName.AutoSize = true;
            labelFirstLastName.Text = "First Last Name*:";
            textBoxFirstLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxFirstLastName.Size = new System.Drawing.Size(250, 27);

            // labelSecondLastName
            labelSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSecondLastName.AutoSize = true;
            labelSecondLastName.Text = "Second Last Name:";
            textBoxSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxSecondLastName.Size = new System.Drawing.Size(250, 27);

            // labelPhone
            labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Text = "Phone*:";
            textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxPhone.Size = new System.Drawing.Size(250, 27);

            // labelAddress
            labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAddress.AutoSize = true;
            labelAddress.Text = "Address*:";
            textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxAddress.Size = new System.Drawing.Size(250, 27);

            // labelBirthDate
            labelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Text = "Birth Date*:";
            dateTimePickerBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Size = new System.Drawing.Size(150, 27);

            // labelTrainingInstitution
            labelTrainingInstitution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelTrainingInstitution.AutoSize = true;
            labelTrainingInstitution.Text = "Training Institution:";
            textBoxTrainingInstitution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxTrainingInstitution.Size = new System.Drawing.Size(250, 27);

            // labelEducationLevel
            labelEducationLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelEducationLevel.AutoSize = true;
            labelEducationLevel.Text = "Education Level:";
            textBoxEducationLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxEducationLevel.Size = new System.Drawing.Size(250, 27);

            // labelDegreeTitle
            labelDegreeTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDegreeTitle.AutoSize = true;
            labelDegreeTitle.Text = "Degree Title:";
            textBoxDegreeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxDegreeTitle.Size = new System.Drawing.Size(250, 27);

            // labelResidenceCountryId
            labelResidenceCountryId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelResidenceCountryId.AutoSize = true;
            labelResidenceCountryId.Text = "Residence Country ID:";
            textBoxResidenceCountryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxResidenceCountryId.Size = new System.Drawing.Size(250, 27);

            // labelBirthCountryId
            labelBirthCountryId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelBirthCountryId.AutoSize = true;
            labelBirthCountryId.Text = "Birth Country ID:";
            textBoxBirthCountryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxBirthCountryId.Size = new System.Drawing.Size(250, 27);

            // labelContractStatusId
            labelContractStatusId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelContractStatusId.AutoSize = true;
            labelContractStatusId.Text = "Contract Status ID:";
            textBoxContractStatusId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxContractStatusId.Size = new System.Drawing.Size(250, 27);

            // labelUsername
            labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Text = "Username*:";
            textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxUsername.Size = new System.Drawing.Size(250, 27);

            // labelPassword
            labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Text = "Password*:";
            textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxPassword.Size = new System.Drawing.Size(250, 27);
            textBoxPassword.PasswordChar = '*';

            // buttonCreateAccount
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCreateAccount.Size = new System.Drawing.Size(180, 40);
            buttonCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            buttonCreateAccount.Click += buttonCreateAccount_Click;

            // buttonCancel
            buttonCancel.Text = "Cancel";
            buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCancel.Size = new System.Drawing.Size(180, 40);
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            buttonCancel.Click += buttonCancel_Click;

            // AccountCreationForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 900);
            Controls.Add(tableLayoutPanelMain);
            Name = "AccountCreationForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create Account";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}