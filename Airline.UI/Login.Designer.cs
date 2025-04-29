namespace Airline.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            EafitLogo = new PictureBox();
            Titulo = new Label();
            LbUsuario = new Label();
            LbContrasena = new Label();
            TxUsuario = new TextBox();
            TxContrasena = new TextBox();
            BtnIngresar = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)EafitLogo).BeginInit();
            SuspendLayout();
            // 
            // EafitLogo
            // 
            EafitLogo.ImageLocation = "C:\\Users\\AlexEcoregistry\\Documents\\Dev\\gestion-de-datos\\Airline.UI\\logoEafit.ico";
            EafitLogo.Location = new Point(0, 3);
            EafitLogo.Name = "EafitLogo";
            EafitLogo.Size = new Size(261, 124);
            EafitLogo.TabIndex = 0;
            EafitLogo.TabStop = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Navy;
            Titulo.Location = new Point(358, 45);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(282, 37);
            Titulo.TabIndex = 1;
            Titulo.Text = "Aplicación Aerolínea";
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbUsuario.ForeColor = Color.Navy;
            LbUsuario.Location = new Point(165, 190);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(123, 37);
            LbUsuario.TabIndex = 2;
            LbUsuario.Text = "Usuario:";
            // 
            // LbContrasena
            // 
            LbContrasena.AutoSize = true;
            LbContrasena.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbContrasena.ForeColor = Color.Navy;
            LbContrasena.Location = new Point(119, 263);
            LbContrasena.Name = "LbContrasena";
            LbContrasena.Size = new Size(169, 37);
            LbContrasena.TabIndex = 3;
            LbContrasena.Text = "Contraseña:";
            LbContrasena.Click += label1_Click;
            // 
            // TxUsuario
            // 
            TxUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxUsuario.Location = new Point(332, 190);
            TxUsuario.Name = "TxUsuario";
            TxUsuario.Size = new Size(200, 35);
            TxUsuario.TabIndex = 4;
            // 
            // TxContrasena
            // 
            TxContrasena.BorderStyle = BorderStyle.FixedSingle;
            TxContrasena.Font = new Font("Segoe UI", 15.75F);
            TxContrasena.Location = new Point(332, 263);
            TxContrasena.Name = "TxContrasena";
            TxContrasena.Size = new Size(200, 35);
            TxContrasena.TabIndex = 5;
            TxContrasena.UseSystemPasswordChar = true;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.Navy;
            BtnIngresar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(210, 352);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(140, 55);
            BtnIngresar.TabIndex = 6;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(423, 352);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(140, 55);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalir);
            Controls.Add(BtnIngresar);
            Controls.Add(TxContrasena);
            Controls.Add(TxUsuario);
            Controls.Add(LbContrasena);
            Controls.Add(LbUsuario);
            Controls.Add(Titulo);
            Controls.Add(EafitLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universidad EAFIT - Aerolínea - Login";
            ((System.ComponentModel.ISupportInitialize)EafitLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox EafitLogo;
        private Label Titulo;
        private Label LbUsuario;
        private Label LbContrasena;
        private TextBox TxUsuario;
        private TextBox TxContrasena;
        private Button BtnIngresar;
        private Button BtnSalir;
    }
}