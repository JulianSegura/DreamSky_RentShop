using BusinessLayer;
using DreamSkyEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class frmMaestros : Form
    {
        #region Shared_MainForm
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
        #endregion

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
            txtCategoriaProducto.Focus();
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

         private void dtgCategoriaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        #region Codigo_Para: Tab_Tipo_Identificacion
        private void tabIdentificacion_Enter(object sender, EventArgs e)
        //Metodo de entrada al tab. Muestra todas las categorias existentes.
        {
            ClearTabFields(tabIdentificacion);
            btnActualizarIdentificacion.Visible = false;
            btnGuardarIndentificacion.Visible = true;
            dtgTipoIdentificacion.Rows.Clear();
            List<clsTipoIdentificacion> idTypesList = new TipoIdentificacionLogic().GetAll();

            foreach (clsTipoIdentificacion tipoIdentificacion in idTypesList)
            {
                DataGridViewRow dtgRow = new DataGridViewRow();
                dtgRow.CreateCells(dtgTipoIdentificacion);
                dtgRow.SetValues(tipoIdentificacion.Id, tipoIdentificacion.Nombre, tipoIdentificacion.Activo);
                dtgTipoIdentificacion.Rows.Add(dtgRow);
            }
            dtgTipoIdentificacion.ClearSelection();
            txtTipoIdentificacion.Focus();
        }

        private void btnGuardarIndentifiacion_Click(object sender, EventArgs e)
        {
            if (txtTipoIdentificacion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Agregar NOMBRE para Tipo de Identificacion");
                return;
            }
            string idName = txtTipoIdentificacion.Text.Trim();
            bool Activo = chkTipoIdentificacion.Checked;
            clsTipoIdentificacion newIdType = new clsTipoIdentificacion();
            newIdType.Nombre = idName;
            newIdType.Activo = Activo;
            string result = new TipoIdentificacionLogic().Insert(newIdType);
            MessageBox.Show(result);
            tabIdentificacion_Enter(sender, e);
            txtTipoIdentificacion.Focus();
        }

        private void btnActualizarIdentificacion_Click(object sender, EventArgs e)
        {
            clsTipoIdentificacion idTypeToModify = new clsTipoIdentificacion();
            idTypeToModify.Id = Convert.ToInt32(dtgTipoIdentificacion.SelectedRows[0].Cells["IdIdentificacion"].Value);
            idTypeToModify.Nombre = txtTipoIdentificacion.Text.Trim();
            idTypeToModify.Activo = chkTipoIdentificacion.Checked;

            string result = new TipoIdentificacionLogic().Update(idTypeToModify);
            MessageBox.Show(result);
            tabIdentificacion_Enter(sender, e);
            txtTipoIdentificacion.Focus();
        }

        private void btnLimpiarIdentificacion_Click(object sender, EventArgs e)
        {
            tabIdentificacion_Enter(sender, e);
        }

        private void dtgTipoIdentifiacion_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipoIdToolTip = new ToolTip();
            tipoIdToolTip.SetToolTip(dtgTipoIdentificacion, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void dtgTipoIdentifiacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipoIdentificacion.Text = Convert.ToString(dtgTipoIdentificacion.SelectedRows[0].Cells["NombreIdentificacion"].Value);
            chkTipoIdentificacion.Checked = Convert.ToBoolean(dtgTipoIdentificacion.SelectedRows[0].Cells["ActivoIdentificacion"].Value);
            btnGuardarIndentificacion.Visible = false;
            btnActualizarIdentificacion.Visible = true;
            btnActualizarIdentificacion.Location = btnGuardarIndentificacion.Location;
        }
        #endregion

        #region Codigo_Para: Tab_Tipos_NCF
        private void tabNCF_Enter(object sender, EventArgs e)
        {
            ClearTabFields(tabNCF);
            btnActualizaNCF.Visible = false;
            btnGuardaNCF.Visible = true;
            dtgNCF.Rows.Clear();
            List<clsTipoNCF> NCFList = new TipoNCFLogic().GetAll();

            foreach (clsTipoNCF tipoNCF in NCFList)
            {
                DataGridViewRow dtgRow = new DataGridViewRow();
                dtgRow.CreateCells(dtgNCF);
                dtgRow.SetValues(tipoNCF.Id, tipoNCF.Nombre, tipoNCF.Activo);
                dtgNCF.Rows.Add(dtgRow);
            }
            dtgNCF.ClearSelection();
            txtNCF.Focus();
        }
        private void btnGuardaNCF_Click(object sender, EventArgs e)
        {
            if (txtNCF.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Agregar NOMBRE Para Tipo Comprobante Fiscal");
                return;
            }
            string ncfName = txtNCF.Text.Trim();
            bool Activo = chkNCF.Checked;
            clsTipoNCF newNCFType = new clsTipoNCF();
            newNCFType.Nombre = ncfName;
            newNCFType.Activo = Activo;
            string result = new TipoNCFLogic().Insert(newNCFType);
            MessageBox.Show(result);
            tabNCF_Enter(sender, e);
            txtNCF.Focus();
        }

        private void btnActualizaNCF_Click(object sender, EventArgs e)
        {
            clsTipoNCF ncfToModify = new clsTipoNCF();
            ncfToModify.Id = Convert.ToInt32(dtgNCF.SelectedRows[0].Cells["IdNCF"].Value);
            ncfToModify.Nombre = txtNCF.Text.Trim();
            ncfToModify.Activo = chkNCF.Checked;

            string result = new TipoNCFLogic().Update(ncfToModify);
            MessageBox.Show(result);
            tabNCF_Enter(sender, e);
            txtNCF.Focus();
        }

        private void btnLimpiarNCF_Click(object sender, EventArgs e)
        {
            tabNCF_Enter(sender, e);
        }

        private void dtgNCF_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipoNCFToolTip = new ToolTip();
            tipoNCFToolTip.SetToolTip(dtgNCF, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void dtgNCF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNCF.Text = Convert.ToString(dtgNCF.SelectedRows[0].Cells["NombreNCF"].Value);
            chkNCF.Checked = Convert.ToBoolean(dtgNCF.SelectedRows[0].Cells["ActivoNCF"].Value);
            btnGuardaNCF.Visible = false;
            btnActualizaNCF.Visible = true;
            btnActualizaNCF.Location = btnGuardaNCF.Location;
        }
        #endregion

        #region Codigo_Para: Tab_Usuarios
        private void tabUsuarios_Enter(object sender, EventArgs e)
        {
            ClearTabFields(tabUsuarios);
            btnActualizaUsuario.Visible = false;
            btnGuardaUsuario.Visible = true;
            dtgUsuario.Rows.Clear();
            List<clsUsuario> usuariosList = new UsuarioLogic().GetAll();

            foreach (clsUsuario usuario in usuariosList)
            {
                DataGridViewRow dtgRow = new DataGridViewRow();
                dtgRow.CreateCells(dtgUsuario);
                dtgRow.SetValues(usuario.Id, usuario.NombreCompleto, usuario.Rol.Nombre,usuario.fechaCreacion.ToString(),usuario.Activo);
                dtgUsuario.Rows.Add(dtgRow);
            }
            dtgUsuario.ClearSelection();
            txtNombresUsuario.Focus();
        }
        private void btnGuardaUsuario_Click(object sender, EventArgs e)
        {
            if (txtNCF.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Agregar NOMBRE Para Tipo Comprobante Fiscal");
                return;
            }
            string ncfName = txtNCF.Text.Trim();
            bool Activo = chkNCF.Checked;
            clsTipoNCF newNCFType = new clsTipoNCF();
            newNCFType.Nombre = ncfName;
            newNCFType.Activo = Activo;
            string result = new TipoNCFLogic().Insert(newNCFType);
            MessageBox.Show(result);
            tabNCF_Enter(sender, e);
            txtNCF.Focus();
        }

        private void btnActualizaUsuario_Click(object sender, EventArgs e)
        {
            clsTipoNCF ncfToModify = new clsTipoNCF();
            ncfToModify.Id = Convert.ToInt32(dtgNCF.SelectedRows[0].Cells["IdNCF"].Value);
            ncfToModify.Nombre = txtNCF.Text.Trim();
            ncfToModify.Activo = chkNCF.Checked;

            string result = new TipoNCFLogic().Update(ncfToModify);
            MessageBox.Show(result);
            tabNCF_Enter(sender, e);
            txtNCF.Focus();
        }

        private void btnLimpiaUsuario_Click(object sender, EventArgs e)
        {
            tabUsuarios_Enter(sender, e);
        }

        private void dtgUsuario_MouseHover(object sender, EventArgs e)
        {
            ToolTip usuarioToolTip = new ToolTip();
            usuarioToolTip.SetToolTip(dtgUsuario, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNCF.Text = Convert.ToString(dtgNCF.SelectedRows[0].Cells["NombreNCF"].Value);
            chkNCF.Checked = Convert.ToBoolean(dtgNCF.SelectedRows[0].Cells["ActivoNCF"].Value);
            btnGuardaNCF.Visible = false;
            btnActualizaNCF.Visible = true;
            btnActualizaNCF.Location = btnGuardaNCF.Location;
        }
        #endregion

    }
}