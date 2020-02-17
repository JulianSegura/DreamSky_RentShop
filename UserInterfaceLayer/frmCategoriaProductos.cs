using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer;
using DreamSkyEntities;

namespace UserInterfaceLayer
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            List<clsCategoriaProducto> categorias = new BsCategoriaProducto().GetAll();
            dgvCategorias.DataSource = categorias;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim()=="")
            {
                MessageBox.Show("Debe agregar un nombre a la categoria");
                return;
            }

            clsCategoriaProducto _newCategory = new clsCategoriaProducto { Nombre = txtName.Text.Trim(), Activo = chkStatus.Checked };
            string result = new BsCategoriaProducto().AddCategoria(_newCategory);
            MessageBox.Show(result);

            txtName.Clear();
            chkStatus.Checked = false;

            frmCategoriaProductos_Load(sender, e);
        }
    }
}
