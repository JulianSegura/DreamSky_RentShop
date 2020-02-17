using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DreamSkyEntities;

namespace UserInterfaceLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radActive.Checked = true;
            lblCurrentDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUsuario newUser = new clsUsuario();
            newUser.Nombres = txtNames.Text.Trim();
            newUser.Apellidos = txtLastNames.Text.Trim();
            newUser.UserName = txtUser.Text.Trim();
            newUser.Password = txtPassword.Text.Trim();
            if (radActive.Checked == true)
            {
                newUser.Activo = true;
            }
            else
            {
                newUser.Activo = false;
            }
            BusinessUsuario newBLUsuario = new BusinessUsuario();
            String result=newBLUsuario.AddUser(newUser);
            MessageBox.Show(result);
        }
    }
}
