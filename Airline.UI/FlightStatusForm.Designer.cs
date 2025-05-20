namespace Airline.UI
{
    partial class FlightStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewStatuses;
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
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewStatuses = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelCode = new System.Windows.Forms.Label();
            textBoxCode = new System.Windows.Forms.TextBox();
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelDescription = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            labelActive = new System.Windows.Forms.Label();
            checkBoxActive = new System.Windows.Forms.CheckBox();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewStatuses)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewStatuses, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewStatuses
            dataGridViewStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewStatuses.AllowUserToAddRows = false;
            dataGridViewStatuses.AllowUserToDeleteRows = false;
            dataGridViewStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatuses.MultiSelect = false;
            dataGridViewStatuses.Name = "dataGridViewStatuses";
            dataGridViewStatuses.ReadOnly = true;
            dataGridViewStatuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatuses.TabIndex = 0;
            dataGridViewStatuses.SelectionChanged += new System.EventHandler(this.dataGridViewStatuses_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelCode, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxCode, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelName, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelDescription, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxDescription, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelActive, 0, 3);
            tableLayoutPanelInputs.Controls.Add(checkBoxActive, 1, 3);
            tableLayoutPanelInputs.RowCount = 4;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelCode
            labelCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Text = "Code:";

            // textBoxCode
            textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxCode.Size = new System.Drawing.Size(250, 27);

            // labelName
            labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Text = "Name:";

            // textBoxName
            textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxName.Size = new System.Drawing.Size(250, 27);

            // labelDescription
            labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Text = "Description:";

            // textBoxDescription
            textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxDescription.Size = new System.Drawing.Size(250, 27);

            // labelActive
            labelActive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelActive.AutoSize = true;
            labelActive.Text = "Active:";

            // checkBoxActive
            checkBoxActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxActive.Size = new System.Drawing.Size(20, 24);

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
            buttonAddNew.Size = new System.Drawing.Size(170, 35);
            buttonAddNew.Text = "Add new status";
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

            // FlightStatusForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(830, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "FlightStatusForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Flight Statuses";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewStatuses)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}