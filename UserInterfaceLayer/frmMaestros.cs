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

        private void fillCombo(ref ComboBox cb, System.Data.DataTable dt)
        //Metodo generico para llenar los ComboBox
        {
            cb.DataSource = dt;
            cb.ValueMember = dt.Columns[0].ToString();
            cb.DisplayMember = dt.Columns[1].ToString();
        }
        #endregion

        #region Codigo_Para: Tab_categorias_Producto
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
        //Metodo para mostrar todos los usuarios registrados al entrar al tab USUARIOS
        {
            ClearTabFields(tabUsuarios);
            btnActualizaUsuario.Visible = false;
            btnGuardaUsuario.Visible = true;
            txtNombresUsuario.Enabled = true;
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
            fillCombo(ref cmbUserRol, new RolLogic().GetBasicInfo());
            txtNombresUsuario.Focus();
        }

        private void btnGuardaUsuario_Click(object sender, EventArgs e)
        {
            if (emptyUserFields()) return;

            string Names = txtNombresUsuario.Text.Trim();
            string lastNames = txtApellidosUsuario.Text.Trim();
            string userName = txtUsuario.Text.Trim();
            string password = txtPassword.Text;
            bool active = chkUsuario.Checked;
            int rolId = Convert.ToInt32(cmbUserRol.SelectedValue);
            clsUsuario newUser = new clsUsuario() { Nombres = Names, Apellidos = lastNames, UserName = userName, Password = password, Activo = active,Idrol=rolId };

            string result = new UsuarioLogic().Insert(newUser);
            MessageBox.Show(result);
            tabUsuarios_Enter(sender, e);
        }

        private void btnActualizaUsuario_Click(object sender, EventArgs e)
        {
            string Names = txtNombresUsuario.Text.Trim();
            string lastNames = txtApellidosUsuario.Text.Trim();
            string userName = txtUsuario.Text.Trim();
            string password = txtPassword.Text;
            bool active = chkUsuario.Checked;
            int rolId = Convert.ToInt32(cmbUserRol.SelectedValue);
            clsUsuario userToModify = new clsUsuario() { Id = Convert.ToInt32(dtgUsuario.SelectedRows[0].Cells["IdUsuario"].Value),
                                                         Nombres = Names, Apellidos = lastNames, UserName = userName, Password = password,
                                                         Activo = active, Idrol = rolId };

            string result = new UsuarioLogic().Update(userToModify);
            MessageBox.Show(result);
            tabUsuarios_Enter(sender, e);
        }

        private void btnLimpiaUsuario_Click(object sender, EventArgs e)
        {
            tabUsuarios_Enter(sender, e);
            txtNombresUsuario.Focus();
        }

        private void dtgUsuario_MouseHover(object sender, EventArgs e)
        //muestra instruccion en texto flotante
        {
            ToolTip usuarioToolTip = new ToolTip();
            usuarioToolTip.SetToolTip(dtgUsuario, "Haga doble click sobre un elemento para ACTUALIZAR");
        }

        private void dtgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //Consultar usuario por el ID y luego llenar los campos del FORM
        {
            int userId = Convert.ToInt32(dtgUsuario.SelectedRows[0].Cells["IdUsuario"].Value);
            clsUsuario userToUpdate = new UsuarioLogic().GetById(userId);
            txtNombresUsuario.Text = userToUpdate.Nombres;
            txtApellidosUsuario.Text = userToUpdate.Apellidos;
            txtUsuario.Text = userToUpdate.UserName;
            txtUsuario.Enabled = false;
            chkUsuario.Checked = userToUpdate.Activo;
            cmbUserRol.SelectedValue = userToUpdate.Idrol;
            btnGuardaUsuario.Visible = false;
            btnActualizaUsuario.Visible = true;
            btnActualizaUsuario.Location = btnGuardaUsuario.Location;
        }
       
        private bool emptyUserFields()
        {
            if (txtNombresUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese NOMBRE(s)");
                return true;
            }
            if (txtApellidosUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese APELLIDO(s)");
                return true;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese USERNAME");
                return true;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese CONTRASEÑA");
                return true;
            }
            if (Convert.ToInt32(cmbUserRol.SelectedValue)==0)
            {
                MessageBox.Show("Elija un ROL de usuario");
                return true;
            }
            return false;
        }
        #endregion

        #region Codigo_Para: Tab_Roles_y_Permisos
        
        private void dtgRoles_MouseHover(object sender, EventArgs e)
        {
            ToolTip usuarioToolTip = new ToolTip();
            usuarioToolTip.SetToolTip(dtgRoles, "Haga doble click sobre un elemento para MODIFICAR");
        }

        private void tabRoles_Enter(object sender, EventArgs e)
        {
            ClearTabFields(tabRoles);
            btnActualizaRol.Visible = false;
            btnGuardaRol.Visible = true;
            dtgRoles.Rows.Clear();

            List<clsRol> roles = new RolLogic().GetAll();
            foreach (clsRol rol in roles)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgRoles);
                row.SetValues(rol.Id, rol.Nombre, rol.limiteEmpleados, rol.limiteEnDemanda, rol.Activo, "Permisos");
                dtgRoles.Rows.Add(row);
            }

            dtgRoles.ClearSelection();
            txtNombreRol.Focus();
        }

        private void dtgRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreRol.Text = Convert.ToString(dtgRoles.SelectedRows[0].Cells["nombreRol"].Value);
            chkRol.Checked = Convert.ToBoolean(dtgRoles.SelectedRows[0].Cells["activoRol"].Value);
            btnGuardaRol.Visible = false;
            btnActualizaRol.Visible = true;
            btnActualizaRol.Location = btnGuardaRol.Location;
        }

        private void btnLimpiaRol_Click(object sender, EventArgs e)
        {
            tabRoles_Enter(sender, e);
        }
       
        private void btnGuardaRol_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Nombre ROL");
                txtNombreRol.Focus();
                return;
            }
            string nombreRol = txtNombreRol.Text.Trim();
            bool activoRol = chkRol.Checked;
            clsRol newRol = new clsRol() { Nombre = nombreRol, Activo = activoRol, limiteEmpleados = 1, limiteEnDemanda = 2 };

            string result = new RolLogic().Insert(newRol);
            MessageBox.Show(result);
            tabRoles_Enter(sender, e);
        }
       
        private void btnActualizaRol_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Nombre ROL");
                txtNombreRol.Focus();
                return;
            }

            clsRol rolToModify = new clsRol();
            string name = txtNombreRol.Text.Trim();
            bool activo = chkRol.Checked;
            rolToModify.Id = Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["IdRol"].Value);
            rolToModify.limiteEmpleados= Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["limiteEmpleadosRol"].Value);
            rolToModify.limiteEnDemanda= Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["limiteDemandaRol"].Value);
            rolToModify.Nombre = name;
            rolToModify.Activo = activo;

            string result = new RolLogic().Update(rolToModify);
            MessageBox.Show(result);
            tabRoles_Enter(sender, e);
        }

        private void FillDtgPermisos(List<clsPermiso>permisos)
        {
            foreach (clsPermiso permiso in permisos)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgPermisos);
                newRow.SetValues(permiso.Id, permiso.Formulario, permiso.Activo);
                dtgPermisos.Rows.Add(newRow);
            }
        }

        #endregion

        private void dtgRoles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgRoles.Columns[e.ColumnIndex].Name == "permisosRol")
            {
                dtgPermisos.Rows.Clear();
                int rolId = Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["IdRol"]);
                List<clsPermiso> permisos = new PermisoLogic().GetByRol(rolId);

                if (permisos != null)
                {
                    FillDtgPermisos(permisos);
                }
                else
                {
                    //List<clsPermiso> allPermisos = new PermisoLogic().GetAll();
                    FillDtgPermisos(new PermisoLogic().GetAll());
                }
            }

        }

        private void dtgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgRoles.Columns[e.ColumnIndex].Name == "permisosRol")
            {
                dtgPermisos.Rows.Clear();
                int rolId = Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["IdRol"]);
                List<clsPermiso> permisos = new PermisoLogic().GetByRol(rolId);

                if (permisos != null)
                {
                    FillDtgPermisos(permisos);
                }
                else
                {
                    //List<clsPermiso> allPermisos = new PermisoLogic().GetAll();
                    FillDtgPermisos(new PermisoLogic().GetAll());
                }
            }
        }
    }
}