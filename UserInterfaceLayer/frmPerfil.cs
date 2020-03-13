using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmPerfil : Form
    {
        private frmMain _mainForm;
        public frmPerfil()
        {
            InitializeComponent();
        }
        public frmPerfil(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm =  mainForm;
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
                btnEditar.Text = "Editar Contraseña";
                txtPassword1.Visible = false;
                txtPassword2.Visible = false;
                lblPassword1.Visible = false;
                lblPassword2.Visible = false;
            }
                
        }
    }
}
