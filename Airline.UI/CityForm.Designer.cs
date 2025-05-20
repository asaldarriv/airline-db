namespace Airline.UI
{
    partial class CityForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
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
            components = new System.ComponentModel.Container();
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewCities = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelActive = new System.Windows.Forms.Label();
            checkBoxActive = new System.Windows.Forms.CheckBox();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewCities)).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanelMain
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(dataGridViewCities, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewCities
            dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCities.AllowUserToAddRows = false;
            dataGridViewCities.AllowUserToDeleteRows = false;
            dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.MultiSelect = false;
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.ReadOnly = true;
            dataGridViewCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCities.TabIndex = 0;
            dataGridViewCities.SelectionChanged += new System.EventHandler(this.dataGridViewCities_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.RowCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelInputs.Size = new System.Drawing.Size(400, 70);
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelName
            labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Text = "Name:";
            tableLayoutPanelInputs.Controls.Add(labelName, 0, 0);

            // textBoxName
            textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxName.Size = new System.Drawing.Size(250, 27);
            tableLayoutPanelInputs.Controls.Add(textBoxName, 1, 0);

            // labelActive
            labelActive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelActive.AutoSize = true;
            labelActive.Text = "Active:";
            tableLayoutPanelInputs.Controls.Add(labelActive, 0, 1);

            // checkBoxActive
            checkBoxActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxActive.Size = new System.Drawing.Size(20, 27);
            tableLayoutPanelInputs.Controls.Add(checkBoxActive, 1, 1);

            // flowLayoutPanelButtons
            flowLayoutPanelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.WrapContents = false;
            flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);

            // buttonAddNew
            buttonAddNew.Text = "Add new city";
            buttonAddNew.Size = new System.Drawing.Size(120, 35);
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);

            // buttonSave
            buttonSave.Text = "Save";
            buttonSave.Size = new System.Drawing.Size(80, 35);
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // buttonDelete
            buttonDelete.Text = "Delete";
            buttonDelete.Size = new System.Drawing.Size(80, 35);
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // buttonCancel
            buttonCancel.Text = "Cancel";
            buttonCancel.Size = new System.Drawing.Size(80, 35);
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // Añadir botones al FlowLayoutPanel
            flowLayoutPanelButtons.Controls.Add(buttonAddNew);
            flowLayoutPanelButtons.Controls.Add(buttonSave);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Controls.Add(buttonCancel);

            // CityForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(830, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "CityForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cities";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewCities)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}