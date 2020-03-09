using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmMaestros : Form
    {
        private frmMain _mainForm;

        public frmMaestros()
        {
            InitializeComponent();
        }
        public frmMaestros(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.tabCategoria.Select();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMaestros_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

#region Codigo_Para:Tab_categorias_Producto
        private void tabCategoria_Enter(object sender, EventArgs e)
        //Presenta todas las categorias registradas cuando se carga/selecciona el TAB
        {
            ClearTabFields(tabCategoria);
            btnActualizaCproducto.Visible = false;
            btnGuardaCproducto.Visible = true;
            dtgCategoriaProducto.Rows.Clear();
            List<clsCategoriaProducto> CategoriesList = new CategoriaProductoLogic().GetAll();
            foreach (clsCategoriaProducto categoriaProducto in CategoriesList)
            {
                DataGridViewRow dtgRow = new DataGridViewRow();
                dtgRow.CreateCells(dtgCategoriaProducto);
                dtgRow.SetValues(categoriaProducto.Id, categoriaProducto.Nombre, categoriaProducto.Activo);
                dtgCategoriaProducto.Rows.Add(dtgRow);
            }
            dtgCategoriaProducto.ClearSelection();
        }

        private void dtgCategoriaProducto_MouseEnter(object sender, EventArgs e)
        //Presenta el Tooltip para datagridview categorias producto
        {
            ToolTip categoriaToolTip = new ToolTip();
            categoriaToolTip.SetToolTip(dtgCategoriaProducto, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void btnGuardaCproducto_Click(object sender, EventArgs e)
        //Guarda la informacion de una nueva categoria
        {
            if (txtCategoriaProducto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Agregar NOMBRE para categoria de producto");
                return;
            }
            string categoryName = txtCategoriaProducto.Text.Trim();
            bool Activo = chkCategoriaProducto.Checked;
            clsCategoriaProducto newCategoria = new clsCategoriaProducto();
            newCategoria.Nombre = categoryName;
            newCategoria.Activo = Activo;
            string result = new CategoriaProductoLogic().Insert(newCategoria);
            MessageBox.Show(result);
            tabCategoria_Enter(sender, e);
            txtCategoriaProducto.Focus();

        }

        private void dtgCategoriaProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //Metodo para cargar informacion a actualizar
        {
            txtCategoriaProducto.Text = Convert.ToString(dtgCategoriaProducto.SelectedRows[0].Cells["Nombre"].Value);
            chkCategoriaProducto.Checked = Convert.ToBoolean(dtgCategoriaProducto.SelectedRows[0].Cells["Activo"].Value);
            btnGuardaCproducto.Visible = false;
            btnActualizaCproducto.Visible = true;
            btnActualizaCproducto.Location = btnGuardaCproducto.Location;
        }

        private void btnActualizaCproducto_Click(object sender, EventArgs e)
        //Actualiza informacion de categoria existente
        {
            clsCategoriaProducto categoryToModify = new clsCategoriaProducto();
            categoryToModify.Id = Convert.ToInt32(dtgCategoriaProducto.SelectedRows[0].Cells["Id"].Value);
            categoryToModify.Nombre = txtCategoriaProducto.Text.Trim();
            categoryToModify.Activo = chkCategoriaProducto.Checked;

            string result = new CategoriaProductoLogic().Update(categoryToModify);
            MessageBox.Show(result);
            tabCategoria_Enter(sender, e);
            txtCategoriaProducto.Focus();
        }
        private void btnLimpiarCProducto_Click(object sender, EventArgs e)
        {
            tabCategoria_Enter(sender, e);
        }
        #endregion

        private void ClearTabFields(TabPage tab)
        //Metodo para limpiar los TextBox y CheckBox
        {
            foreach (Control c in tab.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is CheckBox)
                    (c as CheckBox).Checked = false;
            }
        }

    }
}