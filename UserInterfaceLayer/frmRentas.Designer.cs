namespace UserInterfaceLayer
{
    partial class frmRentas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRentas = new System.Windows.Forms.TabPage();
            this.cmbBuscarArticulo = new System.Windows.Forms.ComboBox();
            this.lblTotalRenta = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnNuevaRenta = new System.Windows.Forms.Button();
            this.btnGuardarRenta = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefonoRentas = new System.Windows.Forms.Label();
            this.lblPaisOrigenRentas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDireccionRentas = new System.Windows.Forms.Label();
            this.lblCorreoRentas = new System.Windows.Forms.Label();
            this.lblCelularRentas = new System.Windows.Forms.Label();
            this.lblFechaRegistroRentas = new System.Windows.Forms.Label();
            this.lblIdentificacionRentas = new System.Windows.Forms.Label();
            this.lblApellidoRentas = new System.Windows.Forms.Label();
            this.lblNombreRentas = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdRentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgRentasAbiertas = new System.Windows.Forms.DataGridView();
            this.CodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.label14 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabRentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRentasAbiertas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(563, 557);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRentas);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 509);
            this.tabControl1.TabIndex = 96;
            // 
            // tabRentas
            // 
            this.tabRentas.BackColor = System.Drawing.Color.PaleGreen;
            this.tabRentas.Controls.Add(this.cmbBuscarArticulo);
            this.tabRentas.Controls.Add(this.lblTotalRenta);
            this.tabRentas.Controls.Add(this.label17);
            this.tabRentas.Controls.Add(this.label19);
            this.tabRentas.Controls.Add(this.txtCantidad);
            this.tabRentas.Controls.Add(this.btnNuevaRenta);
            this.tabRentas.Controls.Add(this.btnGuardarRenta);
            this.tabRentas.Controls.Add(this.dtpHasta);
            this.tabRentas.Controls.Add(this.dtpDesde);
            this.tabRentas.Controls.Add(this.label16);
            this.tabRentas.Controls.Add(this.label13);
            this.tabRentas.Controls.Add(this.btnAgregarArticulo);
            this.tabRentas.Controls.Add(this.label9);
            this.tabRentas.Controls.Add(this.btnBuscarCliente);
            this.tabRentas.Controls.Add(this.groupBox1);
            this.tabRentas.Controls.Add(this.txtBuscarCliente);
            this.tabRentas.Controls.Add(this.label5);
            this.tabRentas.Controls.Add(this.dtgRentasAbiertas);
            this.tabRentas.Location = new System.Drawing.Point(4, 26);
            this.tabRentas.Margin = new System.Windows.Forms.Padding(2);
            this.tabRentas.Name = "tabRentas";
            this.tabRentas.Padding = new System.Windows.Forms.Padding(2);
            this.tabRentas.Size = new System.Drawing.Size(667, 479);
            this.tabRentas.TabIndex = 0;
            this.tabRentas.Text = "Rentas";
            this.tabRentas.Enter += new System.EventHandler(this.tabRentas_Enter);
            // 
            // cmbBuscarArticulo
            // 
            this.cmbBuscarArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBuscarArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscarArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbBuscarArticulo.FormattingEnabled = true;
            this.cmbBuscarArticulo.Location = new System.Drawing.Point(122, 283);
            this.cmbBuscarArticulo.Name = "cmbBuscarArticulo";
            this.cmbBuscarArticulo.Size = new System.Drawing.Size(157, 21);
            this.cmbBuscarArticulo.TabIndex = 5;
            // 
            // lblTotalRenta
            // 
            this.lblTotalRenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRenta.AutoSize = true;
            this.lblTotalRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRenta.Location = new System.Drawing.Point(530, 448);
            this.lblTotalRenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRenta.Name = "lblTotalRenta";
            this.lblTotalRenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalRenta.Size = new System.Drawing.Size(40, 24);
            this.lblTotalRenta.TabIndex = 116;
            this.lblTotalRenta.Text = ".....";
            this.lblTotalRenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 284);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 122;
            this.label17.Text = "Cantidad:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(427, 453);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 17);
            this.label19.TabIndex = 115;
            this.label19.Text = "Total General:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(351, 281);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(71, 23);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnNuevaRenta
            // 
            this.btnNuevaRenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevaRenta.BackColor = System.Drawing.Color.Silver;
            this.btnNuevaRenta.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevaRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaRenta.Location = new System.Drawing.Point(158, 447);
            this.btnNuevaRenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaRenta.Name = "btnNuevaRenta";
            this.btnNuevaRenta.Size = new System.Drawing.Size(144, 28);
            this.btnNuevaRenta.TabIndex = 9;
            this.btnNuevaRenta.Text = "Nueva Renta";
            this.btnNuevaRenta.UseVisualStyleBackColor = false;
            this.btnNuevaRenta.Click += new System.EventHandler(this.btnNuevaRenta_Click);
            // 
            // btnGuardarRenta
            // 
            this.btnGuardarRenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarRenta.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarRenta.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRenta.Location = new System.Drawing.Point(10, 448);
            this.btnGuardarRenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarRenta.Name = "btnGuardarRenta";
            this.btnGuardarRenta.Size = new System.Drawing.Size(144, 28);
            this.btnGuardarRenta.TabIndex = 8;
            this.btnGuardarRenta.Text = "Guardar Renta";
            this.btnGuardarRenta.UseVisualStyleBackColor = false;
            this.btnGuardarRenta.Click += new System.EventHandler(this.btnGuardarRenta_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(404, 238);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(157, 23);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(122, 238);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.MinDate = new System.DateTime(2020, 3, 17, 14, 45, 26, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(157, 23);
            this.dtpDesde.TabIndex = 3;
            this.dtpDesde.Value = new System.DateTime(2020, 3, 17, 14, 45, 26, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(300, 243);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 17);
            this.label16.TabIndex = 116;
            this.label16.Text = "Renta HASTA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 243);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 115;
            this.label13.Text = "Renta DESDE:";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(430, 278);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(116, 28);
            this.btnAgregarArticulo.TabIndex = 7;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 112;
            this.label9.Text = "Agregar Articulo:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(254, 10);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(68, 25);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTelefonoRentas);
            this.groupBox1.Controls.Add(this.lblPaisOrigenRentas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDireccionRentas);
            this.groupBox1.Controls.Add(this.lblCorreoRentas);
            this.groupBox1.Controls.Add(this.lblCelularRentas);
            this.groupBox1.Controls.Add(this.lblFechaRegistroRentas);
            this.groupBox1.Controls.Add(this.lblIdentificacionRentas);
            this.groupBox1.Controls.Add(this.lblApellidoRentas);
            this.groupBox1.Controls.Add(this.lblNombreRentas);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblIdRentas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(4, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(657, 188);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados:";
            // 
            // lblTelefonoRentas
            // 
            this.lblTelefonoRentas.AutoSize = true;
            this.lblTelefonoRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefonoRentas.Location = new System.Drawing.Point(376, 52);
            this.lblTelefonoRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoRentas.Name = "lblTelefonoRentas";
            this.lblTelefonoRentas.Size = new System.Drawing.Size(28, 17);
            this.lblTelefonoRentas.TabIndex = 114;
            this.lblTelefonoRentas.Text = ".....";
            // 
            // lblPaisOrigenRentas
            // 
            this.lblPaisOrigenRentas.AutoSize = true;
            this.lblPaisOrigenRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisOrigenRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaisOrigenRentas.Location = new System.Drawing.Point(139, 141);
            this.lblPaisOrigenRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaisOrigenRentas.Name = "lblPaisOrigenRentas";
            this.lblPaisOrigenRentas.Size = new System.Drawing.Size(28, 17);
            this.lblPaisOrigenRentas.TabIndex = 113;
            this.lblPaisOrigenRentas.Text = ".....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 112;
            this.label8.Text = "Pais Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Telefono:";
            // 
            // lblDireccionRentas
            // 
            this.lblDireccionRentas.AutoSize = true;
            this.lblDireccionRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionRentas.Location = new System.Drawing.Point(376, 112);
            this.lblDireccionRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionRentas.Name = "lblDireccionRentas";
            this.lblDireccionRentas.Size = new System.Drawing.Size(28, 17);
            this.lblDireccionRentas.TabIndex = 110;
            this.lblDireccionRentas.Text = ".....";
            // 
            // lblCorreoRentas
            // 
            this.lblCorreoRentas.AutoSize = true;
            this.lblCorreoRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreoRentas.Location = new System.Drawing.Point(376, 82);
            this.lblCorreoRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoRentas.Name = "lblCorreoRentas";
            this.lblCorreoRentas.Size = new System.Drawing.Size(28, 17);
            this.lblCorreoRentas.TabIndex = 109;
            this.lblCorreoRentas.Text = ".....";
            // 
            // lblCelularRentas
            // 
            this.lblCelularRentas.AutoSize = true;
            this.lblCelularRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCelularRentas.Location = new System.Drawing.Point(376, 26);
            this.lblCelularRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelularRentas.Name = "lblCelularRentas";
            this.lblCelularRentas.Size = new System.Drawing.Size(28, 17);
            this.lblCelularRentas.TabIndex = 108;
            this.lblCelularRentas.Text = ".....";
            // 
            // lblFechaRegistroRentas
            // 
            this.lblFechaRegistroRentas.AutoSize = true;
            this.lblFechaRegistroRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistroRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaRegistroRentas.Location = new System.Drawing.Point(139, 166);
            this.lblFechaRegistroRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistroRentas.Name = "lblFechaRegistroRentas";
            this.lblFechaRegistroRentas.Size = new System.Drawing.Size(28, 17);
            this.lblFechaRegistroRentas.TabIndex = 107;
            this.lblFechaRegistroRentas.Text = ".....";
            // 
            // lblIdentificacionRentas
            // 
            this.lblIdentificacionRentas.AutoSize = true;
            this.lblIdentificacionRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacionRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdentificacionRentas.Location = new System.Drawing.Point(139, 114);
            this.lblIdentificacionRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacionRentas.Name = "lblIdentificacionRentas";
            this.lblIdentificacionRentas.Size = new System.Drawing.Size(28, 17);
            this.lblIdentificacionRentas.TabIndex = 106;
            this.lblIdentificacionRentas.Text = ".....";
            // 
            // lblApellidoRentas
            // 
            this.lblApellidoRentas.AutoSize = true;
            this.lblApellidoRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblApellidoRentas.Location = new System.Drawing.Point(139, 82);
            this.lblApellidoRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoRentas.Name = "lblApellidoRentas";
            this.lblApellidoRentas.Size = new System.Drawing.Size(28, 17);
            this.lblApellidoRentas.TabIndex = 105;
            this.lblApellidoRentas.Text = ".....";
            // 
            // lblNombreRentas
            // 
            this.lblNombreRentas.AutoSize = true;
            this.lblNombreRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreRentas.Location = new System.Drawing.Point(139, 52);
            this.lblNombreRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreRentas.Name = "lblNombreRentas";
            this.lblNombreRentas.Size = new System.Drawing.Size(28, 17);
            this.lblNombreRentas.TabIndex = 104;
            this.lblNombreRentas.Text = ".....";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 114);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 103;
            this.label15.Text = "Identificacion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 101;
            this.label12.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Celular:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 102;
            this.label11.Text = "Fecha de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Id:";
            // 
            // lblIdRentas
            // 
            this.lblIdRentas.AutoSize = true;
            this.lblIdRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdRentas.Location = new System.Drawing.Point(139, 26);
            this.lblIdRentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdRentas.Name = "lblIdRentas";
            this.lblIdRentas.Size = new System.Drawing.Size(33, 17);
            this.lblIdRentas.TabIndex = 96;
            this.lblIdRentas.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nombres:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(93, 10);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(157, 23);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 104;
            this.label5.Text = "Identificación:";
            // 
            // dtgRentasAbiertas
            // 
            this.dtgRentasAbiertas.AllowUserToAddRows = false;
            this.dtgRentasAbiertas.AllowUserToDeleteRows = false;
            this.dtgRentasAbiertas.AllowUserToOrderColumns = true;
            this.dtgRentasAbiertas.AllowUserToResizeColumns = false;
            this.dtgRentasAbiertas.AllowUserToResizeRows = false;
            this.dtgRentasAbiertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRentasAbiertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRentasAbiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRentasAbiertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodArticulo,
            this.DescArticulo,
            this.CostoArticulo,
            this.QtyArticulo,
            this.Total});
            this.dtgRentasAbiertas.Location = new System.Drawing.Point(10, 308);
            this.dtgRentasAbiertas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgRentasAbiertas.MultiSelect = false;
            this.dtgRentasAbiertas.Name = "dtgRentasAbiertas";
            this.dtgRentasAbiertas.ReadOnly = true;
            this.dtgRentasAbiertas.RowHeadersVisible = false;
            this.dtgRentasAbiertas.RowHeadersWidth = 51;
            this.dtgRentasAbiertas.RowTemplate.Height = 24;
            this.dtgRentasAbiertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRentasAbiertas.Size = new System.Drawing.Size(649, 132);
            this.dtgRentasAbiertas.TabIndex = 99;
            this.dtgRentasAbiertas.TabStop = false;
            this.dtgRentasAbiertas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRentasAbiertas_CellDoubleClick);
            this.dtgRentasAbiertas.MouseHover += new System.EventHandler(this.dtgRentasAbiertas_MouseHover);
            // 
            // CodArticulo
            // 
            this.CodArticulo.HeaderText = "Codigo";
            this.CodArticulo.Name = "CodArticulo";
            this.CodArticulo.ReadOnly = true;
            // 
            // DescArticulo
            // 
            this.DescArticulo.HeaderText = "Descripcion";
            this.DescArticulo.Name = "DescArticulo";
            this.DescArticulo.ReadOnly = true;
            // 
            // CostoArticulo
            // 
            this.CostoArticulo.HeaderText = "Costo Alquiler";
            this.CostoArticulo.Name = "CostoArticulo";
            this.CostoArticulo.ReadOnly = true;
            // 
            // QtyArticulo
            // 
            this.QtyArticulo.HeaderText = "Cantidad";
            this.QtyArticulo.Name = "QtyArticulo";
            this.QtyArticulo.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGreen;
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dtgInventario);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(667, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrega de Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(272, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 25);
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(126, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 23);
            this.txtBuscar.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 101;
            this.label7.Text = "Buscar Inventario:";
            // 
            // dtgInventario
            // 
            this.dtgInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(4, 50);
            this.dtgInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.RowHeadersWidth = 51;
            this.dtgInventario.RowTemplate.Height = 24;
            this.dtgInventario.Size = new System.Drawing.Size(660, 428);
            this.dtgInventario.TabIndex = 100;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 1;
            this.Separador.Location = new System.Drawing.Point(10, 28);
            this.Separador.Margin = new System.Windows.Forms.Padding(4);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(589, 8);
            this.Separador.TabIndex = 95;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(10, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(420, 21);
            this.label14.TabIndex = 94;
            this.label14.Text = "Registro de Rentas y entregas de Productos:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(694, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRentas";
            this.Text = "frmRentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentas_FormClosing_1);
            this.tabControl1.ResumeLayout(false);
            this.tabRentas.ResumeLayout(false);
            this.tabRentas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRentasAbiertas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRentas;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgRentasAbiertas;
        private System.Windows.Forms.Label lblIdRentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgInventario;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreRentas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblApellidoRentas;
        private System.Windows.Forms.Label lblDireccionRentas;
        private System.Windows.Forms.Label lblCorreoRentas;
        private System.Windows.Forms.Label lblCelularRentas;
        private System.Windows.Forms.Label lblFechaRegistroRentas;
        private System.Windows.Forms.Label lblIdentificacionRentas;
        private System.Windows.Forms.Label lblTelefonoRentas;
        private System.Windows.Forms.Label lblPaisOrigenRentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevaRenta;
        private System.Windows.Forms.Button btnGuardarRenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotalRenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cmbBuscarArticulo;
    }
}