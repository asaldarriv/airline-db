using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = TxUsuario.Text;
                string contrasena = TxContrasena.Text;
                bool EsCorrecto;
                EsCorrecto = false;

                FacadeLogin facadeLogin = new FacadeLogin();

                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("El campo usuario no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("El campo contraseña no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EsCorrecto = facadeLogin.ValidarLogin(usuario, contrasena);

                if (EsCorrecto)
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + error.StackTrace, "Error controlado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
