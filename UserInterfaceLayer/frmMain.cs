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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Restore.Visible = true;
            Maximizar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restore.Visible = false;
            Maximizar.Visible = true;
        }

        private void Menusidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width > 200)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 45;
                SidebarWrapper.Width = 70;
                Separador.Width = 35;
                AnimacionSider1.Show(Sidebar);
                label1.Text = "MENÚ";
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 202;
                SidebarWrapper.Width = 226;
                Separador.Width = 252;
                AnimacionSider2.Show(Sidebar);
                label1.Text = "OCULTAR MENÚ";
            }
                                                      
        }

        private Form activeForm = null;
        private void Formhijo(Form formulariohijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            Formhijos.Controls.Add(formulariohijo);
            Formhijos.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var frmRentas = new frmRentas(this);
            Formhijo(frmRentas);
            bunifuFlatButton1.Enabled = false;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "RENTAS";
            lblFormActual.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes(this);
            Formhijo(frmClientes);

            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = false;
            bunifuFlatButton3.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "CLIENTES";
            lblFormActual.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var frmProductos = new frmProductos(this);
            Formhijo(frmProductos);
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = false;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "PRODUCTOS";
            lblFormActual.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFormActual.Visible = false;

            Sidebar.Visible = false;
            Sidebar.Width = 202;
            SidebarWrapper.Width = 226;
            Separador.Width = 252;
            AnimacionSider2.Show(Sidebar);
            label1.Text = "OCULTAR MENÚ";
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            var frmMaestro = new frmMaestros(this);
            Formhijo(frmMaestro);

            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = false;
            lblFormActual.Text = "MAESTROS";
            lblFormActual.Visible = true;
        }
        public void EnableButtons()
        {
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "";
        }

        public static implicit operator frmMain(frmProductos v)
        {
            throw new NotImplementedException();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var frmReportes = new frmReportes(this);
            Formhijo(frmReportes);
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = false;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "REPORTES";
            lblFormActual.Visible = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            var frmPerfil = new frmPerfil(this);
            Formhijo(frmPerfil);
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton3.Enabled = false;
            bunifuFlatButton4.Enabled = true;
            bunifuFlatButton5.Enabled = true;
            bunifuFlatButton6.Enabled = true;
            lblFormActual.Text = "PERFIL";
            lblFormActual.Visible = true;
        }
    }
}
