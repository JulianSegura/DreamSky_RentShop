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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TabControl();
            this.tabCategoria = new System.Windows.Forms.TabPage();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTipoIdentificacion = new System.Windows.Forms.CheckBox();
            this.btnActualizarIdentificacion = new System.Windows.Forms.Button();
            this.btnGuardarIndentifiacion = new System.Windows.Forms.Button();
            this.txtTipoIdentificacion = new System.Windows.Forms.TextBox();
            this.dtgTipoIdentifiacion = new System.Windows.Forms.DataGridView();
            this.tabNCF = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkNfc = new System.Windows.Forms.CheckBox();
            this.btnActualizaNfc = new System.Windows.Forms.Button();
            this.btnGuardaNfc = new System.Windows.Forms.Button();
            this.txtNfc = new System.Windows.Forms.TextBox();
            this.dtgNfc = new System.Windows.Forms.DataGridView();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUserRol = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textApellidoUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.btnActualizaUsuario = new System.Windows.Forms.Button();
            this.btnGuardaUsuario = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCProducto = new System.Windows.Forms.Button();
            this.txtNombreUsuario.SuspendLayout();
            this.tabCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProducto)).BeginInit();
            this.tabIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoIdentifiacion)).BeginInit();
            this.tabNCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNfc)).BeginInit();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(467, 424);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 28);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUsuario.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.txtNombreUsuario.Controls.Add(this.tabCategoria);
            this.txtNombreUsuario.Controls.Add(this.tabIdentificacion);
            this.txtNombreUsuario.Controls.Add(this.tabNCF);
            this.txtNombreUsuario.Controls.Add(this.tabRoles);
            this.txtNombreUsuario.Controls.Add(this.tabUsuarios);
            this.txtNombreUsuario.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(7, 11);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.SelectedIndex = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(582, 409);
            this.txtNombreUsuario.TabIndex = 1;
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
            this.tabCategoria.Location = new System.Drawing.Point(4, 31);
            this.tabCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.tabCategoria.Size = new System.Drawing.Size(574, 374);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categoria Producto";
            this.tabCategoria.Enter += new System.EventHandler(this.tabCategoria_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Administrar Categoria de Producto";
            // 
            // chkCategoriaProducto
            // 
            this.chkCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCategoriaProducto.AutoSize = true;
            this.chkCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.chkCategoriaProducto.Location = new System.Drawing.Point(199, 33);
            this.chkCategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.chkCategoriaProducto.Name = "chkCategoriaProducto";
            this.chkCategoriaProducto.Size = new System.Drawing.Size(71, 23);
            this.chkCategoriaProducto.TabIndex = 2;
            this.chkCategoriaProducto.Text = "Activo";
            this.chkCategoriaProducto.UseVisualStyleBackColor = true;
            // 
            // btnActualizaCproducto
            // 
            this.btnActualizaCproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaCproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaCproducto.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaCproducto.Location = new System.Drawing.Point(377, 29);
            this.btnActualizaCproducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizaCproducto.Name = "btnActualizaCproducto";
            this.btnActualizaCproducto.Size = new System.Drawing.Size(94, 28);
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
            this.btnGuardaCproducto.Location = new System.Drawing.Point(278, 29);
            this.btnGuardaCproducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardaCproducto.Name = "btnGuardaCproducto";
            this.btnGuardaCproducto.Size = new System.Drawing.Size(85, 28);
            this.btnGuardaCproducto.TabIndex = 3;
            this.btnGuardaCproducto.Text = "Guardar";
            this.btnGuardaCproducto.UseVisualStyleBackColor = true;
            this.btnGuardaCproducto.Click += new System.EventHandler(this.btnGuardaCproducto_Click);
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoriaProducto.Location = new System.Drawing.Point(76, 32);
            this.txtCategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(116, 23);
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
            this.dtgCategoriaProducto.Location = new System.Drawing.Point(4, 63);
            this.dtgCategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCategoriaProducto.MultiSelect = false;
            this.dtgCategoriaProducto.Name = "dtgCategoriaProducto";
            this.dtgCategoriaProducto.ReadOnly = true;
            this.dtgCategoriaProducto.RowHeadersVisible = false;
            this.dtgCategoriaProducto.RowHeadersWidth = 51;
            this.dtgCategoriaProducto.RowTemplate.Height = 24;
            this.dtgCategoriaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategoriaProducto.ShowCellToolTips = false;
            this.dtgCategoriaProducto.Size = new System.Drawing.Size(569, 313);
            this.dtgCategoriaProducto.TabIndex = 5;
            this.dtgCategoriaProducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategoriaProducto_CellContentDoubleClick);
            this.dtgCategoriaProducto.MouseEnter += new System.EventHandler(this.dtgCategoriaProducto_MouseEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 149.2386F;
            this.Nombre.HeaderText = "Categoria Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.FillWeight = 50.76142F;
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // tabIdentificacion
            // 
            this.tabIdentificacion.BackColor = System.Drawing.Color.PaleGreen;
            this.tabIdentificacion.Controls.Add(this.label3);
            this.tabIdentificacion.Controls.Add(this.label4);
            this.tabIdentificacion.Controls.Add(this.chkTipoIdentificacion);
            this.tabIdentificacion.Controls.Add(this.btnActualizarIdentificacion);
            this.tabIdentificacion.Controls.Add(this.btnGuardarIndentifiacion);
            this.tabIdentificacion.Controls.Add(this.txtTipoIdentificacion);
            this.tabIdentificacion.Controls.Add(this.dtgTipoIdentifiacion);
            this.tabIdentificacion.ForeColor = System.Drawing.Color.Transparent;
            this.tabIdentificacion.Location = new System.Drawing.Point(4, 31);
            this.tabIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.tabIdentificacion.Name = "tabIdentificacion";
            this.tabIdentificacion.Padding = new System.Windows.Forms.Padding(2);
            this.tabIdentificacion.Size = new System.Drawing.Size(574, 374);
            this.tabIdentificacion.TabIndex = 2;
            this.tabIdentificacion.Text = "Tipos de Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrar tipos de identificacion";
            // 
            // chkTipoIdentificacion
            // 
            this.chkTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTipoIdentificacion.AutoSize = true;
            this.chkTipoIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.chkTipoIdentificacion.Location = new System.Drawing.Point(199, 33);
            this.chkTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.chkTipoIdentificacion.Name = "chkTipoIdentificacion";
            this.chkTipoIdentificacion.Size = new System.Drawing.Size(71, 23);
            this.chkTipoIdentificacion.TabIndex = 8;
            this.chkTipoIdentificacion.Text = "Activo";
            this.chkTipoIdentificacion.UseVisualStyleBackColor = true;
            // 
            // btnActualizarIdentificacion
            // 
            this.btnActualizarIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarIdentificacion.Location = new System.Drawing.Point(377, 29);
            this.btnActualizarIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarIdentificacion.Name = "btnActualizarIdentificacion";
            this.btnActualizarIdentificacion.Size = new System.Drawing.Size(94, 28);
            this.btnActualizarIdentificacion.TabIndex = 10;
            this.btnActualizarIdentificacion.Text = "Actualizar";
            this.btnActualizarIdentificacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardarIndentifiacion
            // 
            this.btnGuardarIndentifiacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarIndentifiacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIndentifiacion.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarIndentifiacion.Location = new System.Drawing.Point(289, 29);
            this.btnGuardarIndentifiacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarIndentifiacion.Name = "btnGuardarIndentifiacion";
            this.btnGuardarIndentifiacion.Size = new System.Drawing.Size(85, 28);
            this.btnGuardarIndentifiacion.TabIndex = 9;
            this.btnGuardarIndentifiacion.Text = "Guardar";
            this.btnGuardarIndentifiacion.UseVisualStyleBackColor = true;
            // 
            // txtTipoIdentificacion
            // 
            this.txtTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoIdentificacion.Location = new System.Drawing.Point(76, 32);
            this.txtTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoIdentificacion.Name = "txtTipoIdentificacion";
            this.txtTipoIdentificacion.Size = new System.Drawing.Size(116, 23);
            this.txtTipoIdentificacion.TabIndex = 7;
            // 
            // dtgTipoIdentifiacion
            // 
            this.dtgTipoIdentifiacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTipoIdentifiacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoIdentifiacion.Location = new System.Drawing.Point(4, 63);
            this.dtgTipoIdentifiacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTipoIdentifiacion.Name = "dtgTipoIdentifiacion";
            this.dtgTipoIdentifiacion.RowHeadersWidth = 51;
            this.dtgTipoIdentifiacion.RowTemplate.Height = 24;
            this.dtgTipoIdentifiacion.Size = new System.Drawing.Size(569, 313);
            this.dtgTipoIdentifiacion.TabIndex = 11;
            // 
            // tabNCF
            // 
            this.tabNCF.BackColor = System.Drawing.Color.PaleGreen;
            this.tabNCF.Controls.Add(this.label5);
            this.tabNCF.Controls.Add(this.label6);
            this.tabNCF.Controls.Add(this.chkNfc);
            this.tabNCF.Controls.Add(this.btnActualizaNfc);
            this.tabNCF.Controls.Add(this.btnGuardaNfc);
            this.tabNCF.Controls.Add(this.txtNfc);
            this.tabNCF.Controls.Add(this.dtgNfc);
            this.tabNCF.Location = new System.Drawing.Point(4, 31);
            this.tabNCF.Name = "tabNCF";
            this.tabNCF.Size = new System.Drawing.Size(574, 374);
            this.tabNCF.TabIndex = 3;
            this.tabNCF.Text = "Tipo NCF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Administrar tipo de NFC";
            // 
            // chkNfc
            // 
            this.chkNfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNfc.AutoSize = true;
            this.chkNfc.Location = new System.Drawing.Point(199, 33);
            this.chkNfc.Margin = new System.Windows.Forms.Padding(2);
            this.chkNfc.Name = "chkNfc";
            this.chkNfc.Size = new System.Drawing.Size(71, 23);
            this.chkNfc.TabIndex = 13;
            this.chkNfc.Text = "Activo";
            this.chkNfc.UseVisualStyleBackColor = true;
            // 
            // btnActualizaNfc
            // 
            this.btnActualizaNfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaNfc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaNfc.Location = new System.Drawing.Point(377, 29);
            this.btnActualizaNfc.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizaNfc.Name = "btnActualizaNfc";
            this.btnActualizaNfc.Size = new System.Drawing.Size(94, 28);
            this.btnActualizaNfc.TabIndex = 15;
            this.btnActualizaNfc.Text = "Actualizar";
            this.btnActualizaNfc.UseVisualStyleBackColor = true;
            // 
            // btnGuardaNfc
            // 
            this.btnGuardaNfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaNfc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaNfc.Location = new System.Drawing.Point(289, 29);
            this.btnGuardaNfc.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardaNfc.Name = "btnGuardaNfc";
            this.btnGuardaNfc.Size = new System.Drawing.Size(85, 28);
            this.btnGuardaNfc.TabIndex = 14;
            this.btnGuardaNfc.Text = "Guardar";
            this.btnGuardaNfc.UseVisualStyleBackColor = true;
            // 
            // txtNfc
            // 
            this.txtNfc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNfc.Location = new System.Drawing.Point(76, 32);
            this.txtNfc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNfc.Name = "txtNfc";
            this.txtNfc.Size = new System.Drawing.Size(116, 23);
            this.txtNfc.TabIndex = 12;
            // 
            // dtgNfc
            // 
            this.dtgNfc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNfc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNfc.Location = new System.Drawing.Point(4, 63);
            this.dtgNfc.Margin = new System.Windows.Forms.Padding(2);
            this.dtgNfc.Name = "dtgNfc";
            this.dtgNfc.RowHeadersWidth = 51;
            this.dtgNfc.RowTemplate.Height = 24;
            this.dtgNfc.Size = new System.Drawing.Size(569, 313);
            this.dtgNfc.TabIndex = 16;
            // 
            // tabRoles
            // 
            this.tabRoles.BackColor = System.Drawing.Color.PaleGreen;
            this.tabRoles.Controls.Add(this.label7);
            this.tabRoles.Controls.Add(this.label8);
            this.tabRoles.Controls.Add(this.checkBox4);
            this.tabRoles.Controls.Add(this.button8);
            this.tabRoles.Controls.Add(this.button9);
            this.tabRoles.Controls.Add(this.textBox4);
            this.tabRoles.Controls.Add(this.dataGridView4);
            this.tabRoles.Location = new System.Drawing.Point(4, 31);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(574, 374);
            this.tabRoles.TabIndex = 4;
            this.tabRoles.Text = "Roles y Permisos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Administrar roles y permisos";
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(199, 33);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 23);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Activo";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(377, 29);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 28);
            this.button8.TabIndex = 20;
            this.button8.Text = "Actualizar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(289, 29);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 28);
            this.button9.TabIndex = 19;
            this.button9.Text = "Guardar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(76, 32);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 23);
            this.textBox4.TabIndex = 17;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(4, 63);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(569, 313);
            this.dataGridView4.TabIndex = 16;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.PaleGreen;
            this.tabUsuarios.Controls.Add(this.label14);
            this.tabUsuarios.Controls.Add(this.cmbUserRol);
            this.tabUsuarios.Controls.Add(this.txtpassword);
            this.tabUsuarios.Controls.Add(this.label13);
            this.tabUsuarios.Controls.Add(this.txtUsuario);
            this.tabUsuarios.Controls.Add(this.label12);
            this.tabUsuarios.Controls.Add(this.textApellidoUsuario);
            this.tabUsuarios.Controls.Add(this.label11);
            this.tabUsuarios.Controls.Add(this.label9);
            this.tabUsuarios.Controls.Add(this.label10);
            this.tabUsuarios.Controls.Add(this.chkUsuario);
            this.tabUsuarios.Controls.Add(this.btnActualizaUsuario);
            this.tabUsuarios.Controls.Add(this.btnGuardaUsuario);
            this.tabUsuarios.Controls.Add(this.textBox5);
            this.tabUsuarios.Controls.Add(this.dtgUsuario);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 31);
            this.tabUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(2);
            this.tabUsuarios.Size = new System.Drawing.Size(574, 374);
            this.tabUsuarios.TabIndex = 5;
            this.tabUsuarios.Text = "Administrar Usuarios";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "Rol:";
            // 
            // cmbUserRol
            // 
            this.cmbUserRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserRol.FormattingEnabled = true;
            this.cmbUserRol.Location = new System.Drawing.Point(102, 141);
            this.cmbUserRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserRol.Name = "cmbUserRol";
            this.cmbUserRol.Size = new System.Drawing.Size(130, 27);
            this.cmbUserRol.TabIndex = 26;
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassword.Location = new System.Drawing.Point(102, 112);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(130, 23);
            this.txtpassword.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(102, 84);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 23);
            this.txtUsuario.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Usuario:";
            // 
            // textApellidoUsuario
            // 
            this.textApellidoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textApellidoUsuario.Location = new System.Drawing.Point(102, 57);
            this.textApellidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textApellidoUsuario.Name = "textApellidoUsuario";
            this.textApellidoUsuario.Size = new System.Drawing.Size(130, 23);
            this.textApellidoUsuario.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Administrar usuarios";
            // 
            // chkUsuario
            // 
            this.chkUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.ForeColor = System.Drawing.Color.Black;
            this.chkUsuario.Location = new System.Drawing.Point(241, 84);
            this.chkUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(71, 23);
            this.chkUsuario.TabIndex = 24;
            this.chkUsuario.Text = "Activo";
            this.chkUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizaUsuario
            // 
            this.btnActualizaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaUsuario.Location = new System.Drawing.Point(243, 109);
            this.btnActualizaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizaUsuario.Name = "btnActualizaUsuario";
            this.btnActualizaUsuario.Size = new System.Drawing.Size(85, 28);
            this.btnActualizaUsuario.TabIndex = 28;
            this.btnActualizaUsuario.Text = "Actualizar";
            this.btnActualizaUsuario.UseVisualStyleBackColor = true;
            // 
            // btnGuardaUsuario
            // 
            this.btnGuardaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnGuardaUsuario.Location = new System.Drawing.Point(243, 140);
            this.btnGuardaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardaUsuario.Name = "btnGuardaUsuario";
            this.btnGuardaUsuario.Size = new System.Drawing.Size(85, 28);
            this.btnGuardaUsuario.TabIndex = 27;
            this.btnGuardaUsuario.Text = "Guardar";
            this.btnGuardaUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(102, 32);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 23);
            this.textBox5.TabIndex = 21;
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(4, 175);
            this.dtgUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.RowHeadersWidth = 51;
            this.dtgUsuario.RowTemplate.Height = 24;
            this.dtgUsuario.Size = new System.Drawing.Size(569, 201);
            this.dtgUsuario.TabIndex = 29;
            // 
            // btnLimpiarCProducto
            // 
            this.btnLimpiarCProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCProducto.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCProducto.Location = new System.Drawing.Point(377, 29);
            this.btnLimpiarCProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCProducto.Name = "btnLimpiarCProducto";
            this.btnLimpiarCProducto.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiarCProducto.TabIndex = 23;
            this.btnLimpiarCProducto.Text = "Limpiar";
            this.btnLimpiarCProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarCProducto.Click += new System.EventHandler(this.btnLimpiarCProducto_Click);
            // 
            // frmMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(600, 462);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaestros";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaestros_FormClosing);
            this.txtNombreUsuario.ResumeLayout(false);
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProducto)).EndInit();
            this.tabIdentificacion.ResumeLayout(false);
            this.tabIdentificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoIdentifiacion)).EndInit();
            this.tabNCF.ResumeLayout(false);
            this.tabNCF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNfc)).EndInit();
            this.tabRoles.ResumeLayout(false);
            this.tabRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl txtNombreUsuario;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.TabPage tabIdentificacion;
        private System.Windows.Forms.TabPage tabNCF;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTipoIdentificacion;
        private System.Windows.Forms.Button btnActualizarIdentificacion;
        private System.Windows.Forms.Button btnGuardarIndentifiacion;
        private System.Windows.Forms.TextBox txtTipoIdentificacion;
        private System.Windows.Forms.DataGridView dtgTipoIdentifiacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkNfc;
        private System.Windows.Forms.Button btnActualizaNfc;
        private System.Windows.Forms.Button btnGuardaNfc;
        private System.Windows.Forms.TextBox txtNfc;
        private System.Windows.Forms.DataGridView dtgNfc;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCategoriaProducto;
        private System.Windows.Forms.Button btnActualizaCproducto;
        private System.Windows.Forms.Button btnGuardaCproducto;
        private System.Windows.Forms.TextBox txtCategoriaProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.Button btnActualizaUsuario;
        private System.Windows.Forms.Button btnGuardaUsuario;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textApellidoUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUserRol;
        public System.Windows.Forms.DataGridView dtgCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.Button btnLimpiarCProducto;
    }
}