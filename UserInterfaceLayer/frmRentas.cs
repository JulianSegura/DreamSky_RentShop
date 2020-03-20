using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmRentas : Form
    {
        private frmMain _mainForm;

        public frmRentas()
        {
            InitializeComponent();
            tabRentas.Select();
        }
        public frmRentas(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            tabRentas.Select();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRentas_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

        private void CleanForm()
        {
            lblIdRentas.Text = ".....";
            lblNombreRentas.Text = ".....";
            lblApellidoRentas.Text = ".....";
            lblIdentificacionRentas.Text = ".....";
            lblPaisOrigenRentas.Text = ".....";
            lblFechaRegistroRentas.Text = ".....";
            lblCelularRentas.Text = ".....";
            lblTelefonoRentas.Text = ".....";
            lblDireccionRentas.Text = ".....";
            dtgRentasAbiertas.Rows.Clear();

            foreach (Control c in tabRentas.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c is DateTimePicker)
                {
                    (c as DateTimePicker).Value = DateTime.Today;
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).Text = "";
                }

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string customerId = txtBuscarCliente.Text.Trim();
            clsCliente searchCustomer = new ClienteLogic().GetById(customerId);
            if (searchCustomer.Id == 0)
            {
                MessageBox.Show("Cliente no registrado");
                CleanForm();
                txtBuscarCliente.Focus();
                return;
            }
            else
            {
                lblIdRentas.Text = searchCustomer.Id.ToString();
                lblNombreRentas.Text = searchCustomer.Nombres;
                lblApellidoRentas.Text = searchCustomer.Apellidos;
                lblIdentificacionRentas.Text = searchCustomer.Identificacion;
                lblPaisOrigenRentas.Text = searchCustomer.Nacionalidad;
                lblFechaRegistroRentas.Text = searchCustomer.FechaCreacion.ToString();
                lblCelularRentas.Text = searchCustomer.Celular;
                lblTelefonoRentas.Text = searchCustomer.Telefono;
                lblDireccionRentas.Text = searchCustomer.Direccion;

            }
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) btnBuscarCliente_Click(sender, e);
        }

        private void btnNuevaRenta_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.Value < dtpDesde.Value)
            {
                MessageBox.Show("La fecha de devolucion no puede ser menor a la fecha inicio de renta", "ERROR");
                dtpHasta.Focus();
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            int cantidadAlquilar = 1;//cantidad por defecto
            if (cmbBuscarArticulo.Text == "")
            {
                cmbBuscarArticulo.Focus();
                return;
            }

            if (txtCantidad.Text != "")
            {
                cantidadAlquilar = Convert.ToInt32(txtCantidad.Text);
            }

            string productCode = cmbBuscarArticulo.Text.Trim();
            clsInventario inventoryLine = new InventoryLogic().GetByCodigoProducto(productCode);

            if (inventoryLine == null)
            {
                MessageBox.Show("No tiene este producto registrado en el inventario.");
                txtCantidad.Text = "";
                cmbBuscarArticulo.Text = "";
                cmbBuscarArticulo.Focus();
                return;
            }

            inventoryLine.Producto = new ProductoLogic().GetAll().Where(p => p.codigoProducto == inventoryLine.CodigoProducto).FirstOrDefault();

            if (inventoryLine.Disponible < cantidadAlquilar)
            {
                MessageBox.Show(string.Format("No cuenta con productos suficientes en almacen\n Cantidad Disponible {0}", inventoryLine.Disponible), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtgRentasAbiertas.Rows.Count > 0)
            {
                UpdateInventoryLine(inventoryLine, cantidadAlquilar);
            }
            else
            {
                AddInventoryLine(inventoryLine, cantidadAlquilar);
            }

            lblTotalRenta.Text = string.Format("{0:C}", CalcularTotalRenta());

            txtCantidad.Clear();
            cmbBuscarArticulo.Text = "";
            cmbBuscarArticulo.Focus();
        }

        private void tabRentas_Enter(object sender, EventArgs e)
        {
            dtpDesde.MinDate = DateTime.Today;
            dtpHasta.MinDate = DateTime.Today;
            List<string> producCodeList = new List<string>();
            List<clsProducto> allProductos = new ProductoLogic().GetAll();

            foreach (clsProducto p in allProductos)
            {
                producCodeList.Add(p.codigoProducto);
            }
            cmbBuscarArticulo.DataSource = producCodeList;
            cmbBuscarArticulo.Text = "";
        }

        private void AddInventoryLine(clsInventario line, int cantidadProducto)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgRentasAbiertas);
            row.SetValues(line.CodigoProducto, line.Producto.Nombre, string.Format("{0:C}", line.Producto.costoAlquiler), cantidadProducto, string.Format("{0:C}", cantidadProducto * line.Producto.costoAlquiler));
            dtgRentasAbiertas.Rows.Add(row);
        }

        private void UpdateInventoryLine(clsInventario inventoryLine, int cantidadAlquilar)
        {
            foreach (DataGridViewRow row in dtgRentasAbiertas.Rows)
            {
                if (row.Cells["CodArticulo"].Value.ToString() == inventoryLine.CodigoProducto)
                {
                    row.Cells["QtyArticulo"].Value = cantidadAlquilar;
                    row.Cells["Total"].Value = string.Format("{0:C}", cantidadAlquilar * inventoryLine.Producto.costoAlquiler);
                }
            }
        }

        private double CalcularTotalRenta()
        {
            double total = 0;

            foreach (DataGridViewRow row in dtgRentasAbiertas.Rows)
            {
                total += double.Parse(row.Cells["Total"].Value.ToString(), System.Globalization.NumberStyles.Currency);
            }
            return total;
        }

        private void dtgRentasAbiertas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = dtgRentasAbiertas.SelectedRows[0].Cells["CodArticulo"].Value.ToString();
            txtCantidad.Text = dtgRentasAbiertas.SelectedRows[0].Cells["QtyArticulo"].Value.ToString();
        }

        private void dtgRentasAbiertas_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttip = new ToolTip();
            ttip.SetToolTip(dtgRentasAbiertas, "Doble click sobre un elemento para ACTUALIZAR");
        }

        private void btnGuardarRenta_Click(object sender, EventArgs e)
        {
            /*Al guardar la renta debe hacer lo siguiente:
            1. Guarda la renta en estado [Pendiente Entrega] (listo)
            2. Guarda el detalle (listo)
            3. Guarda el movimiento de inventario (pendiente trigger para tabla movinventario)
            4. Actualiza el inventario (lo hace al guardar el detalle - listo)
             */

            //validamos info de cliente y productos agregados
            if (lblIdRentas.Text == ".....")
            {
                MessageBox.Show("Ingrese Cliente");
                return;
            }
            if (dtgRentasAbiertas.Rows.Count < 1)
            {
                MessageBox.Show("Ingrese PRODUCTOS");
                return;
            }

            //Creamos una nueva linea de renta y la llenamos
            clsRenta newRenta = new clsRenta();
            newRenta.idCliente = lblIdentificacionRentas.Text;
            newRenta.contratoDesde = dtpDesde.Value;
            newRenta.contratoHasta = dtpHasta.Value;
            newRenta.Monto = CalcularTotalRenta();
            newRenta.Descuento = 0;
            newRenta.tipoNCF = null;
            newRenta.NCF = "";
            newRenta.RNCCliente = "";
            newRenta.Estado = "PENDIENTE ENTREGA";

            //agregamos el detalle de renta
            foreach (DataGridViewRow row in dtgRentasAbiertas.Rows)
            {
                newRenta.items.Add(
                    new clsRentaDetalle
                    {
                        CodProducto = row.Cells["CodArticulo"].Value.ToString(),
                        Cantidad = Convert.ToInt32(row.Cells["QtyArticulo"].Value)
                    });
            }

            //ejecutamos la insercion y mostramos resultado
            string result = new RentaLogic().Insert(newRenta);
            MessageBox.Show(result);
            CleanForm();
        }
    }
}
