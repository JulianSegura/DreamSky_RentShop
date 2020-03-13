namespace UserInterfaceLayer
{
    partial class frmMaestros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControlMaestros = new System.Windows.Forms.TabControl();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.btnLimpiarCProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCategoriaProducto = new System.Windows.Forms.CheckBox();
            this.btnActualizaCproducto = new System.Windows.Forms.Button();
            this.btnGuardaCproducto = new System.Windows.Forms.Button();
            this.txtCategoriaProducto = new System.Windows.Forms.TextBox();
            this.dtgCategoriaProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabIdentificacion = new System.Windows.Forms.TabPage();
            this.btnLimpiarIdentificacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTipoIdentificacion = new System.Windows.Forms.CheckBox();
            this.btnActualizarIdentificacion = new System.Windows.Forms.Button();
            this.btnGuardarIndentificacion = new System.Windows.Forms.Button();
            this.txtTipoIdentificacion = new System.Windows.Forms.TextBox();
            this.dtgTipoIdentificacion = new System.Windows.Forms.DataGridView();
            this.IdIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoIdentificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabNCF = new System.Windows.Forms.TabPage();
            this.btnLimpiarNCF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkNCF = new System.Windows.Forms.CheckBox();
            this.btnActualizaNCF = new System.Windows.Forms.Button();
            this.btnGuardaNCF = new System.Windows.Forms.Button();
            this.txtNCF = new System.Windows.Forms.TextBox();
            this.dtgNCF = new System.Windows.Forms.DataGridView();
            this.IdNCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoNCF = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.btnGuardaPermisos = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.idPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formularioPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.asignarPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.btnLimpiaRol = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkRol = new System.Windows.Forms.CheckBox();
            this.btnActualizaRol = new System.Windows.Forms.Button();
            this.btnGuardaRol = new System.Windows.Forms.Button();
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteEmpleadosRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteDemandaRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoRol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permisosRol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.btnLimpiaUsuario = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUserRol = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApellidosUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.btnActualizaUsuario = new System.Windows.Forms.Button();
            this.btnGuardaUsuario = new System.Windows.Forms.Button();
            this.txtNombresUsuario = new System.Windows.Forms.TextBox();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacionUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlMaestros.SuspendLayout();
            this.tabCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProducto)).BeginInit();
            this.tabIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoIdentificacion)).BeginInit();
            this.tabNCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNCF)).BeginInit();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(623, 522);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(163, 34);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControlMaestros
            // 
            this.tabControlMaestros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMaestros.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMaestros.Controls.Add(this.tabCategoria);
            this.tabControlMaestros.Controls.Add(this.tabIdentificacion);
            this.tabControlMaestros.Controls.Add(this.tabNCF);
            this.tabControlMaestros.Controls.Add(this.tabRoles);
            this.tabControlMaestros.Controls.Add(this.tabUsuarios);
            this.tabControlMaestros.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMaestros.Location = new System.Drawing.Point(9, 14);
            this.tabControlMaestros.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMaestros.Name = "tabControlMaestros";
            this.tabControlMaestros.SelectedIndex = 0;
            this.tabControlMaestros.Size = new System.Drawing.Size(776, 503);
            this.tabControlMaestros.TabIndex = 1;
            // 
            // tabCategoria
            // 
            this.tabCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabCategoria.BackColor = System.Drawing.Color.PaleGreen;
            this.tabCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabCategoria.Controls.Add(this.btnLimpiarCProducto);
            this.tabCategoria.Controls.Add(this.label1);
            this.tabCategoria.Controls.Add(this.label2);
            this.tabCategoria.Controls.Add(this.chkCategoriaProducto);
            this.tabCategoria.Controls.Add(this.btnActualizaCproducto);
            this.tabCategoria.Controls.Add(this.btnGuardaCproducto);
            this.tabCategoria.Controls.Add(this.txtCategoriaProducto);
            this.tabCategoria.Controls.Add(this.dtgCategoriaProducto);
            this.tabCategoria.ForeColor = System.Drawing.Color.Black;
            this.tabCategoria.ImageKey = "(none)";
            this.tabCategoria.Location = new System.Drawing.Point(4, 33);
            this.tabCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCategoria.Size = new System.Drawing.Size(768, 466);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categoria Producto";
            this.tabCategoria.Enter += new System.EventHandler(this.tabCategoria_Enter);
            // 
            // btnLimpiarCProducto
            // 
            this.btnLimpiarCProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCProducto.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCProducto.Location = new System.Drawing.Point(503, 36);
            this.btnLimpiarCProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarCProducto.Name = "btnLimpiarCProducto";
            this.btnLimpiarCProducto.Size = new System.Drawing.Size(113, 34);
            this.btnLimpiarCProducto.TabIndex = 23;
            this.btnLimpiarCProducto.Text = "Nuevo";
            this.btnLimpiarCProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarCProducto.Click += new System.EventHandler(this.btnLimpiarCProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Administrar Categoria de Producto";
            // 
            // chkCategoriaProducto
            // 
            this.chkCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCategoriaProducto.AutoSize = true;
            this.chkCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.chkCategoriaProducto.Location = new System.Drawing.Point(277, 41);
            this.chkCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCategoriaProducto.Name = "chkCategoriaProducto";
            this.chkCategoriaProducto.Size = new System.Drawing.Size(83, 25);
            this.chkCategoriaProducto.TabIndex = 2;
            this.chkCategoriaProducto.Text = "Activo";
            this.chkCategoriaProducto.UseVisualStyleBackColor = true;
            // 
            // btnActualizaCproducto
            // 
            this.btnActualizaCproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaCproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaCproducto.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaCproducto.Location = new System.Drawing.Point(503, 36);
            this.btnActualizaCproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizaCproducto.Name = "btnActualizaCproducto";
            this.btnActualizaCproducto.Size = new System.Drawing.Size(125, 34);
            this.btnActualizaCproducto.TabIndex = 4;
            this.btnActualizaCproducto.Text = "Actualizar";
            this.btnActualizaCproducto.UseVisualStyleBackColor = true;
            this.btnActualizaCproducto.Visible = false;
            this.btnActualizaCproducto.Click += new System.EventHandler(this.btnActualizaCproducto_Click);
            // 
            // btnGuardaCproducto
            // 
            this.btnGuardaCproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaCproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaCproducto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardaCproducto.Location = new System.Drawing.Point(371, 36);
            this.btnGuardaCproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardaCproducto.Name = "btnGuardaCproducto";
            this.btnGuardaCproducto.Size = new System.Drawing.Size(113, 34);
            this.btnGuardaCproducto.TabIndex = 3;
            this.btnGuardaCproducto.Text = "Guardar";
            this.btnGuardaCproducto.UseVisualStyleBackColor = true;
            this.btnGuardaCproducto.Click += new System.EventHandler(this.btnGuardaCproducto_Click);
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoriaProducto.Location = new System.Drawing.Point(101, 39);
            this.txtCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(153, 27);
            this.txtCategoriaProducto.TabIndex = 1;
            // 
            // dtgCategoriaProducto
            // 
            this.dtgCategoriaProducto.AllowUserToAddRows = false;
            this.dtgCategoriaProducto.AllowUserToDeleteRows = false;
            this.dtgCategoriaProducto.AllowUserToResizeColumns = false;
            this.dtgCategoriaProducto.AllowUserToResizeRows = false;
            this.dtgCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCategoriaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategoriaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoriaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Activo});
            this.dtgCategoriaProducto.Location = new System.Drawing.Point(5, 78);
            this.dtgCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCategoriaProducto.MultiSelect = false;
            this.dtgCategoriaProducto.Name = "dtgCategoriaProducto";
            this.dtgCategoriaProducto.ReadOnly = true;
            this.dtgCategoriaProducto.RowHeadersVisible = false;
            this.dtgCategoriaProducto.RowHeadersWidth = 51;
            this.dtgCategoriaProducto.RowTemplate.Height = 24;
            this.dtgCategoriaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategoriaProducto.ShowCellToolTips = false;
            this.dtgCategoriaProducto.Size = new System.Drawing.Size(759, 385);
            this.dtgCategoriaProducto.TabIndex = 5;
            this.dtgCategoriaProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategoriaProducto_CellDoubleClick);
            this.dtgCategoriaProducto.MouseEnter += new System.EventHandler(this.dtgCategoriaProducto_MouseEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 149.2386F;
            this.Nombre.HeaderText = "Categoria Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.FillWeight = 50.76142F;
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // tabIdentificacion
            // 
            this.tabIdentificacion.BackColor = System.Drawing.Color.PaleGreen;
            this.tabIdentificacion.Controls.Add(this.btnLimpiarIdentificacion);
            this.tabIdentificacion.Controls.Add(this.label3);
            this.tabIdentificacion.Controls.Add(this.label4);
            this.tabIdentificacion.Controls.Add(this.chkTipoIdentificacion);
            this.tabIdentificacion.Controls.Add(this.btnActualizarIdentificacion);
            this.tabIdentificacion.Controls.Add(this.btnGuardarIndentificacion);
            this.tabIdentificacion.Controls.Add(this.txtTipoIdentificacion);
            this.tabIdentificacion.Controls.Add(this.dtgTipoIdentificacion);
            this.tabIdentificacion.ForeColor = System.Drawing.Color.Transparent;
            this.tabIdentificacion.Location = new System.Drawing.Point(4, 33);
            this.tabIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIdentificacion.Name = "tabIdentificacion";
            this.tabIdentificacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIdentificacion.Size = new System.Drawing.Size(768, 466);
            this.tabIdentificacion.TabIndex = 2;
            this.tabIdentificacion.Text = "Tipos de Identificación";
            this.tabIdentificacion.Enter += new System.EventHandler(this.tabIdentificacion_Enter);
            // 
            // btnLimpiarIdentificacion
            // 
            this.btnLimpiarIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarIdentificacion.Location = new System.Drawing.Point(503, 36);
            this.btnLimpiarIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarIdentificacion.Name = "btnLimpiarIdentificacion";
            this.btnLimpiarIdentificacion.Size = new System.Drawing.Size(113, 34);
            this.btnLimpiarIdentificacion.TabIndex = 24;
            this.btnLimpiarIdentificacion.Text = "Nuevo";
            this.btnLimpiarIdentificacion.UseVisualStyleBackColor = true;
            this.btnLimpiarIdentificacion.Click += new System.EventHandler(this.btnLimpiarIdentificacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrar tipos de identificacion:";
            // 
            // chkTipoIdentificacion
            // 
            this.chkTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTipoIdentificacion.AutoSize = true;
            this.chkTipoIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.chkTipoIdentificacion.Location = new System.Drawing.Point(277, 41);
            this.chkTipoIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTipoIdentificacion.Name = "chkTipoIdentificacion";
            this.chkTipoIdentificacion.Size = new System.Drawing.Size(83, 25);
            this.chkTipoIdentificacion.TabIndex = 8;
            this.chkTipoIdentificacion.Text = "Activo";
            this.chkTipoIdentificacion.UseVisualStyleBackColor = true;
            // 
            // btnActualizarIdentificacion
            // 
            this.btnActualizarIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarIdentificacion.Location = new System.Drawing.Point(503, 36);
            this.btnActualizarIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarIdentificacion.Name = "btnActualizarIdentificacion";
            this.btnActualizarIdentificacion.Size = new System.Drawing.Size(125, 34);
            this.btnActualizarIdentificacion.TabIndex = 10;
            this.btnActualizarIdentificacion.Text = "Actualizar";
            this.btnActualizarIdentificacion.UseVisualStyleBackColor = true;
            this.btnActualizarIdentificacion.Click += new System.EventHandler(this.btnActualizarIdentificacion_Click);
            // 
            // btnGuardarIndentificacion
            // 
            this.btnGuardarIndentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarIndentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIndentificacion.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarIndentificacion.Location = new System.Drawing.Point(371, 36);
            this.btnGuardarIndentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarIndentificacion.Name = "btnGuardarIndentificacion";
            this.btnGuardarIndentificacion.Size = new System.Drawing.Size(113, 34);
            this.btnGuardarIndentificacion.TabIndex = 9;
            this.btnGuardarIndentificacion.Text = "Guardar";
            this.btnGuardarIndentificacion.UseVisualStyleBackColor = true;
            this.btnGuardarIndentificacion.Click += new System.EventHandler(this.btnGuardarIndentifiacion_Click);
            // 
            // txtTipoIdentificacion
            // 
            this.txtTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoIdentificacion.Location = new System.Drawing.Point(101, 39);
            this.txtTipoIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoIdentificacion.Name = "txtTipoIdentificacion";
            this.txtTipoIdentificacion.Size = new System.Drawing.Size(153, 27);
            this.txtTipoIdentificacion.TabIndex = 7;
            // 
            // dtgTipoIdentificacion
            // 
            this.dtgTipoIdentificacion.AllowUserToAddRows = false;
            this.dtgTipoIdentificacion.AllowUserToDeleteRows = false;
            this.dtgTipoIdentificacion.AllowUserToResizeColumns = false;
            this.dtgTipoIdentificacion.AllowUserToResizeRows = false;
            this.dtgTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTipoIdentificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTipoIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIdentificacion,
            this.NombreIdentificacion,
            this.ActivoIdentificacion});
            this.dtgTipoIdentificacion.Location = new System.Drawing.Point(4, 63);
            this.dtgTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTipoIdentificacion.Name = "dtgTipoIdentificacion";
            this.dtgTipoIdentificacion.ReadOnly = true;
            this.dtgTipoIdentificacion.RowHeadersVisible = false;
            this.dtgTipoIdentificacion.RowHeadersWidth = 51;
            this.dtgTipoIdentificacion.RowTemplate.Height = 24;
            this.dtgTipoIdentificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoIdentificacion.ShowCellToolTips = false;
            this.dtgTipoIdentificacion.Size = new System.Drawing.Size(759, 385);
            this.dtgTipoIdentificacion.TabIndex = 11;
            this.dtgTipoIdentificacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipoIdentifiacion_CellDoubleClick);
            this.dtgTipoIdentificacion.MouseHover += new System.EventHandler(this.dtgTipoIdentifiacion_MouseHover);
            // 
            // IdIdentificacion
            // 
            this.IdIdentificacion.HeaderText = "Id";
            this.IdIdentificacion.MinimumWidth = 6;
            this.IdIdentificacion.Name = "IdIdentificacion";
            this.IdIdentificacion.ReadOnly = true;
            this.IdIdentificacion.Visible = false;
            // 
            // NombreIdentificacion
            // 
            this.NombreIdentificacion.FillWeight = 149.2386F;
            this.NombreIdentificacion.HeaderText = "Tipo Identificacion";
            this.NombreIdentificacion.MinimumWidth = 6;
            this.NombreIdentificacion.Name = "NombreIdentificacion";
            this.NombreIdentificacion.ReadOnly = true;
            // 
            // ActivoIdentificacion
            // 
            this.ActivoIdentificacion.FillWeight = 50.76142F;
            this.ActivoIdentificacion.HeaderText = "Activo";
            this.ActivoIdentificacion.MinimumWidth = 6;
            this.ActivoIdentificacion.Name = "ActivoIdentificacion";
            this.ActivoIdentificacion.ReadOnly = true;
            this.ActivoIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivoIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabNCF
            // 
            this.tabNCF.BackColor = System.Drawing.Color.PaleGreen;
            this.tabNCF.Controls.Add(this.btnLimpiarNCF);
            this.tabNCF.Controls.Add(this.label5);
            this.tabNCF.Controls.Add(this.label6);
            this.tabNCF.Controls.Add(this.chkNCF);
            this.tabNCF.Controls.Add(this.btnActualizaNCF);
            this.tabNCF.Controls.Add(this.btnGuardaNCF);
            this.tabNCF.Controls.Add(this.txtNCF);
            this.tabNCF.Controls.Add(this.dtgNCF);
            this.tabNCF.Location = new System.Drawing.Point(4, 33);
            this.tabNCF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNCF.Name = "tabNCF";
            this.tabNCF.Size = new System.Drawing.Size(768, 466);
            this.tabNCF.TabIndex = 3;
            this.tabNCF.Text = "Tipo NCF";
            this.tabNCF.Enter += new System.EventHandler(this.tabNCF_Enter);
            // 
            // btnLimpiarNCF
            // 
            this.btnLimpiarNCF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarNCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarNCF.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarNCF.Location = new System.Drawing.Point(503, 36);
            this.btnLimpiarNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarNCF.Name = "btnLimpiarNCF";
            this.btnLimpiarNCF.Size = new System.Drawing.Size(113, 34);
            this.btnLimpiarNCF.TabIndex = 25;
            this.btnLimpiarNCF.Text = "Nuevo";
            this.btnLimpiarNCF.UseVisualStyleBackColor = true;
            this.btnLimpiarNCF.Click += new System.EventHandler(this.btnLimpiarNCF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Administrar tipo de NFC:";
            // 
            // chkNCF
            // 
            this.chkNCF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNCF.AutoSize = true;
            this.chkNCF.Location = new System.Drawing.Point(277, 41);
            this.chkNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNCF.Name = "chkNCF";
            this.chkNCF.Size = new System.Drawing.Size(83, 25);
            this.chkNCF.TabIndex = 13;
            this.chkNCF.Text = "Activo";
            this.chkNCF.UseVisualStyleBackColor = true;
            // 
            // btnActualizaNCF
            // 
            this.btnActualizaNCF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaNCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaNCF.Location = new System.Drawing.Point(503, 36);
            this.btnActualizaNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizaNCF.Name = "btnActualizaNCF";
            this.btnActualizaNCF.Size = new System.Drawing.Size(125, 34);
            this.btnActualizaNCF.TabIndex = 15;
            this.btnActualizaNCF.Text = "Actualizar";
            this.btnActualizaNCF.UseVisualStyleBackColor = true;
            this.btnActualizaNCF.Click += new System.EventHandler(this.btnActualizaNCF_Click);
            // 
            // btnGuardaNCF
            // 
            this.btnGuardaNCF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaNCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaNCF.Location = new System.Drawing.Point(371, 36);
            this.btnGuardaNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardaNCF.Name = "btnGuardaNCF";
            this.btnGuardaNCF.Size = new System.Drawing.Size(113, 34);
            this.btnGuardaNCF.TabIndex = 14;
            this.btnGuardaNCF.Text = "Guardar";
            this.btnGuardaNCF.UseVisualStyleBackColor = true;
            this.btnGuardaNCF.Click += new System.EventHandler(this.btnGuardaNCF_Click);
            // 
            // txtNCF
            // 
            this.txtNCF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNCF.Location = new System.Drawing.Point(101, 39);
            this.txtNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNCF.Name = "txtNCF";
            this.txtNCF.Size = new System.Drawing.Size(153, 27);
            this.txtNCF.TabIndex = 12;
            // 
            // dtgNCF
            // 
            this.dtgNCF.AllowUserToAddRows = false;
            this.dtgNCF.AllowUserToDeleteRows = false;
            this.dtgNCF.AllowUserToResizeColumns = false;
            this.dtgNCF.AllowUserToResizeRows = false;
            this.dtgNCF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNCF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNCF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNCF,
            this.NombreNCF,
            this.ActivoNCF});
            this.dtgNCF.Location = new System.Drawing.Point(5, 78);
            this.dtgNCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgNCF.MultiSelect = false;
            this.dtgNCF.Name = "dtgNCF";
            this.dtgNCF.ReadOnly = true;
            this.dtgNCF.RowHeadersVisible = false;
            this.dtgNCF.RowHeadersWidth = 51;
            this.dtgNCF.RowTemplate.Height = 24;
            this.dtgNCF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNCF.ShowCellToolTips = false;
            this.dtgNCF.ShowEditingIcon = false;
            this.dtgNCF.Size = new System.Drawing.Size(759, 385);
            this.dtgNCF.TabIndex = 16;
            this.dtgNCF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNCF_CellDoubleClick);
            this.dtgNCF.MouseHover += new System.EventHandler(this.dtgNCF_MouseHover);
            // 
            // IdNCF
            // 
            this.IdNCF.HeaderText = "Id";
            this.IdNCF.MinimumWidth = 6;
            this.IdNCF.Name = "IdNCF";
            this.IdNCF.ReadOnly = true;
            this.IdNCF.Visible = false;
            // 
            // NombreNCF
            // 
            this.NombreNCF.FillWeight = 149.2386F;
            this.NombreNCF.HeaderText = "Tipo NCF";
            this.NombreNCF.MinimumWidth = 6;
            this.NombreNCF.Name = "NombreNCF";
            this.NombreNCF.ReadOnly = true;
            // 
            // ActivoNCF
            // 
            this.ActivoNCF.FillWeight = 50.76142F;
            this.ActivoNCF.HeaderText = "Activo";
            this.ActivoNCF.MinimumWidth = 6;
            this.ActivoNCF.Name = "ActivoNCF";
            this.ActivoNCF.ReadOnly = true;
            // 
            // tabRoles
            // 
            this.tabRoles.BackColor = System.Drawing.Color.PaleGreen;
            this.tabRoles.Controls.Add(this.btnGuardaPermisos);
            this.tabRoles.Controls.Add(this.label15);
            this.tabRoles.Controls.Add(this.dtgPermisos);
            this.tabRoles.Controls.Add(this.txtNombreRol);
            this.tabRoles.Controls.Add(this.btnLimpiaRol);
            this.tabRoles.Controls.Add(this.label7);
            this.tabRoles.Controls.Add(this.label8);
            this.tabRoles.Controls.Add(this.chkRol);
            this.tabRoles.Controls.Add(this.btnActualizaRol);
            this.tabRoles.Controls.Add(this.btnGuardaRol);
            this.tabRoles.Controls.Add(this.dtgRoles);
            this.tabRoles.Location = new System.Drawing.Point(4, 33);
            this.tabRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(768, 466);
            this.tabRoles.TabIndex = 4;
            this.tabRoles.Text = "Roles y Permisos";
            this.tabRoles.Enter += new System.EventHandler(this.tabRoles_Enter);
            // 
            // btnGuardaPermisos
            // 
            this.btnGuardaPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaPermisos.Location = new System.Drawing.Point(432, 342);
            this.btnGuardaPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardaPermisos.Name = "btnGuardaPermisos";
            this.btnGuardaPermisos.Size = new System.Drawing.Size(140, 28);
            this.btnGuardaPermisos.TabIndex = 8;
            this.btnGuardaPermisos.Text = "Asignar Permisos";
            this.btnGuardaPermisos.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(1, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 27);
            this.label15.TabIndex = 34;
            this.label15.Text = "Permisos";
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.AllowUserToResizeColumns = false;
            this.dtgPermisos.AllowUserToResizeRows = false;
            this.dtgPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos.Location = new System.Drawing.Point(5, 214);
            this.dtgPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgPermisos.MultiSelect = false;
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.RowHeadersVisible = false;
            this.dtgPermisos.RowHeadersWidth = 51;
            this.dtgPermisos.RowTemplate.Height = 24;
            this.dtgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos.ShowCellToolTips = false;
            this.dtgPermisos.Size = new System.Drawing.Size(569, 158);
            this.dtgPermisos.TabIndex = 6;
            // 
            // idPermiso
            // 
            this.idPermiso.HeaderText = "Id";
            this.idPermiso.Name = "idPermiso";
            this.idPermiso.ReadOnly = true;
            this.idPermiso.Visible = false;
            // 
            // formularioPermiso
            // 
            this.formularioPermiso.HeaderText = "Formulario";
            this.formularioPermiso.Name = "formularioPermiso";
            this.formularioPermiso.ReadOnly = true;
            this.formularioPermiso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // activoPermiso
            // 
            this.activoPermiso.HeaderText = "Permiso Activo";
            this.activoPermiso.Name = "activoPermiso";
            this.activoPermiso.ReadOnly = true;
            this.activoPermiso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // asignarPermiso
            // 
            this.asignarPermiso.HeaderText = "Asignar a ROL";
            this.asignarPermiso.Name = "asignarPermiso";
            this.asignarPermiso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreRol.Location = new System.Drawing.Point(57, 39);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(197, 27);
            this.txtNombreRol.TabIndex = 0;
            // 
            // btnLimpiaRol
            // 
            this.btnLimpiaRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiaRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiaRol.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiaRol.Location = new System.Drawing.Point(496, 36);
            this.btnLimpiaRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiaRol.Name = "btnLimpiaRol";
            this.btnLimpiaRol.Size = new System.Drawing.Size(113, 32);
            this.btnLimpiaRol.TabIndex = 4;
            this.btnLimpiaRol.Text = "Nuevo";
            this.btnLimpiaRol.UseVisualStyleBackColor = true;
            this.btnLimpiaRol.Click += new System.EventHandler(this.btnLimpiaRol_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Rol:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "Administrar roles y permisos:";
            // 
            // chkRol
            // 
            this.chkRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRol.AutoSize = true;
            this.chkRol.ForeColor = System.Drawing.Color.Black;
            this.chkRol.Location = new System.Drawing.Point(277, 41);
            this.chkRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRol.Name = "chkRol";
            this.chkRol.Size = new System.Drawing.Size(83, 25);
            this.chkRol.TabIndex = 1;
            this.chkRol.Text = "Activo";
            this.chkRol.UseVisualStyleBackColor = true;
            // 
            // btnActualizaRol
            // 
            this.btnActualizaRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaRol.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaRol.Location = new System.Drawing.Point(496, 36);
            this.btnActualizaRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizaRol.Name = "btnActualizaRol";
            this.btnActualizaRol.Size = new System.Drawing.Size(125, 32);
            this.btnActualizaRol.TabIndex = 3;
            this.btnActualizaRol.Text = "Actualizar";
            this.btnActualizaRol.UseVisualStyleBackColor = true;
            this.btnActualizaRol.Click += new System.EventHandler(this.btnActualizaRol_Click);
            // 
            // btnGuardaRol
            // 
            this.btnGuardaRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaRol.ForeColor = System.Drawing.Color.Black;
            this.btnGuardaRol.Location = new System.Drawing.Point(365, 36);
            this.btnGuardaRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardaRol.Name = "btnGuardaRol";
            this.btnGuardaRol.Size = new System.Drawing.Size(113, 32);
            this.btnGuardaRol.TabIndex = 2;
            this.btnGuardaRol.Text = "Guardar";
            this.btnGuardaRol.UseVisualStyleBackColor = true;
            this.btnGuardaRol.Click += new System.EventHandler(this.btnGuardaRol_Click);
            // 
            // dtgRoles
            // 
            this.dtgRoles.AllowUserToAddRows = false;
            this.dtgRoles.AllowUserToDeleteRows = false;
            this.dtgRoles.AllowUserToOrderColumns = true;
            this.dtgRoles.AllowUserToResizeColumns = false;
            this.dtgRoles.AllowUserToResizeRows = false;
            this.dtgRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRol,
            this.nombreRol,
            this.limiteEmpleadosRol,
            this.limiteDemandaRol,
            this.activoRol,
            this.permisosRol});
            this.dtgRoles.Location = new System.Drawing.Point(5, 78);
            this.dtgRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgRoles.MultiSelect = false;
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.ReadOnly = true;
            this.dtgRoles.RowHeadersVisible = false;
            this.dtgRoles.RowHeadersWidth = 51;
            this.dtgRoles.RowTemplate.Height = 24;
            this.dtgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRoles.ShowCellToolTips = false;
            this.dtgRoles.Size = new System.Drawing.Size(759, 155);
            this.dtgRoles.TabIndex = 5;
            this.dtgRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRoles_CellDoubleClick);
            this.dtgRoles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRoles_CellMouseDown);
            this.dtgRoles.MouseHover += new System.EventHandler(this.dtgRoles_MouseHover);
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "Id";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // nombreRol
            // 
            this.nombreRol.FillWeight = 116.6128F;
            this.nombreRol.HeaderText = "Rol";
            this.nombreRol.MinimumWidth = 6;
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.ReadOnly = true;
            // 
            // limiteEmpleadosRol
            // 
            this.limiteEmpleadosRol.FillWeight = 116.6128F;
            this.limiteEmpleadosRol.HeaderText = "Limite Empleados";
            this.limiteEmpleadosRol.MinimumWidth = 6;
            this.limiteEmpleadosRol.Name = "limiteEmpleadosRol";
            this.limiteEmpleadosRol.ReadOnly = true;
            // 
            // limiteDemandaRol
            // 
            this.limiteDemandaRol.FillWeight = 116.6128F;
            this.limiteDemandaRol.HeaderText = "Limite En Demanda";
            this.limiteDemandaRol.MinimumWidth = 6;
            this.limiteDemandaRol.Name = "limiteDemandaRol";
            this.limiteDemandaRol.ReadOnly = true;
            // 
            // activoRol
            // 
            this.activoRol.FillWeight = 74.01939F;
            this.activoRol.HeaderText = "Activo";
            this.activoRol.MinimumWidth = 6;
            this.activoRol.Name = "activoRol";
            this.activoRol.ReadOnly = true;
            // 
            // permisosRol
            // 
            this.permisosRol.FillWeight = 76.14214F;
            this.permisosRol.HeaderText = "Permisos";
            this.permisosRol.MinimumWidth = 6;
            this.permisosRol.Name = "permisosRol";
            this.permisosRol.ReadOnly = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.PaleGreen;
            this.tabUsuarios.Controls.Add(this.btnLimpiaUsuario);
            this.tabUsuarios.Controls.Add(this.label14);
            this.tabUsuarios.Controls.Add(this.cmbUserRol);
            this.tabUsuarios.Controls.Add(this.txtPassword);
            this.tabUsuarios.Controls.Add(this.label13);
            this.tabUsuarios.Controls.Add(this.txtUsuario);
            this.tabUsuarios.Controls.Add(this.label12);
            this.tabUsuarios.Controls.Add(this.txtApellidosUsuario);
            this.tabUsuarios.Controls.Add(this.label11);
            this.tabUsuarios.Controls.Add(this.label9);
            this.tabUsuarios.Controls.Add(this.label10);
            this.tabUsuarios.Controls.Add(this.chkUsuario);
            this.tabUsuarios.Controls.Add(this.btnActualizaUsuario);
            this.tabUsuarios.Controls.Add(this.btnGuardaUsuario);
            this.tabUsuarios.Controls.Add(this.txtNombresUsuario);
            this.tabUsuarios.Controls.Add(this.dtgUsuario);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 33);
            this.tabUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsuarios.Size = new System.Drawing.Size(768, 466);
            this.tabUsuarios.TabIndex = 5;
            this.tabUsuarios.Text = "Administrar Usuarios";
            this.tabUsuarios.Enter += new System.EventHandler(this.tabUsuarios_Enter);
            // 
            // btnLimpiaUsuario
            // 
            this.btnLimpiaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiaUsuario.Location = new System.Drawing.Point(455, 171);
            this.btnLimpiaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiaUsuario.Name = "btnLimpiaUsuario";
            this.btnLimpiaUsuario.Size = new System.Drawing.Size(113, 34);
            this.btnLimpiaUsuario.TabIndex = 31;
            this.btnLimpiaUsuario.Text = "Nuevo";
            this.btnLimpiaUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiaUsuario.Click += new System.EventHandler(this.btnLimpiaUsuario_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(19, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "Rol:";
            // 
            // cmbUserRol
            // 
            this.cmbUserRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserRol.FormattingEnabled = true;
            this.cmbUserRol.Location = new System.Drawing.Point(136, 174);
            this.cmbUserRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUserRol.Name = "cmbUserRol";
            this.cmbUserRol.Size = new System.Drawing.Size(172, 29);
            this.cmbUserRol.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(136, 138);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 27);
            this.txtPassword.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(15, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(136, 106);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(172, 27);
            this.txtUsuario.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Usuario:";
            // 
            // txtApellidosUsuario
            // 
            this.txtApellidosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidosUsuario.Location = new System.Drawing.Point(136, 73);
            this.txtApellidosUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidosUsuario.Name = "txtApellidosUsuario";
            this.txtApellidosUsuario.Size = new System.Drawing.Size(172, 27);
            this.txtApellidosUsuario.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "Administrar usuarios:";
            // 
            // chkUsuario
            // 
            this.chkUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.ForeColor = System.Drawing.Color.Black;
            this.chkUsuario.Location = new System.Drawing.Point(329, 113);
            this.chkUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(83, 25);
            this.chkUsuario.TabIndex = 24;
            this.chkUsuario.Text = "Activo";
            this.chkUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizaUsuario
            // 
            this.btnActualizaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaUsuario.Location = new System.Drawing.Point(324, 138);
            this.btnActualizaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizaUsuario.Name = "btnActualizaUsuario";
            this.btnActualizaUsuario.Size = new System.Drawing.Size(125, 33);
            this.btnActualizaUsuario.TabIndex = 28;
            this.btnActualizaUsuario.Text = "Actualizar";
            this.btnActualizaUsuario.UseVisualStyleBackColor = true;
            this.btnActualizaUsuario.Visible = false;
            this.btnActualizaUsuario.Click += new System.EventHandler(this.btnActualizaUsuario_Click);
            // 
            // btnGuardaUsuario
            // 
            this.btnGuardaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnGuardaUsuario.Location = new System.Drawing.Point(324, 172);
            this.btnGuardaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardaUsuario.Name = "btnGuardaUsuario";
            this.btnGuardaUsuario.Size = new System.Drawing.Size(125, 33);
            this.btnGuardaUsuario.TabIndex = 27;
            this.btnGuardaUsuario.Text = "Guardar";
            this.btnGuardaUsuario.UseVisualStyleBackColor = true;
            this.btnGuardaUsuario.Click += new System.EventHandler(this.btnGuardaUsuario_Click);
            // 
            // txtNombresUsuario
            // 
            this.txtNombresUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresUsuario.Location = new System.Drawing.Point(136, 39);
            this.txtNombresUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombresUsuario.Name = "txtNombresUsuario";
            this.txtNombresUsuario.Size = new System.Drawing.Size(172, 27);
            this.txtNombresUsuario.TabIndex = 21;
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToResizeColumns = false;
            this.dtgUsuario.AllowUserToResizeRows = false;
            this.dtgUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.RolUsuario,
            this.FechaCreacionUsuario,
            this.ActivoUsuario});
            this.dtgUsuario.Location = new System.Drawing.Point(5, 230);
            this.dtgUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgUsuario.MultiSelect = false;
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            this.dtgUsuario.RowHeadersWidth = 51;
            this.dtgUsuario.RowTemplate.Height = 24;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.ShowCellToolTips = false;
            this.dtgUsuario.ShowEditingIcon = false;
            this.dtgUsuario.Size = new System.Drawing.Size(759, 233);
            this.dtgUsuario.TabIndex = 29;
            this.dtgUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellDoubleClick);
            this.dtgUsuario.MouseHover += new System.EventHandler(this.dtgUsuario_MouseHover);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.FillWeight = 119.797F;
            this.NombreUsuario.HeaderText = "Nombre Completo";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // RolUsuario
            // 
            this.RolUsuario.FillWeight = 119.797F;
            this.RolUsuario.HeaderText = "Rol";
            this.RolUsuario.MinimumWidth = 6;
            this.RolUsuario.Name = "RolUsuario";
            this.RolUsuario.ReadOnly = true;
            // 
            // FechaCreacionUsuario
            // 
            this.FechaCreacionUsuario.FillWeight = 119.797F;
            this.FechaCreacionUsuario.HeaderText = "Fecha Creacion";
            this.FechaCreacionUsuario.MinimumWidth = 6;
            this.FechaCreacionUsuario.Name = "FechaCreacionUsuario";
            this.FechaCreacionUsuario.ReadOnly = true;
            // 
            // ActivoUsuario
            // 
            this.ActivoUsuario.FillWeight = 40.60914F;
            this.ActivoUsuario.HeaderText = "Activo";
            this.ActivoUsuario.MinimumWidth = 6;
            this.ActivoUsuario.Name = "ActivoUsuario";
            this.ActivoUsuario.ReadOnly = true;
            // 
            // frmMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.tabControlMaestros);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMaestros";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaestros_FormClosing);
            this.tabControlMaestros.ResumeLayout(false);
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProducto)).EndInit();
            this.tabIdentificacion.ResumeLayout(false);
            this.tabIdentificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoIdentificacion)).EndInit();
            this.tabNCF.ResumeLayout(false);
            this.tabNCF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNCF)).EndInit();
            this.tabRoles.ResumeLayout(false);
            this.tabRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabControlMaestros;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.TabPage tabIdentificacion;
        private System.Windows.Forms.TabPage tabNCF;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTipoIdentificacion;
        private System.Windows.Forms.Button btnActualizarIdentificacion;
        private System.Windows.Forms.Button btnGuardarIndentificacion;
        private System.Windows.Forms.TextBox txtTipoIdentificacion;
        private System.Windows.Forms.DataGridView dtgTipoIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkNCF;
        private System.Windows.Forms.Button btnActualizaNCF;
        private System.Windows.Forms.Button btnGuardaNCF;
        private System.Windows.Forms.TextBox txtNCF;
        private System.Windows.Forms.DataGridView dtgNCF;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCategoriaProducto;
        private System.Windows.Forms.Button btnActualizaCproducto;
        private System.Windows.Forms.Button btnGuardaCproducto;
        private System.Windows.Forms.TextBox txtCategoriaProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkRol;
        private System.Windows.Forms.Button btnActualizaRol;
        private System.Windows.Forms.Button btnGuardaRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.Button btnActualizaUsuario;
        private System.Windows.Forms.Button btnGuardaUsuario;
        private System.Windows.Forms.TextBox txtNombresUsuario;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtApellidosUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUserRol;
        public System.Windows.Forms.DataGridView dtgCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.Button btnLimpiarCProducto;
        private System.Windows.Forms.Button btnLimpiarIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreIdentificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivoIdentificacion;
        private System.Windows.Forms.Button btnLimpiarNCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNCF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivoNCF;
        private System.Windows.Forms.Button btnLimpiaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivoUsuario;
        private System.Windows.Forms.Button btnLimpiaRol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteEmpleadosRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteDemandaRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoRol;
        private System.Windows.Forms.DataGridViewButtonColumn permisosRol;
        private System.Windows.Forms.Button btnGuardaPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn formularioPermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoPermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asignarPermiso;
    }
}