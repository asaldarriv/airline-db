namespace Airline.UI
{
    partial class CountryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Label labelIsoCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.TextBox textBoxIsoCode;
        private System.Windows.Forms.TextBox textBoxName;
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
            dataGridViewCountries = new System.Windows.Forms.DataGridView();
            labelIsoCode = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelActive = new System.Windows.Forms.Label();
            textBoxIsoCode = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            checkBoxActive = new System.Windows.Forms.CheckBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewCountries)).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            dataGridViewCountries.AllowUserToAddRows = false;
            dataGridViewCountries.AllowUserToDeleteRows = false;
            dataGridViewCountries.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries.Location = new System.Drawing.Point(14, 16);
            dataGridViewCountries.MultiSelect = false;
            dataGridViewCountries.Name = "dataGridViewCountries";
            dataGridViewCountries.ReadOnly = true;
            dataGridViewCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCountries.Size = new System.Drawing.Size(800, 250);
            dataGridViewCountries.TabIndex = 0;
            dataGridViewCountries.SelectionChanged += new System.EventHandler(this.dataGridViewCountries_SelectionChanged);
            // 
            // labelIsoCode
            // 
            labelIsoCode.AutoSize = true;
            labelIsoCode.Location = new System.Drawing.Point(50, 290);
            labelIsoCode.Name = "labelIsoCode";
            labelIsoCode.Size = new System.Drawing.Size(67, 20);
            labelIsoCode.Text = "ISO Code:";
            // 
            // textBoxIsoCode
            // 
            textBoxIsoCode.Location = new System.Drawing.Point(130, 287);
            textBoxIsoCode.Name = "textBoxIsoCode";
            textBoxIsoCode.Size = new System.Drawing.Size(100, 27);
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(250, 290);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(52, 20);
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(310, 287);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(200, 27);
            // 
            // labelActive
            // 
            labelActive.AutoSize = true;
            labelActive.Location = new System.Drawing.Point(530, 290);
            labelActive.Name = "labelActive";
            labelActive.Size = new System.Drawing.Size(53, 20);
            labelActive.Text = "Active:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.Location = new System.Drawing.Point(590, 287);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new System.Drawing.Size(20, 27);
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new System.Drawing.Point(50, 340);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new System.Drawing.Size(180, 35);
            buttonAddNew.Text = "Add new country";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(250, 340);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(100, 35);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(370, 340);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(100, 35);
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(490, 340);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(100, 35);
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CountryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(830, 400);
            Controls.Add(dataGridViewCountries);
            Controls.Add(labelIsoCode);
            Controls.Add(textBoxIsoCode);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelActive);
            Controls.Add(checkBoxActive);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Name = "CountryForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Countries";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewCountries)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}