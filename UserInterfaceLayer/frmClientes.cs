using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmClientes : Form
    {

        #region Shared_Mainform
        private frmMain _mainForm;

        public frmClientes()
        {
            InitializeComponent();

        }
        public frmClientes(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            _mainForm.EnableButtons();
        }

        private void ClearForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is CheckBox)
                {
                    (c as CheckBox).Checked = false;
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = 0;
                }
            }
        }

        private bool emptyFields()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese NOMBRE(S) del cliente");
                return true;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese APELLIDO(S) del cliente");
                return true;
            }
            if (cmbTipoIdentificacion.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione TIPO IDENTIFICACION");
                return true;
            }
            if (txtIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese IDENTIFICACION del cliente");
                return true;
            }
            if (txtCelular.Text.Trim() == "" & txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese CELULAR O TELEFONO del cliente");
                return true;
            }
            return false;
        }

        #endregion

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lblIdCliente.Text = ".....";
            DataTable dt = new TipoIdentificacionLogic().GetBasicInfo();

            cmbTipoIdentificacion.DataSource = dt;
            cmbTipoIdentificacion.ValueMember = dt.Columns["Id"].ToString();
            cmbTipoIdentificacion.DisplayMember = dt.Columns["Nombre"].ToString();
            cmbTipoIdentificacion.SelectedIndex = 0;

            dtgClientes.DataSource = new ClienteLogic().GetAll();
            ClearForm();
            btnGuardar.Enabled = true;
            btnActualiza.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes_Load(sender, e);
        }

        private void dtgClientes_MouseHover(object sender, EventArgs e)
        {
            ToolTip clienteToolTip = new ToolTip();
            clienteToolTip.SetToolTip(dtgClientes, "Doble Click Sobre Un Elemento Para ACTUALIZAR");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (emptyFields()) return;
            clsCliente newCustomer = new clsCliente();

            newCustomer.Id = Convert.ToInt32(lblIdCliente.Text);
            newCustomer.Activo = chkActivo.Checked;
            newCustomer.Nombres = txtNombre.Text.Trim();
            newCustomer.Apellidos = txtApellido.Text.Trim();
            newCustomer.TipoIdentificacion = Convert.ToInt32(cmbTipoIdentificacion.SelectedValue);
            newCustomer.Nacionalidad = cmbNacionalidad.SelectedText;
            newCustomer.Identificacion = txtIdentificacion.Text.Trim();
            newCustomer.Celular = txtCelular.Text.Trim();
            newCustomer.Telefono = txtTelefono.Text.Trim();
            newCustomer.Correo = txtCorreo.Text.Trim();
            newCustomer.Direccion = txtDireccion.Text.Trim();

            string result = new ClienteLogic().Insert(newCustomer);
            MessageBox.Show(result);
            frmClientes_Load(sender, e);
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            if (emptyFields()) return;
            clsCliente updateCustomer = new clsCliente();

            updateCustomer.Id = Convert.ToInt32(lblIdCliente.Text);
            updateCustomer.Activo = chkActivo.Checked;
            updateCustomer.Nombres = txtNombre.Text.Trim();
            updateCustomer.Apellidos = txtApellido.Text.Trim();
            updateCustomer.TipoIdentificacion = Convert.ToInt32(cmbTipoIdentificacion.SelectedValue);
            updateCustomer.Nacionalidad = cmbNacionalidad.SelectedText;
            updateCustomer.Identificacion = txtIdentificacion.Text.Trim();
            updateCustomer.Celular = txtCelular.Text.Trim();
            updateCustomer.Telefono = txtTelefono.Text.Trim();
            updateCustomer.Correo = txtCorreo.Text.Trim();
            updateCustomer.Direccion = txtDireccion.Text.Trim();

            string result = new ClienteLogic().Update(updateCustomer);
            MessageBox.Show(result);
            frmClientes_Load(sender, e);
        }

        private void dtgClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int customerId = Convert.ToInt32(dtgClientes.SelectedRows[0].Cells[0].Value);
            clsCliente updateCustomer = new ClienteLogic().GetById("", customerId);

            lblIdCliente.Text = updateCustomer.Id.ToString();
            chkActivo.Checked = updateCustomer.Activo;
            txtNombre.Text = updateCustomer.Nombres;
            txtApellido.Text = updateCustomer.Apellidos;
            txtFecha.Text = updateCustomer.FechaCreacion.ToString();
            cmbTipoIdentificacion.SelectedValue = updateCustomer.TipoIdentificacion;
            cmbNacionalidad.SelectedText = updateCustomer.Nacionalidad;
            txtIdentificacion.Text = updateCustomer.Identificacion;
            txtCelular.Text = updateCustomer.Celular;
            txtTelefono.Text = updateCustomer.Telefono;
            txtCorreo.Text = updateCustomer.Correo;
            txtDireccion.Text = updateCustomer.Direccion;
            btnGuardar.Enabled = false;
            btnActualiza.Enabled = true;

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string customerId = txtIdentificacion.Text.Trim();
            List<clsCliente> foundCustomers = new List<clsCliente>();
            foundCustomers.Add(new ClienteLogic().GetById(customerId));
            dtgClientes.DataSource = foundCustomers;
        }
    }
}

