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
    public partial class frmProductos : Form
    {
        private frmMain _mainForm;

        #region Shared_Mainform
        public frmProductos()
        {
            InitializeComponent();
        }
        public frmProductos(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

        private void fillCombos(ref ComboBox cb,DataTable dt)
        {
            cb.DataSource = dt;
            cb.ValueMember = dt.Columns[0].ToString();
            cb.DisplayMember = dt.Columns[1].ToString();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            tabProductos.Select();
            //dtgProductos.DataSource = new ProductoLogic().GetAll();
        }

        private void ClearTab(ref TabPage tab)
        {
            foreach (Control c in tab.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is CheckBox)
                    (c as CheckBox).Checked = false;
            }
        }
        #endregion

        #region Codigo_Para:Tab_Productos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearTab(ref tabProductos);
            cmbCategoriaProducto.SelectedIndex = 0;
            lblIdProducto.Text = ".....";
            txtCodeProducto.Focus();
        }

        private void dtgProductos_MouseHover(object sender, EventArgs e)
        {
            ToolTip productoToolTip = new ToolTip();
            productoToolTip.SetToolTip(dtgProductos, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EmptyProductFields()) return;

            string codProducto = txtCodeProducto.Text.Trim();
            string nombreProducto = txtNombreProducto.Text.Trim();
            string descProducto = txtDescripcion.Text.Trim();
            double costoProducto = double.Parse(txtCosto.Text.Trim(),System.Globalization.NumberStyles.Currency);
            int catProducto = Convert.ToInt32(cmbCategoriaProducto.SelectedValue);
            bool activo = chkActivoProductos.Checked;

            clsProducto newProducto = new clsProducto
            {
                codigoProducto = codProducto,
                Nombre = nombreProducto,
                Descripcion = descProducto,
                CategoriaProducto = catProducto,
                costoAlquiler = costoProducto,
                Activo = activo
            };

            string result = new ProductoLogic().Insert(newProducto);
            MessageBox.Show(result);
            ClearTab(ref tabProductos);
            lblIdProducto.Text = ".....";
            cmbCategoriaProducto.SelectedIndex = 0;
            txtCodeProducto.Focus();
        }

        private bool EmptyProductFields()
        {
            if (txtCodeProducto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un CODIGO PRODUCTO");
                return true;
            }
            if (txtNombreProducto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un NOMBRE PRODUCTO");
                return true;
            }
            if (txtCosto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un COSTO DE ALQUILER");
                return true;
            }
            if (cmbCategoriaProducto.SelectedValue.ToString() == 0.ToString())
            {
                MessageBox.Show("Seleccione una CATEGORIA PRODUCTO");
                return true;
            }
            return false;
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProductos.SelectedRows.Count < 1) return;

            int productId = Convert.ToInt32(dtgProductos.SelectedRows[0].Cells["IdProducto"].Value);
            clsProducto productToModify = new ProductoLogic().GetById(productId);

            if (productToModify==null)
            {
                MessageBox.Show("Seleccione un producto a modificar");
                return;
            }

            lblIdProducto.Text = productToModify.Id.ToString();
            txtCodeProducto.Text = productToModify.codigoProducto;
            chkActivoProductos.Checked = productToModify.Activo;
            txtNombreProducto.Text = productToModify.Nombre;
            txtCosto.Text = string.Format("{0:C}", productToModify.costoAlquiler);
            txtDescripcion.Text = productToModify.Descripcion;
            cmbCategoriaProducto.SelectedValue = productToModify.CategoriaProducto;
        }

        private void tabProductos_Enter(object sender, EventArgs e)
        {
            ClearTab(ref tabProductos);
            lblIdProducto.Text = ".....";
            fillCombos(ref cmbCategoriaProducto, new CategoriaProductoLogic().GetBasicInfo());
            dtgProductos.Rows.Clear();

            List<clsProducto> allProducts = new ProductoLogic().GetAll();
            foreach (clsProducto product in allProducts)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgProductos);
                row.SetValues(product.Id, product.codigoProducto, product.Nombre, product.CategoriaProducto,
                    new CategoriaProductoLogic().GetAll().Where(c => c.Id == product.CategoriaProducto).FirstOrDefault().Nombre,
                    string.Format("{0:C}",product.costoAlquiler),product.Activo
                    );
                dtgProductos.Rows.Add(row);
            }
            dtgProductos.ClearSelection();
            txtCodeProducto.Focus();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            if (EmptyProductFields()) return;

            int idProducto = int.Parse(lblIdProducto.Text);
            string codProducto = txtCodeProducto.Text.Trim();
            string nombreProducto = txtNombreProducto.Text.Trim();
            string descProducto = txtDescripcion.Text.Trim();
            double costoProducto = double.Parse(txtCosto.Text.Trim(), System.Globalization.NumberStyles.Currency);
            int catProducto = Convert.ToInt32(cmbCategoriaProducto.SelectedValue);
            bool activo = chkActivoProductos.Checked;

            clsProducto productToUpdate = new clsProducto
            {
                Id=idProducto,
                codigoProducto = codProducto,
                Nombre = nombreProducto,
                Descripcion = descProducto,
                CategoriaProducto = catProducto,
                costoAlquiler = costoProducto,
                Activo = activo
            };

            string result = new ProductoLogic().Update(productToUpdate);
            MessageBox.Show(result);
            tabProductos_Enter(sender, e);
        }
        #endregion

        #region Codigo_Para:Tab_Inventario
        private void tabInventario_Enter(object sender, EventArgs e)
        {
            ClearTab(ref tabInventario);
            dtgInventario.Rows.Clear();

            List<clsInventario> inventario = new InventoryLogic().GetAll();
            List<string> searchSource = new List<string>();

            foreach(clsInventario inventoryLine in inventario)
            {
                inventoryLine.Producto = new ProductoLogic().GetAll().Where(p => p.codigoProducto == inventoryLine.CodigoProducto).FirstOrDefault();
                inventoryLine.CategoriaProducto = new CategoriaProductoLogic().GetAll().Where(c => c.Id == inventoryLine.Producto.CategoriaProducto).FirstOrDefault();
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgInventario);
                newRow.SetValues(inventoryLine.CodigoProducto, inventoryLine.CategoriaProducto.Nombre, inventoryLine.Producto.Nombre,
                    inventoryLine.Disponible,string.Format("{0:C}",inventoryLine.Producto.costoAlquiler),
                    string.Format("{0:c}",inventoryLine.Disponible*inventoryLine.Producto.costoAlquiler));

                dtgInventario.Rows.Add(newRow);
                searchSource.Add(inventoryLine.CodigoProducto);
                //cmbBuscar.AutoCompleteCustomSource.Add(inventoryLine.CodigoProducto);
            }

            cmbBuscar.DataSource = searchSource;
            cmbBuscar.Text = "";

            dtgInventario.ClearSelection();
            cmbBuscar.Focus();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Trim() == "") return;
            string searchCriteria = cmbBuscar.Text;
            clsInventario inventoryItem = new InventoryLogic().GetByCodigoProducto(searchCriteria);
            inventoryItem.Producto = new ProductoLogic().GetAll().Where(p => p.codigoProducto == inventoryItem.CodigoProducto).FirstOrDefault();
            inventoryItem.CategoriaProducto = new CategoriaProductoLogic().GetAll().Where(c => c.Id == inventoryItem.Producto.CategoriaProducto).FirstOrDefault();

            dtgInventario.Rows.Clear();
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dtgInventario);
            newRow.SetValues(inventoryItem.CodigoProducto, inventoryItem.CategoriaProducto.Nombre, inventoryItem.Producto.Nombre,
                inventoryItem.Disponible, string.Format("{0:C}", inventoryItem.Producto.costoAlquiler),
                string.Format("{0:c}", inventoryItem.Disponible * inventoryItem.Producto.costoAlquiler));

            dtgInventario.Rows.Add(newRow);

        }


        private void cmbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbBuscar.DroppedDown = false;
        }
        #endregion

    }
}
