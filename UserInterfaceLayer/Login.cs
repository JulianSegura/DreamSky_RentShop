using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class Login : Form
    {
        frmMain frmMain = new frmMain();
        public Login()
        {
            Thread Wait = new Thread(new ThreadStart(Presentacion));
            frmMain.Show();
            Wait.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            Wait.Abort();
        }
        private void Presentacion() { Application.Run(new Splash()); }//Muestra el splash
        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region PlaceHolders
        private void txtLoginUsuario_Enter(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "USUARIO")
            {
                txtLoginUsuario.Text = "";
                txtLoginUsuario.ForeColor = Color.White;
            }
        }

        private void txtLoginUsuario_Leave(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "")
            {
                txtLoginUsuario.Text = "USUARIO";
                txtLoginUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtLoginPassword_Enter(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "CONTRASEÑA")
            {
                txtLoginPassword.Text = "";
                txtLoginPassword.ForeColor = Color.White;
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "")
            {
                txtLoginPassword.Text = "CONTRASEÑA";
                txtLoginPassword.ForeColor = Color.DimGray;
                txtLoginPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void btnLoginAcceder_Click(object sender, EventArgs e)
        {
            string userName = txtLoginUsuario.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            clsUsuario user = new UsuarioLogic().Validate(userName, password);

            if (user != null)
            {
                this.Hide();
                frmMain.registeredUser = user;
                frmMain.lblActualUser.Text = user.NombreCompleto;
                frmMain.label3.Visible = true;
                frmMain.lblActualUser.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrecto");
                txtLoginUsuario.Text = "";
                txtLoginPassword.Text = "";
                txtLoginUsuario_Leave(sender, e);
                txtLoginPassword_Leave(sender, e);
                txtLoginUsuario.Focus();
            }
        }
    }
}
