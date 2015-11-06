namespace googleDriveConexion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btm_verificar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.lbl_mostrarcontrasena = new System.Windows.Forms.Label();
            this.pct_google = new System.Windows.Forms.PictureBox();
            this.pct_onedrive = new System.Windows.Forms.PictureBox();
            this.btn_comprobar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_google)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_onedrive)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(15, 47);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(124, 13);
            this.lbl_correo.TabIndex = 0;
            this.lbl_correo.Text = "Correo de la Cuenta:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(15, 70);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(75, 13);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(141, 47);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(251, 20);
            this.txt_correo.TabIndex = 2;
            this.txt_correo.Text = "alexcerv17@gmail.com";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(141, 70);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(251, 20);
            this.txt_contrasena.TabIndex = 3;
            this.txt_contrasena.Text = "alexcerv22";
            this.txt_contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contrasena_KeyPress);
            // 
            // btm_verificar
            // 
            this.btm_verificar.Location = new System.Drawing.Point(141, 116);
            this.btm_verificar.Name = "btm_verificar";
            this.btm_verificar.Size = new System.Drawing.Size(110, 30);
            this.btm_verificar.TabIndex = 4;
            this.btm_verificar.Text = "Verificar Correo";
            this.btm_verificar.UseVisualStyleBackColor = true;
            this.btm_verificar.Click += new System.EventHandler(this.btm_verificar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Enabled = false;
            this.btn_registrar.Location = new System.Drawing.Point(289, 116);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(103, 30);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenida.Location = new System.Drawing.Point(12, 13);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(395, 15);
            this.lbl_bienvenida.TabIndex = 6;
            this.lbl_bienvenida.Text = "Bienvenido Alex, a la configuración de sus cuentas de almacenamiento";
            // 
            // lbl_mostrarcontrasena
            // 
            this.lbl_mostrarcontrasena.AutoSize = true;
            this.lbl_mostrarcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mostrarcontrasena.Location = new System.Drawing.Point(398, 73);
            this.lbl_mostrarcontrasena.Name = "lbl_mostrarcontrasena";
            this.lbl_mostrarcontrasena.Size = new System.Drawing.Size(99, 13);
            this.lbl_mostrarcontrasena.TabIndex = 7;
            this.lbl_mostrarcontrasena.Text = "Mostrar Contraseña";
            this.lbl_mostrarcontrasena.Visible = false;
            this.lbl_mostrarcontrasena.Click += new System.EventHandler(this.lbl_mostrarcontrasena_Click);
            // 
            // pct_google
            // 
            this.pct_google.Image = global::googleDriveConexion.Properties.Resources.google;
            this.pct_google.Location = new System.Drawing.Point(389, 173);
            this.pct_google.Name = "pct_google";
            this.pct_google.Size = new System.Drawing.Size(50, 50);
            this.pct_google.TabIndex = 8;
            this.pct_google.TabStop = false;
            // 
            // pct_onedrive
            // 
            this.pct_onedrive.Image = global::googleDriveConexion.Properties.Resources.onedrive;
            this.pct_onedrive.Location = new System.Drawing.Point(445, 173);
            this.pct_onedrive.Name = "pct_onedrive";
            this.pct_onedrive.Size = new System.Drawing.Size(50, 50);
            this.pct_onedrive.TabIndex = 9;
            this.pct_onedrive.TabStop = false;
            // 
            // btn_comprobar
            // 
            this.btn_comprobar.Enabled = false;
            this.btn_comprobar.Location = new System.Drawing.Point(211, 175);
            this.btn_comprobar.Name = "btn_comprobar";
            this.btn_comprobar.Size = new System.Drawing.Size(107, 35);
            this.btn_comprobar.TabIndex = 10;
            this.btn_comprobar.Text = "Comprobar Conexión";
            this.btn_comprobar.UseVisualStyleBackColor = true;
            this.btn_comprobar.Click += new System.EventHandler(this.btn_comprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::googleDriveConexion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 222);
            this.Controls.Add(this.btn_comprobar);
            this.Controls.Add(this.pct_onedrive);
            this.Controls.Add(this.pct_google);
            this.Controls.Add(this.lbl_mostrarcontrasena);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btm_verificar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_correo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ingreso Cuentas de Almacenamiento en la Nube";
            ((System.ComponentModel.ISupportInitialize)(this.pct_google)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_onedrive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Button btm_verificar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Label lbl_mostrarcontrasena;
        private System.Windows.Forms.PictureBox pct_google;
        private System.Windows.Forms.PictureBox pct_onedrive;
        private System.Windows.Forms.Button btn_comprobar;
    }
}

