namespace Video_Captura_Robos_ESPOL
{
    partial class frm_registroCtasUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registroCtasUsuario));
            this.lbl_registroCtas = new System.Windows.Forms.Label();
            this.grb_oneDrive = new System.Windows.Forms.GroupBox();
            this.grb_dropbox = new System.Windows.Forms.GroupBox();
            this.lbl_correoOnedrive = new System.Windows.Forms.Label();
            this.lbl_passOnedrive = new System.Windows.Forms.Label();
            this.txt_correoOnedrive = new System.Windows.Forms.TextBox();
            this.txt_passOnedrive = new System.Windows.Forms.TextBox();
            this.txt_passDropbox = new System.Windows.Forms.TextBox();
            this.txt_correoDropbox = new System.Windows.Forms.TextBox();
            this.lbl_passDropbox = new System.Windows.Forms.Label();
            this.lbl_correoDropbox = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pct_errorOnedrive = new System.Windows.Forms.PictureBox();
            this.pct_okOnedrive = new System.Windows.Forms.PictureBox();
            this.pct_dropBox = new System.Windows.Forms.PictureBox();
            this.pct_oneDrive = new System.Windows.Forms.PictureBox();
            this.pct_errorDropbox = new System.Windows.Forms.PictureBox();
            this.pct_okDropbox = new System.Windows.Forms.PictureBox();
            this.lbl_mostrarOnedrive = new System.Windows.Forms.Label();
            this.lbl_mostrarDropbox = new System.Windows.Forms.Label();
            this.grb_oneDrive.SuspendLayout();
            this.grb_dropbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_errorOnedrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_okOnedrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_dropBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_oneDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_errorDropbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_okDropbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_registroCtas
            // 
            this.lbl_registroCtas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registroCtas.Location = new System.Drawing.Point(12, 9);
            this.lbl_registroCtas.Name = "lbl_registroCtas";
            this.lbl_registroCtas.Size = new System.Drawing.Size(274, 58);
            this.lbl_registroCtas.TabIndex = 0;
            this.lbl_registroCtas.Text = "Estimado usuario, bienvenido al registro/edición de sus cuentas de almacenamiento" +
    " en la nube.\r\n";
            this.lbl_registroCtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grb_oneDrive
            // 
            this.grb_oneDrive.Controls.Add(this.lbl_mostrarOnedrive);
            this.grb_oneDrive.Controls.Add(this.pct_errorOnedrive);
            this.grb_oneDrive.Controls.Add(this.pct_okOnedrive);
            this.grb_oneDrive.Controls.Add(this.txt_passOnedrive);
            this.grb_oneDrive.Controls.Add(this.txt_correoOnedrive);
            this.grb_oneDrive.Controls.Add(this.lbl_passOnedrive);
            this.grb_oneDrive.Controls.Add(this.lbl_correoOnedrive);
            this.grb_oneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_oneDrive.Location = new System.Drawing.Point(15, 89);
            this.grb_oneDrive.Name = "grb_oneDrive";
            this.grb_oneDrive.Size = new System.Drawing.Size(394, 88);
            this.grb_oneDrive.TabIndex = 3;
            this.grb_oneDrive.TabStop = false;
            this.grb_oneDrive.Text = "OneDrive";
            // 
            // grb_dropbox
            // 
            this.grb_dropbox.Controls.Add(this.lbl_mostrarDropbox);
            this.grb_dropbox.Controls.Add(this.pct_errorDropbox);
            this.grb_dropbox.Controls.Add(this.pct_okDropbox);
            this.grb_dropbox.Controls.Add(this.txt_passDropbox);
            this.grb_dropbox.Controls.Add(this.txt_correoDropbox);
            this.grb_dropbox.Controls.Add(this.lbl_correoDropbox);
            this.grb_dropbox.Controls.Add(this.lbl_passDropbox);
            this.grb_dropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dropbox.Location = new System.Drawing.Point(15, 183);
            this.grb_dropbox.Name = "grb_dropbox";
            this.grb_dropbox.Size = new System.Drawing.Size(394, 88);
            this.grb_dropbox.TabIndex = 4;
            this.grb_dropbox.TabStop = false;
            this.grb_dropbox.Text = "Dropbox";
            // 
            // lbl_correoOnedrive
            // 
            this.lbl_correoOnedrive.AutoSize = true;
            this.lbl_correoOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correoOnedrive.Location = new System.Drawing.Point(9, 26);
            this.lbl_correoOnedrive.Name = "lbl_correoOnedrive";
            this.lbl_correoOnedrive.Size = new System.Drawing.Size(97, 13);
            this.lbl_correoOnedrive.TabIndex = 0;
            this.lbl_correoOnedrive.Text = "Correo Electrónico:";
            // 
            // lbl_passOnedrive
            // 
            this.lbl_passOnedrive.AutoSize = true;
            this.lbl_passOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passOnedrive.Location = new System.Drawing.Point(9, 59);
            this.lbl_passOnedrive.Name = "lbl_passOnedrive";
            this.lbl_passOnedrive.Size = new System.Drawing.Size(64, 13);
            this.lbl_passOnedrive.TabIndex = 1;
            this.lbl_passOnedrive.Text = "Contraseña:";
            // 
            // txt_correoOnedrive
            // 
            this.txt_correoOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correoOnedrive.Location = new System.Drawing.Point(112, 23);
            this.txt_correoOnedrive.Name = "txt_correoOnedrive";
            this.txt_correoOnedrive.Size = new System.Drawing.Size(215, 20);
            this.txt_correoOnedrive.TabIndex = 2;
            this.txt_correoOnedrive.TextChanged += new System.EventHandler(this.txt_correoOnedrive_TextChanged);
            this.txt_correoOnedrive.Leave += new System.EventHandler(this.txt_correoOnedrive_Leave);
            // 
            // txt_passOnedrive
            // 
            this.txt_passOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passOnedrive.Location = new System.Drawing.Point(112, 56);
            this.txt_passOnedrive.Name = "txt_passOnedrive";
            this.txt_passOnedrive.PasswordChar = '*';
            this.txt_passOnedrive.Size = new System.Drawing.Size(215, 20);
            this.txt_passOnedrive.TabIndex = 3;
            this.txt_passOnedrive.TextChanged += new System.EventHandler(this.txt_passOnedrive_TextChanged);
            this.txt_passOnedrive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passOnedrive_KeyPress);
            // 
            // txt_passDropbox
            // 
            this.txt_passDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passDropbox.Location = new System.Drawing.Point(112, 52);
            this.txt_passDropbox.Name = "txt_passDropbox";
            this.txt_passDropbox.PasswordChar = '*';
            this.txt_passDropbox.Size = new System.Drawing.Size(215, 20);
            this.txt_passDropbox.TabIndex = 7;
            this.txt_passDropbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passDropbox_KeyPress);
            // 
            // txt_correoDropbox
            // 
            this.txt_correoDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correoDropbox.Location = new System.Drawing.Point(112, 19);
            this.txt_correoDropbox.Name = "txt_correoDropbox";
            this.txt_correoDropbox.Size = new System.Drawing.Size(215, 20);
            this.txt_correoDropbox.TabIndex = 6;
            this.txt_correoDropbox.Leave += new System.EventHandler(this.txt_correoDropbox_Leave);
            // 
            // lbl_passDropbox
            // 
            this.lbl_passDropbox.AutoSize = true;
            this.lbl_passDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passDropbox.Location = new System.Drawing.Point(9, 55);
            this.lbl_passDropbox.Name = "lbl_passDropbox";
            this.lbl_passDropbox.Size = new System.Drawing.Size(64, 13);
            this.lbl_passDropbox.TabIndex = 5;
            this.lbl_passDropbox.Text = "Contraseña:";
            // 
            // lbl_correoDropbox
            // 
            this.lbl_correoDropbox.AutoSize = true;
            this.lbl_correoDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correoDropbox.Location = new System.Drawing.Point(9, 22);
            this.lbl_correoDropbox.Name = "lbl_correoDropbox";
            this.lbl_correoDropbox.Size = new System.Drawing.Size(97, 13);
            this.lbl_correoDropbox.TabIndex = 4;
            this.lbl_correoDropbox.Text = "Correo Electrónico:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(313, 277);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(96, 29);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pct_errorOnedrive
            // 
            this.pct_errorOnedrive.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.error;
            this.pct_errorOnedrive.Location = new System.Drawing.Point(335, 23);
            this.pct_errorOnedrive.Name = "pct_errorOnedrive";
            this.pct_errorOnedrive.Size = new System.Drawing.Size(20, 20);
            this.pct_errorOnedrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_errorOnedrive.TabIndex = 5;
            this.pct_errorOnedrive.TabStop = false;
            this.pct_errorOnedrive.Visible = false;
            // 
            // pct_okOnedrive
            // 
            this.pct_okOnedrive.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.ok;
            this.pct_okOnedrive.Location = new System.Drawing.Point(334, 23);
            this.pct_okOnedrive.Name = "pct_okOnedrive";
            this.pct_okOnedrive.Size = new System.Drawing.Size(20, 20);
            this.pct_okOnedrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_okOnedrive.TabIndex = 4;
            this.pct_okOnedrive.TabStop = false;
            this.pct_okOnedrive.Visible = false;
            // 
            // pct_dropBox
            // 
            this.pct_dropBox.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.dropBox1;
            this.pct_dropBox.Location = new System.Drawing.Point(350, 9);
            this.pct_dropBox.Name = "pct_dropBox";
            this.pct_dropBox.Size = new System.Drawing.Size(59, 58);
            this.pct_dropBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_dropBox.TabIndex = 2;
            this.pct_dropBox.TabStop = false;
            // 
            // pct_oneDrive
            // 
            this.pct_oneDrive.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.oneDrive;
            this.pct_oneDrive.Location = new System.Drawing.Point(283, 9);
            this.pct_oneDrive.Name = "pct_oneDrive";
            this.pct_oneDrive.Size = new System.Drawing.Size(59, 58);
            this.pct_oneDrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_oneDrive.TabIndex = 1;
            this.pct_oneDrive.TabStop = false;
            // 
            // pct_errorDropbox
            // 
            this.pct_errorDropbox.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.error;
            this.pct_errorDropbox.Location = new System.Drawing.Point(334, 19);
            this.pct_errorDropbox.Name = "pct_errorDropbox";
            this.pct_errorDropbox.Size = new System.Drawing.Size(20, 20);
            this.pct_errorDropbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_errorDropbox.TabIndex = 7;
            this.pct_errorDropbox.TabStop = false;
            this.pct_errorDropbox.Visible = false;
            // 
            // pct_okDropbox
            // 
            this.pct_okDropbox.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.ok;
            this.pct_okDropbox.Location = new System.Drawing.Point(334, 19);
            this.pct_okDropbox.Name = "pct_okDropbox";
            this.pct_okDropbox.Size = new System.Drawing.Size(20, 20);
            this.pct_okDropbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_okDropbox.TabIndex = 6;
            this.pct_okDropbox.TabStop = false;
            this.pct_okDropbox.Visible = false;
            // 
            // lbl_mostrarOnedrive
            // 
            this.lbl_mostrarOnedrive.AutoSize = true;
            this.lbl_mostrarOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrarOnedrive.Location = new System.Drawing.Point(331, 59);
            this.lbl_mostrarOnedrive.Name = "lbl_mostrarOnedrive";
            this.lbl_mostrarOnedrive.Size = new System.Drawing.Size(42, 13);
            this.lbl_mostrarOnedrive.TabIndex = 6;
            this.lbl_mostrarOnedrive.Text = "Mostrar";
            this.lbl_mostrarOnedrive.Visible = false;
            this.lbl_mostrarOnedrive.Click += new System.EventHandler(this.lbl_mostrarOnedrive_Click);
            // 
            // lbl_mostrarDropbox
            // 
            this.lbl_mostrarDropbox.AutoSize = true;
            this.lbl_mostrarDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrarDropbox.Location = new System.Drawing.Point(331, 55);
            this.lbl_mostrarDropbox.Name = "lbl_mostrarDropbox";
            this.lbl_mostrarDropbox.Size = new System.Drawing.Size(42, 13);
            this.lbl_mostrarDropbox.TabIndex = 7;
            this.lbl_mostrarDropbox.Text = "Mostrar";
            this.lbl_mostrarDropbox.Visible = false;
            this.lbl_mostrarDropbox.Click += new System.EventHandler(this.lbl_mostrarDropbox_Click);
            // 
            // frm_registroCtasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 316);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.grb_dropbox);
            this.Controls.Add(this.grb_oneDrive);
            this.Controls.Add(this.pct_dropBox);
            this.Controls.Add(this.pct_oneDrive);
            this.Controls.Add(this.lbl_registroCtas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registroCtasUsuario";
            this.Text = "Registro Cuentas de Usuario";
            this.Load += new System.EventHandler(this.frm_registroCtasUsuario_Load);
            this.grb_oneDrive.ResumeLayout(false);
            this.grb_oneDrive.PerformLayout();
            this.grb_dropbox.ResumeLayout(false);
            this.grb_dropbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_errorOnedrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_okOnedrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_dropBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_oneDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_errorDropbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_okDropbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_registroCtas;
        private System.Windows.Forms.PictureBox pct_oneDrive;
        private System.Windows.Forms.PictureBox pct_dropBox;
        private System.Windows.Forms.GroupBox grb_oneDrive;
        private System.Windows.Forms.TextBox txt_correoOnedrive;
        private System.Windows.Forms.Label lbl_passOnedrive;
        private System.Windows.Forms.Label lbl_correoOnedrive;
        private System.Windows.Forms.GroupBox grb_dropbox;
        private System.Windows.Forms.TextBox txt_passOnedrive;
        private System.Windows.Forms.TextBox txt_passDropbox;
        private System.Windows.Forms.TextBox txt_correoDropbox;
        private System.Windows.Forms.Label lbl_correoDropbox;
        private System.Windows.Forms.Label lbl_passDropbox;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.PictureBox pct_errorOnedrive;
        private System.Windows.Forms.PictureBox pct_okOnedrive;
        private System.Windows.Forms.Label lbl_mostrarOnedrive;
        private System.Windows.Forms.Label lbl_mostrarDropbox;
        private System.Windows.Forms.PictureBox pct_errorDropbox;
        private System.Windows.Forms.PictureBox pct_okDropbox;
    }
}