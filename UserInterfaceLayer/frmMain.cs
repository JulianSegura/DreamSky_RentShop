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
                btnMainLogout.Width = 45;
                AnimacionSider1.Show(Sidebar);
                label1.Text = "MENÚ";
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 202;
                SidebarWrapper.Width = 226;
                Separador.Width = 252;
                btnMainLogout.Width = 202;
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

        private void btnMainRentas_Click(object sender, EventArgs e)
        {
            var frmRentas = new frmRentas(this);
            Formhijo(frmRentas);
            btnMainRentas.Enabled = false;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "RENTAS";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "RENTAS") btnMainRentas.DisabledColor = Color.DarkSlateGray;
        }

        private void btnMainClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes(this);
            Formhijo(frmClientes);

            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = false;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "CLIENTES";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "CLIENTES") btnMainClientes.DisabledColor = Color.DarkSlateGray;
        }

        private void btnMainProductos_Click(object sender, EventArgs e)
        {
            var frmProductos = new frmProductos(this);
            Formhijo(frmProductos);
            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = false;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "PRODUCTOS";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "PRODUCTOS") btnMainProductos.DisabledColor = Color.DarkSlateGray;
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
            //EnableButtons();
        }

        private void btnMainMaestros_Click(object sender, EventArgs e)
        {
            var frmMaestro = new frmMaestros(this);
            Formhijo(frmMaestro);

            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = false;
            lblFormActual.Text = "MAESTROS";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "MAESTROS") btnMainMaestros.DisabledColor = Color.DarkSlateGray;
        }
        public void EnableButtons()
        {
            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "";
        }

        //public static implicit operator frmMain(frmProductos v)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnMainReportes_Click(object sender, EventArgs e)
        {
            var frmReportes = new frmReportes(this);
            Formhijo(frmReportes);
            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = false;
            btnMainPerfil.Enabled = true;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "REPORTES";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "REPORTES") btnMainReportes.DisabledColor = Color.DarkSlateGray;
        }

        private void btnMainPerfil_Click(object sender, EventArgs e)
        {
            var frmPerfil = new frmPerfil(this);
            Formhijo(frmPerfil);
            btnMainRentas.Enabled = true;
            btnMainClientes.Enabled = true;
            btnMainProductos.Enabled = true;
            btnMainReportes.Enabled = true;
            btnMainPerfil.Enabled = false;
            btnMainMaestros.Enabled = true;
            lblFormActual.Text = "PERFIL";
            lblFormActual.Visible = true;
            if (lblFormActual.Text == "PERFIL") btnMainPerfil.DisabledColor = Color.DarkSlateGray;
        }

        private void btnMainLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
