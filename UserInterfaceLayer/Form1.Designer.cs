namespace UserInterfaceLayer
{
    partial class Form1
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
            this.txtNames = new System.Windows.Forms.TextBox();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radInactive = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(109, 58);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(156, 24);
            this.txtNames.TabIndex = 0;
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Location = new System.Drawing.Point(109, 222);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(66, 22);
            this.radActive.TabIndex = 4;
            this.radActive.TabStop = true;
            this.radActive.Text = "Activo";
            this.radActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre(s)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido(s)";
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(109, 98);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(156, 24);
            this.txtLastNames.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(109, 139);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 24);
            this.txtUser.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // radInactive
            // 
            this.radInactive.AutoSize = true;
            this.radInactive.Location = new System.Drawing.Point(189, 222);
            this.radInactive.Name = "radInactive";
            this.radInactive.Size = new System.Drawing.Size(76, 22);
            this.radInactive.TabIndex = 5;
            this.radInactive.TabStop = true;
            this.radInactive.Text = "Inactivo";
            this.radInactive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Actual";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(106, 27);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(49, 18);
            this.lblCurrentDate.TabIndex = 12;
            this.lblCurrentDate.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 341);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radInactive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radActive);
            this.Controls.Add(this.txtNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radInactive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentDate;
    }
}

