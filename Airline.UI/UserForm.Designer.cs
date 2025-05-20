namespace Airline.UI
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
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
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelIsActive;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
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
            dataGridViewUsers = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
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
            labelUsername = new System.Windows.Forms.Label();
            textBoxUsername = new System.Windows.Forms.TextBox();
            labelPassword = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            labelIsActive = new System.Windows.Forms.Label();
            checkBoxIsActive = new System.Windows.Forms.CheckBox();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewUsers)).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanelMain
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(dataGridViewUsers, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewUsers
            dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelEmail, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxEmail, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelFirstName, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxFirstName, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelSecondName, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxSecondName, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelFirstLastName, 0, 3);
            tableLayoutPanelInputs.Controls.Add(textBoxFirstLastName, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelSecondLastName, 0, 4);
            tableLayoutPanelInputs.Controls.Add(textBoxSecondLastName, 1, 4);
            tableLayoutPanelInputs.Controls.Add(labelPhone, 0, 5);
            tableLayoutPanelInputs.Controls.Add(textBoxPhone, 1, 5);
            tableLayoutPanelInputs.Controls.Add(labelAddress, 0, 6);
            tableLayoutPanelInputs.Controls.Add(textBoxAddress, 1, 6);
            tableLayoutPanelInputs.Controls.Add(labelBirthDate, 0, 7);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerBirthDate, 1, 7);
            tableLayoutPanelInputs.Controls.Add(labelUsername, 0, 8);
            tableLayoutPanelInputs.Controls.Add(textBoxUsername, 1, 8);
            tableLayoutPanelInputs.Controls.Add(labelPassword, 0, 9);
            tableLayoutPanelInputs.Controls.Add(textBoxPassword, 1, 9);
            tableLayoutPanelInputs.Controls.Add(labelIsActive, 0, 10);
            tableLayoutPanelInputs.Controls.Add(checkBoxIsActive, 1, 10);
            tableLayoutPanelInputs.RowCount = 11;
            for (int i = 0; i < 11; i++)
                tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // Labels and Inputs
            labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Text = "Email:";
            textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxEmail.Size = new System.Drawing.Size(250, 27);

            labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelFirstName.AutoSize = true;
            labelFirstName.Text = "First Name:";
            textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxFirstName.Size = new System.Drawing.Size(250, 27);

            labelSecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSecondName.AutoSize = true;
            labelSecondName.Text = "Second Name:";
            textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxSecondName.Size = new System.Drawing.Size(250, 27);

            labelFirstLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelFirstLastName.AutoSize = true;
            labelFirstLastName.Text = "First Last Name:";
            textBoxFirstLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxFirstLastName.Size = new System.Drawing.Size(250, 27);

            labelSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSecondLastName.AutoSize = true;
            labelSecondLastName.Text = "Second Last Name:";
            textBoxSecondLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxSecondLastName.Size = new System.Drawing.Size(250, 27);

            labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Text = "Phone:";
            textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxPhone.Size = new System.Drawing.Size(250, 27);

            labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAddress.AutoSize = true;
            labelAddress.Text = "Address:";
            textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxAddress.Size = new System.Drawing.Size(250, 27);

            labelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Text = "Birth Date:";
            dateTimePickerBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Size = new System.Drawing.Size(150, 27);

            labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Text = "Username:";
            textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxUsername.Size = new System.Drawing.Size(250, 27);

            labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Text = "Password Hash:";
            textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxPassword.Size = new System.Drawing.Size(250, 27);

            labelIsActive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelIsActive.AutoSize = true;
            labelIsActive.Text = "Active:";
            checkBoxIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;

            // flowLayoutPanelButtons
            flowLayoutPanelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.Controls.Add(buttonAddNew);
            flowLayoutPanelButtons.Controls.Add(buttonSave);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Controls.Add(buttonCancel);
            flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.TabIndex = 2;
            flowLayoutPanelButtons.WrapContents = false;

            // buttonAddNew
            buttonAddNew.Size = new System.Drawing.Size(120, 35);
            buttonAddNew.Text = "Add new user";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;

            // buttonSave
            buttonSave.Size = new System.Drawing.Size(80, 35);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;

            // buttonDelete
            buttonDelete.Size = new System.Drawing.Size(80, 35);
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;

            // buttonCancel
            buttonCancel.Size = new System.Drawing.Size(80, 35);
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;

            // UserForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(tableLayoutPanelMain);
            Name = "UserForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewUsers)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}