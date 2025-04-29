namespace Airline.UI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EafitLogo = new PictureBox();
            LblTitulo = new Label();
            BtnCerrarSesion = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)EafitLogo).BeginInit();
            SuspendLayout();
            // 
            // EafitLogo
            // 
            EafitLogo.ImageLocation = "C:\\Users\\AlexEcoregistry\\Documents\\Dev\\gestion-de-datos\\Airline.UI\\logoEafit.ico";
            EafitLogo.Location = new Point(1, 1);
            EafitLogo.Name = "EafitLogo";
            EafitLogo.Size = new Size(261, 124);
            EafitLogo.TabIndex = 1;
            EafitLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(403, 51);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(210, 37);
            LblTitulo.TabIndex = 2;
            LblTitulo.Text = "Menú principal";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.Navy;
            BtnCerrarSesion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCerrarSesion.ForeColor = Color.White;
            BtnCerrarSesion.Location = new Point(117, 324);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(226, 55);
            BtnCerrarSesion.TabIndex = 8;
            BtnCerrarSesion.Text = "Cerrar sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnSalir_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(450, 324);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(226, 55);
            BtnSalir.TabIndex = 9;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click_1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalir);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(LblTitulo);
            Controls.Add(EafitLogo);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            ((System.ComponentModel.ISupportInitialize)EafitLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox EafitLogo;
        private Label LblTitulo;
        private Button BtnCerrarSesion;
        private Button BtnSalir;
    }
}