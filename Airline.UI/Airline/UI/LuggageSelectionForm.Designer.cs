using Airline.UI.Controls;

namespace Airline.UI
{
    partial class LuggageSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLuggageType;
        private System.Windows.Forms.ComboBox comboBoxLuggageType;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private ModernButton buttonAddLuggage;
        private ModernButton buttonRemoveSelected;
        private System.Windows.Forms.DataGridView dataGridViewSelectedLuggages;
        private ModernButton buttonContinue;
        private ModernButton buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLuggageType = new System.Windows.Forms.Label();
            this.comboBoxLuggageType = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddLuggage = new ModernButton();
            this.buttonRemoveSelected = new ModernButton();
            this.dataGridViewSelectedLuggages = new System.Windows.Forms.DataGridView();
            this.buttonContinue = new ModernButton();
            this.buttonCancel = new ModernButton();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedLuggages)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();

            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F)); // Title
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F)); // Luggage type + Quantity
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F)); // Add/Remove buttons
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F)); // Spacer
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // DataGrid
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F)); // Spacer
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F)); // Continue/Cancel
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelMain.SetColumnSpan(this.labelTitle, 4);

            // Row 1: Luggage type + Quantity
            this.tableLayoutPanelMain.Controls.Add(this.labelLuggageType, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxLuggageType, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelQuantity, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownQuantity, 3, 1);

            // Row 2: Add/Remove buttons
            this.tableLayoutPanelMain.Controls.Add(this.buttonAddLuggage, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonRemoveSelected, 3, 2);

            // Row 4: DataGrid
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewSelectedLuggages, 0, 4);
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewSelectedLuggages, 4);

            // Row 6: Continue/Cancel
            this.tableLayoutPanelMain.Controls.Add(this.buttonContinue, 2, 6);
            this.tableLayoutPanelMain.Controls.Add(this.buttonCancel, 3, 6);

            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Text = "Select your luggages";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.AutoSize = true;

            // 
            // labelLuggageType
            // 
            this.labelLuggageType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLuggageType.AutoSize = true;
            this.labelLuggageType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelLuggageType.Text = "Luggage type:";
            this.labelLuggageType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // comboBoxLuggageType
            // 
            this.comboBoxLuggageType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxLuggageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLuggageType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.comboBoxLuggageType.Name = "comboBoxLuggageType";
            this.comboBoxLuggageType.Size = new System.Drawing.Size(200, 29);

            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelQuantity.Text = "Quantity:";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.numericUpDownQuantity.Minimum = 1;
            this.numericUpDownQuantity.Maximum = 10;
            this.numericUpDownQuantity.Value = 1;
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(80, 29);

            // 
            // buttonAddLuggage
            // 
            this.buttonAddLuggage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddLuggage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonAddLuggage.Text = "Add";
            this.buttonAddLuggage.Name = "buttonAddLuggage";
            this.buttonAddLuggage.Size = new System.Drawing.Size(120, 32);
            this.buttonAddLuggage.UseVisualStyleBackColor = true;
            this.buttonAddLuggage.Click += new System.EventHandler(this.buttonAddLuggage_Click);

            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRemoveSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonRemoveSelected.Text = "Remove selected";
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(150, 32);
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);

            // 
            // dataGridViewSelectedLuggages
            // 
            this.dataGridViewSelectedLuggages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelectedLuggages.Name = "dataGridViewSelectedLuggages";
            this.dataGridViewSelectedLuggages.ReadOnly = true;
            this.dataGridViewSelectedLuggages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelectedLuggages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectedLuggages.BackgroundColor = System.Drawing.Color.Gainsboro;

            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(140, 40);
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);

            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 40);
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // 
            // LuggageSelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "LuggageSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Luggage Selection";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedLuggages)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}