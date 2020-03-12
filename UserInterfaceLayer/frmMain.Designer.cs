namespace UserInterfaceLayer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActualUser = new System.Windows.Forms.Label();
            this.lblFormActual = new System.Windows.Forms.Label();
            this.Restore = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menusidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.btnMainLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMainMaestros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMainPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMainReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMainProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMainClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMainRentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurvaSlidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSider1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Formhijos = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AnimacionSider2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menusidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Formhijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuTop.Controls.Add(this.label3);
            this.MenuTop.Controls.Add(this.lblActualUser);
            this.MenuTop.Controls.Add(this.lblFormActual);
            this.MenuTop.Controls.Add(this.Restore);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.Menusidebar);
            this.AnimacionSider2.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1387, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.AnimacionSider1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1220, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario:";
            this.label3.Visible = false;
            // 
            // lblActualUser
            // 
            this.lblActualUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualUser.AutoSize = true;
            this.AnimacionSider1.SetDecoration(this.lblActualUser, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.lblActualUser, BunifuAnimatorNS.DecorationType.None);
            this.lblActualUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblActualUser.Location = new System.Drawing.Point(1284, 60);
            this.lblActualUser.Name = "lblActualUser";
            this.lblActualUser.Size = new System.Drawing.Size(63, 18);
            this.lblActualUser.TabIndex = 7;
            this.lblActualUser.Text = "-----------";
            this.lblActualUser.Visible = false;
            // 
            // lblFormActual
            // 
            this.lblFormActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormActual.AutoSize = true;
            this.AnimacionSider1.SetDecoration(this.lblFormActual, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.lblFormActual, BunifuAnimatorNS.DecorationType.None);
            this.lblFormActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormActual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormActual.Location = new System.Drawing.Point(671, 25);
            this.lblFormActual.Name = "lblFormActual";
            this.lblFormActual.Size = new System.Drawing.Size(311, 32);
            this.lblFormActual.TabIndex = 6;
            this.lblFormActual.Text = "BARRA DE ESTATUS";
            // 
            // Restore
            // 
            this.Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSider1.SetDecoration(this.Restore, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.Restore, BunifuAnimatorNS.DecorationType.None);
            this.Restore.Image = global::UserInterfaceLayer.Properties.Resources.Restore_Window_2_48px;
            this.Restore.Location = new System.Drawing.Point(1306, 12);
            this.Restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(29, 30);
            this.Restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restore.TabIndex = 5;
            this.Restore.TabStop = false;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSider1.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = global::UserInterfaceLayer.Properties.Resources.Minimize_Window_2_48px;
            this.Minimizar.Location = new System.Drawing.Point(1269, 12);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(29, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSider1.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = global::UserInterfaceLayer.Properties.Resources.Maximize_Window_2_48px;
            this.Maximizar.Location = new System.Drawing.Point(1306, 12);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(29, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Visible = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSider1.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = global::UserInterfaceLayer.Properties.Resources.Close_Window__2_48px;
            this.Salir.Location = new System.Drawing.Point(1341, 12);
            this.Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(29, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSider1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "OCULTAR MENÚ";
            // 
            // Menusidebar
            // 
            this.AnimacionSider1.SetDecoration(this.Menusidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.Menusidebar, BunifuAnimatorNS.DecorationType.None);
            this.Menusidebar.Image = global::UserInterfaceLayer.Properties.Resources.Menu_48px;
            this.Menusidebar.Location = new System.Drawing.Point(13, 25);
            this.Menusidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menusidebar.Name = "Menusidebar";
            this.Menusidebar.Size = new System.Drawing.Size(29, 30);
            this.Menusidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menusidebar.TabIndex = 0;
            this.Menusidebar.TabStop = false;
            this.Menusidebar.Click += new System.EventHandler(this.Menusidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.PaleGreen;
            this.SidebarWrapper.Controls.Add(this.btnMainLogout);
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSider2.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(301, 671);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // btnMainLogout
            // 
            this.btnMainLogout.Activecolor = System.Drawing.Color.Lime;
            this.btnMainLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMainLogout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMainLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainLogout.BorderRadius = 0;
            this.btnMainLogout.ButtonText = "                   LOGOUT";
            this.btnMainLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainLogout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnMainLogout.DisabledColor = System.Drawing.Color.LightGreen;
            this.btnMainLogout.Enabled = false;
            this.btnMainLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainLogout.Iconimage = global::UserInterfaceLayer.Properties.Resources.basic_lock;
            this.btnMainLogout.Iconimage_right = null;
            this.btnMainLogout.Iconimage_right_Selected = null;
            this.btnMainLogout.Iconimage_Selected = null;
            this.btnMainLogout.IconMarginLeft = 0;
            this.btnMainLogout.IconMarginRight = 0;
            this.btnMainLogout.IconRightVisible = true;
            this.btnMainLogout.IconRightZoom = 0D;
            this.btnMainLogout.IconVisible = true;
            this.btnMainLogout.IconZoom = 60D;
            this.btnMainLogout.IsTab = false;
            this.btnMainLogout.Location = new System.Drawing.Point(13, 551);
            this.btnMainLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainLogout.Name = "btnMainLogout";
            this.btnMainLogout.Normalcolor = System.Drawing.Color.PaleGreen;
            this.btnMainLogout.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnMainLogout.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMainLogout.selected = false;
            this.btnMainLogout.Size = new System.Drawing.Size(268, 48);
            this.btnMainLogout.TabIndex = 10;
            this.btnMainLogout.Text = "                   LOGOUT";
            this.btnMainLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainLogout.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainLogout.Click += new System.EventHandler(this.btnMainLogout_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnMainMaestros);
            this.Sidebar.Controls.Add(this.btnMainPerfil);
            this.Sidebar.Controls.Add(this.btnMainReportes);
            this.Sidebar.Controls.Add(this.btnMainProductos);
            this.Sidebar.Controls.Add(this.btnMainClientes);
            this.Sidebar.Controls.Add(this.btnMainRentas);
            this.Sidebar.Controls.Add(this.Separador);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSider2.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.LimeGreen;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.PaleGreen;
            this.Sidebar.Location = new System.Drawing.Point(13, 10);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(269, 534);
            this.Sidebar.TabIndex = 0;
            // 
            // btnMainMaestros
            // 
            this.btnMainMaestros.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainMaestros.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMaestros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMaestros.BorderRadius = 0;
            this.btnMainMaestros.ButtonText = "            MAESTROS";
            this.btnMainMaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainMaestros, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainMaestros, BunifuAnimatorNS.DecorationType.None);
            this.btnMainMaestros.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainMaestros.Enabled = false;
            this.btnMainMaestros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainMaestros.Iconimage = global::UserInterfaceLayer.Properties.Resources.settings;
            this.btnMainMaestros.Iconimage_right = null;
            this.btnMainMaestros.Iconimage_right_Selected = null;
            this.btnMainMaestros.Iconimage_Selected = null;
            this.btnMainMaestros.IconMarginLeft = 0;
            this.btnMainMaestros.IconMarginRight = 0;
            this.btnMainMaestros.IconRightVisible = true;
            this.btnMainMaestros.IconRightZoom = 0D;
            this.btnMainMaestros.IconVisible = true;
            this.btnMainMaestros.IconZoom = 65D;
            this.btnMainMaestros.IsTab = false;
            this.btnMainMaestros.Location = new System.Drawing.Point(11, 334);
            this.btnMainMaestros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainMaestros.Name = "btnMainMaestros";
            this.btnMainMaestros.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainMaestros.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainMaestros.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainMaestros.selected = false;
            this.btnMainMaestros.Size = new System.Drawing.Size(249, 41);
            this.btnMainMaestros.TabIndex = 9;
            this.btnMainMaestros.Text = "            MAESTROS";
            this.btnMainMaestros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMaestros.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainMaestros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMaestros.Click += new System.EventHandler(this.btnMainMaestros_Click);
            // 
            // btnMainPerfil
            // 
            this.btnMainPerfil.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnMainPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainPerfil.BorderRadius = 0;
            this.btnMainPerfil.ButtonText = "            MI PERFIL";
            this.btnMainPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainPerfil, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainPerfil, BunifuAnimatorNS.DecorationType.None);
            this.btnMainPerfil.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainPerfil.Enabled = false;
            this.btnMainPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainPerfil.Iconimage = global::UserInterfaceLayer.Properties.Resources.my_account;
            this.btnMainPerfil.Iconimage_right = null;
            this.btnMainPerfil.Iconimage_right_Selected = null;
            this.btnMainPerfil.Iconimage_Selected = null;
            this.btnMainPerfil.IconMarginLeft = 0;
            this.btnMainPerfil.IconMarginRight = 0;
            this.btnMainPerfil.IconRightVisible = true;
            this.btnMainPerfil.IconRightZoom = 0D;
            this.btnMainPerfil.IconVisible = true;
            this.btnMainPerfil.IconZoom = 65D;
            this.btnMainPerfil.IsTab = false;
            this.btnMainPerfil.Location = new System.Drawing.Point(11, 286);
            this.btnMainPerfil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainPerfil.Name = "btnMainPerfil";
            this.btnMainPerfil.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainPerfil.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainPerfil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainPerfil.selected = false;
            this.btnMainPerfil.Size = new System.Drawing.Size(249, 41);
            this.btnMainPerfil.TabIndex = 8;
            this.btnMainPerfil.Text = "            MI PERFIL";
            this.btnMainPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPerfil.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainPerfil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPerfil.Click += new System.EventHandler(this.btnMainPerfil_Click);
            // 
            // btnMainReportes
            // 
            this.btnMainReportes.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnMainReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainReportes.BorderRadius = 0;
            this.btnMainReportes.ButtonText = "            REPORTES";
            this.btnMainReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainReportes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnMainReportes.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainReportes.Enabled = false;
            this.btnMainReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainReportes.Iconimage = global::UserInterfaceLayer.Properties.Resources.administrative_docs;
            this.btnMainReportes.Iconimage_right = null;
            this.btnMainReportes.Iconimage_right_Selected = null;
            this.btnMainReportes.Iconimage_Selected = null;
            this.btnMainReportes.IconMarginLeft = 0;
            this.btnMainReportes.IconMarginRight = 0;
            this.btnMainReportes.IconRightVisible = true;
            this.btnMainReportes.IconRightZoom = 0D;
            this.btnMainReportes.IconVisible = true;
            this.btnMainReportes.IconZoom = 65D;
            this.btnMainReportes.IsTab = false;
            this.btnMainReportes.Location = new System.Drawing.Point(11, 236);
            this.btnMainReportes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainReportes.Name = "btnMainReportes";
            this.btnMainReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainReportes.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainReportes.selected = false;
            this.btnMainReportes.Size = new System.Drawing.Size(249, 41);
            this.btnMainReportes.TabIndex = 7;
            this.btnMainReportes.Text = "            REPORTES";
            this.btnMainReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainReportes.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainReportes.Click += new System.EventHandler(this.btnMainReportes_Click);
            // 
            // btnMainProductos
            // 
            this.btnMainProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnMainProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainProductos.BorderRadius = 0;
            this.btnMainProductos.ButtonText = "            PRODUCTOS";
            this.btnMainProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainProductos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainProductos, BunifuAnimatorNS.DecorationType.None);
            this.btnMainProductos.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainProductos.Enabled = false;
            this.btnMainProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainProductos.Iconimage = global::UserInterfaceLayer.Properties.Resources.product;
            this.btnMainProductos.Iconimage_right = null;
            this.btnMainProductos.Iconimage_right_Selected = null;
            this.btnMainProductos.Iconimage_Selected = null;
            this.btnMainProductos.IconMarginLeft = 0;
            this.btnMainProductos.IconMarginRight = 0;
            this.btnMainProductos.IconRightVisible = true;
            this.btnMainProductos.IconRightZoom = 0D;
            this.btnMainProductos.IconVisible = true;
            this.btnMainProductos.IconZoom = 65D;
            this.btnMainProductos.IsTab = false;
            this.btnMainProductos.Location = new System.Drawing.Point(11, 184);
            this.btnMainProductos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainProductos.Name = "btnMainProductos";
            this.btnMainProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainProductos.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainProductos.selected = false;
            this.btnMainProductos.Size = new System.Drawing.Size(249, 41);
            this.btnMainProductos.TabIndex = 6;
            this.btnMainProductos.Text = "            PRODUCTOS";
            this.btnMainProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainProductos.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainProductos.Click += new System.EventHandler(this.btnMainProductos_Click);
            // 
            // btnMainClientes
            // 
            this.btnMainClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMainClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainClientes.BorderRadius = 0;
            this.btnMainClientes.ButtonText = "            CLIENTES";
            this.btnMainClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainClientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnMainClientes.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMainClientes.Iconimage")));
            this.btnMainClientes.Iconimage_right = null;
            this.btnMainClientes.Iconimage_right_Selected = null;
            this.btnMainClientes.Iconimage_Selected = null;
            this.btnMainClientes.IconMarginLeft = 0;
            this.btnMainClientes.IconMarginRight = 0;
            this.btnMainClientes.IconRightVisible = true;
            this.btnMainClientes.IconRightZoom = 0D;
            this.btnMainClientes.IconVisible = true;
            this.btnMainClientes.IconZoom = 65D;
            this.btnMainClientes.IsTab = false;
            this.btnMainClientes.Location = new System.Drawing.Point(11, 133);
            this.btnMainClientes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainClientes.Name = "btnMainClientes";
            this.btnMainClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainClientes.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainClientes.selected = false;
            this.btnMainClientes.Size = new System.Drawing.Size(249, 41);
            this.btnMainClientes.TabIndex = 5;
            this.btnMainClientes.Text = "            CLIENTES";
            this.btnMainClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainClientes.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainClientes.Click += new System.EventHandler(this.btnMainClientes_Click);
            // 
            // btnMainRentas
            // 
            this.btnMainRentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnMainRentas.BackColor = System.Drawing.Color.Transparent;
            this.btnMainRentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainRentas.BorderRadius = 0;
            this.btnMainRentas.ButtonText = "            RENTAS";
            this.btnMainRentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSider2.SetDecoration(this.btnMainRentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.btnMainRentas, BunifuAnimatorNS.DecorationType.None);
            this.btnMainRentas.DisabledColor = System.Drawing.Color.SeaGreen;
            this.btnMainRentas.Enabled = false;
            this.btnMainRentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainRentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMainRentas.Iconimage")));
            this.btnMainRentas.Iconimage_right = null;
            this.btnMainRentas.Iconimage_right_Selected = null;
            this.btnMainRentas.Iconimage_Selected = null;
            this.btnMainRentas.IconMarginLeft = 0;
            this.btnMainRentas.IconMarginRight = 0;
            this.btnMainRentas.IconRightVisible = true;
            this.btnMainRentas.IconRightZoom = 0D;
            this.btnMainRentas.IconVisible = true;
            this.btnMainRentas.IconZoom = 65D;
            this.btnMainRentas.IsTab = false;
            this.btnMainRentas.Location = new System.Drawing.Point(11, 80);
            this.btnMainRentas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMainRentas.Name = "btnMainRentas";
            this.btnMainRentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainRentas.OnHovercolor = System.Drawing.Color.Green;
            this.btnMainRentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainRentas.selected = false;
            this.btnMainRentas.Size = new System.Drawing.Size(249, 41);
            this.btnMainRentas.TabIndex = 4;
            this.btnMainRentas.Text = "            RENTAS";
            this.btnMainRentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainRentas.Textcolor = System.Drawing.Color.LightGray;
            this.btnMainRentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainRentas.Click += new System.EventHandler(this.btnMainRentas_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSider2.SetDecoration(this.Separador, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.Separador, BunifuAnimatorNS.DecorationType.None);
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 1;
            this.Separador.Location = new System.Drawing.Point(7, 62);
            this.Separador.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(252, 1);
            this.Separador.TabIndex = 3;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSider1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(71, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "DREAMSKY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSider1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::UserInterfaceLayer.Properties.Resources.Dream_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CurvaSlidebar
            // 
            this.CurvaSlidebar.ElipseRadius = 7;
            this.CurvaSlidebar.TargetControl = this;
            // 
            // AnimacionSider1
            // 
            this.AnimacionSider1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimacionSider1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSider1.DefaultAnimation = animation4;
            this.AnimacionSider1.AllAnimationsCompleted += new System.EventHandler(this.Restore_Click);
            // 
            // Formhijos
            // 
            this.Formhijos.BackColor = System.Drawing.Color.PaleGreen;
            this.Formhijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Formhijos.Controls.Add(this.pictureBox2);
            this.AnimacionSider2.SetDecoration(this.Formhijos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider1.SetDecoration(this.Formhijos, BunifuAnimatorNS.DecorationType.None);
            this.Formhijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formhijos.Location = new System.Drawing.Point(301, 80);
            this.Formhijos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Formhijos.Name = "Formhijos";
            this.Formhijos.Size = new System.Drawing.Size(1086, 671);
            this.Formhijos.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSider1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::UserInterfaceLayer.Properties.Resources.Dream_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(133, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(826, 438);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // AnimacionSider2
            // 
            this.AnimacionSider2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimacionSider2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSider2.DefaultAnimation = animation3;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 751);
            this.Controls.Add(this.Formhijos);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSider1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSider2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menusidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Formhijos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Menusidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainRentas;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainPerfil;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainClientes;
        private Bunifu.Framework.UI.BunifuElipse CurvaSlidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSider2;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel Formhijos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFormActual;
        private BunifuAnimatorNS.BunifuTransition AnimacionSider1;
        public Bunifu.Framework.UI.BunifuFlatButton btnMainMaestros;
        private System.Windows.Forms.Label lblActualUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Restore;
    }
}