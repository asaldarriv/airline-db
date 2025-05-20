namespace Airline.UI
{
    partial class LuggageForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewLuggages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelTicketId;
        private System.Windows.Forms.TextBox textBoxTicketId;
        private System.Windows.Forms.Label labelLuggageTypeId;
        private System.Windows.Forms.TextBox textBoxLuggageTypeId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
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
            dataGridViewLuggages = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelTicketId = new System.Windows.Forms.Label();
            textBoxTicketId = new System.Windows.Forms.TextBox();
            labelLuggageTypeId = new System.Windows.Forms.Label();
            textBoxLuggageTypeId = new System.Windows.Forms.TextBox();
            labelQuantity = new System.Windows.Forms.Label();
            numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewLuggages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownQuantity)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewLuggages, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewLuggages
            dataGridViewLuggages.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewLuggages.AllowUserToAddRows = false;
            dataGridViewLuggages.AllowUserToDeleteRows = false;
            dataGridViewLuggages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLuggages.MultiSelect = false;
            dataGridViewLuggages.Name = "dataGridViewLuggages";
            dataGridViewLuggages.ReadOnly = true;
            dataGridViewLuggages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLuggages.TabIndex = 0;
            dataGridViewLuggages.SelectionChanged += new System.EventHandler(this.dataGridViewLuggages_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelTicketId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxTicketId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelLuggageTypeId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxLuggageTypeId, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelQuantity, 0, 2);
            tableLayoutPanelInputs.Controls.Add(numericUpDownQuantity, 1, 2);
            tableLayoutPanelInputs.RowCount = 3;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelTicketId
            labelTicketId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelTicketId.AutoSize = true;
            labelTicketId.Text = "Ticket ID:";

            // textBoxTicketId
            textBoxTicketId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxTicketId.Size = new System.Drawing.Size(250, 27);

            // labelLuggageTypeId
            labelLuggageTypeId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelLuggageTypeId.AutoSize = true;
            labelLuggageTypeId.Text = "Luggage Type ID:";

            // textBoxLuggageTypeId
            textBoxLuggageTypeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxLuggageTypeId.Size = new System.Drawing.Size(250, 27);

            // labelQuantity
            labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelQuantity.AutoSize = true;
            labelQuantity.Text = "Quantity:";

            // numericUpDownQuantity
            numericUpDownQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDownQuantity.Minimum = 1;
            numericUpDownQuantity.Maximum = 100;
            numericUpDownQuantity.Value = 1;
            numericUpDownQuantity.Size = new System.Drawing.Size(80, 27);

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
            buttonAddNew.Text = "Add new luggage";
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

            // LuggageForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(830, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "LuggageForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Luggages";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewLuggages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownQuantity)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}