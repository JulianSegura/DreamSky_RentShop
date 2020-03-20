using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmPerfil : Form
    {
        private frmMain _mainForm;
        private clsUsuario _currentUser;
        public frmPerfil()
        {
            InitializeComponent();
        }
        public frmPerfil(frmMain mainForm, clsUsuario User)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _currentUser = User;
            lblNombre.Text = _currentUser.Nombres;
            lblApellido.Text = _currentUser.Apellidos;
            lblRol.Text = _currentUser.Rol.Nombre;
            lblUsuario.Text = _currentUser.UserName;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar Contraseña")
            {
                btnEditar.Text = "Guardar Contraseña";
                txtPassword1.Visible = true;
                txtPassword2.Visible = true;
                lblPassword1.Visible = true;
                lblPassword2.Visible = true;

            }
            else
            {
                if (txtPassword1.Text.Trim() != txtPassword2.Text.Trim())
                {
                    MessageBox.Show("CONTRASEÑA NO COINCIDE");
                    return;
                }
                _currentUser.Password = txtPassword2.Text.Trim();
                string result = new UsuarioLogic().Update(_currentUser);
                MessageBox.Show(result);
                btnEditar.Text = "Editar Contraseña";
                txtPassword1.Clear();
                txtPassword1.Visible = false;
                txtPassword2.Clear();
                txtPassword2.Visible = false;
                lblPassword1.Visible = false;
                lblPassword2.Visible = false;
            }

        }
    }
}
