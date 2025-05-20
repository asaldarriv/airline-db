namespace Airline.UI
{
    partial class DocumentTypesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewDocumentTypes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.CheckBox checkBoxActive;
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
            tableLayoutPanelMain = new TableLayoutPanel();
            dataGridViewDocumentTypes = new DataGridView();
            tableLayoutPanelInputs = new TableLayoutPanel();
            labelCode = new Label();
            textBoxCode = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelActive = new Label();
            checkBoxActive = new CheckBox();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonAddNew = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonCancel = new Button();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocumentTypes).BeginInit();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(dataGridViewDocumentTypes, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // DataGridView ocupa todo el espacio restante
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));      // Inputs se ajustan automáticamente
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));      // Botones se ajustan automáticamente
            tableLayoutPanelMain.Size = new Size(830, 480);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // dataGridViewDocumentTypes
            // 
            dataGridViewDocumentTypes.AllowUserToAddRows = false;
            dataGridViewDocumentTypes.AllowUserToDeleteRows = false;
            dataGridViewDocumentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocumentTypes.Dock = DockStyle.Fill;
            dataGridViewDocumentTypes.Location = new Point(3, 3);
            dataGridViewDocumentTypes.MultiSelect = false;
            dataGridViewDocumentTypes.Name = "dataGridViewDocumentTypes";
            dataGridViewDocumentTypes.ReadOnly = true;
            dataGridViewDocumentTypes.RowHeadersWidth = 51;
            dataGridViewDocumentTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDocumentTypes.Size = new Size(824, 304);
            dataGridViewDocumentTypes.TabIndex = 0;
            dataGridViewDocumentTypes.SelectionChanged += dataGridViewDocumentTypes_SelectionChanged;
            // 
            // tableLayoutPanelInputs
            // 
            tableLayoutPanelInputs.Anchor = AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelCode, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxCode, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelName, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelDescription, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxDescription, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelActive, 0, 3);
            tableLayoutPanelInputs.Controls.Add(checkBoxActive, 1, 3);
            tableLayoutPanelInputs.Location = new Point(165, 313);
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.RowCount = 4;
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelInputs.TabIndex = 1;
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Text = "Code:";
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Left;
            textBoxCode.Size = new Size(250, 27);
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.Size = new Size(250, 27);
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Left;
            textBoxDescription.Size = new Size(250, 27);
            // 
            // labelActive
            // 
            labelActive.Anchor = AnchorStyles.Right;
            labelActive.AutoSize = true;
            labelActive.Text = "Active:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.Anchor = AnchorStyles.Left;
            checkBoxActive.Size = new Size(20, 24);
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Anchor = AnchorStyles.None;
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.Controls.Add(buttonAddNew);
            flowLayoutPanelButtons.Controls.Add(buttonSave);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Controls.Add(buttonCancel);
            flowLayoutPanelButtons.Margin = new Padding(0, 10, 0, 10);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(434, 40);
            flowLayoutPanelButtons.TabIndex = 2;
            flowLayoutPanelButtons.WrapContents = false;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Size = new Size(170, 35);
            buttonAddNew.Text = "Add new document type";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Size = new Size(80, 35);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Size = new Size(80, 35);
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Size = new Size(80, 35);
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DocumentTypesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "DocumentTypesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Document Types";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocumentTypes).EndInit();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}