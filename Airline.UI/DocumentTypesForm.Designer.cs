namespace Airline.UI
{
    partial class DocumentTypesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDocumentTypes;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNew;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewDocumentTypes = new DataGridView();
            labelCode = new Label();
            labelName = new Label();
            labelDescription = new Label();
            labelActive = new Label();
            textBoxCode = new TextBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            checkBoxActive = new CheckBox();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonCancel = new Button();
            buttonAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocumentTypes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDocumentTypes
            // 
            dataGridViewDocumentTypes.AllowUserToAddRows = false;
            dataGridViewDocumentTypes.AllowUserToDeleteRows = false;
            dataGridViewDocumentTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDocumentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocumentTypes.Location = new Point(14, 16);
            dataGridViewDocumentTypes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDocumentTypes.MultiSelect = false;
            dataGridViewDocumentTypes.Name = "dataGridViewDocumentTypes";
            dataGridViewDocumentTypes.ReadOnly = true;
            dataGridViewDocumentTypes.RowHeadersWidth = 51;
            dataGridViewDocumentTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDocumentTypes.Size = new Size(1002, 293);
            dataGridViewDocumentTypes.TabIndex = 0;
            dataGridViewDocumentTypes.SelectionChanged += dataGridViewDocumentTypes_SelectionChanged;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(200, 348);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(47, 20);
            labelCode.TabIndex = 1;
            labelCode.Text = "Code:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(399, 348);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Name:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(199, 401);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(88, 20);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description:";
            // 
            // labelActive
            // 
            labelActive.AutoSize = true;
            labelActive.Location = new Point(756, 348);
            labelActive.Name = "labelActive";
            labelActive.Size = new Size(53, 20);
            labelActive.TabIndex = 7;
            labelActive.Text = "Active:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(253, 345);
            textBoxCode.Margin = new Padding(3, 4, 3, 4);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(115, 27);
            textBoxCode.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(457, 345);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(293, 398);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(538, 27);
            textBoxDescription.TabIndex = 6;
            // 
            // checkBoxActive
            // 
            checkBoxActive.Location = new Point(813, 345);
            checkBoxActive.Margin = new Padding(3, 4, 3, 4);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(23, 32);
            checkBoxActive.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(443, 449);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(114, 40);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(580, 449);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(114, 40);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(717, 449);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 40);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(199, 449);
            buttonAddNew.Margin = new Padding(3, 4, 3, 4);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(214, 40);
            buttonAddNew.TabIndex = 9;
            buttonAddNew.Text = "Add new document type";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // DocumentTypesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 522);
            Controls.Add(dataGridViewDocumentTypes);
            Controls.Add(labelCode);
            Controls.Add(textBoxCode);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelActive);
            Controls.Add(checkBoxActive);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DocumentTypesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Document Types";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocumentTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}