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
            this.pct_dropBox = new System.Windows.Forms.PictureBox();
            this.pct_oneDrive = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grb_oneDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_dropBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_oneDrive)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_registroCtas
            // 
            this.lbl_registroCtas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registroCtas.Location = new System.Drawing.Point(18, 9);
            this.lbl_registroCtas.Name = "lbl_registroCtas";
            this.lbl_registroCtas.Size = new System.Drawing.Size(274, 58);
            this.lbl_registroCtas.TabIndex = 0;
            this.lbl_registroCtas.Text = "Estimado usuario, bienvenido al registro/edición de sus cuentas de almacenamiento" +
    " en la nube.\r\n";
            this.lbl_registroCtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grb_oneDrive
            // 
            this.grb_oneDrive.Controls.Add(this.pct_dropBox);
            this.grb_oneDrive.Controls.Add(this.pct_oneDrive);
            this.grb_oneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_oneDrive.Location = new System.Drawing.Point(15, 89);
            this.grb_oneDrive.Name = "grb_oneDrive";
            this.grb_oneDrive.Size = new System.Drawing.Size(271, 88);
            this.grb_oneDrive.TabIndex = 3;
            this.grb_oneDrive.TabStop = false;
            this.grb_oneDrive.Text = "Seleccione su cuenta a configurar";
            // 
            // pct_dropBox
            // 
            this.pct_dropBox.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.dropBox1;
            this.pct_dropBox.Location = new System.Drawing.Point(175, 19);
            this.pct_dropBox.Name = "pct_dropBox";
            this.pct_dropBox.Size = new System.Drawing.Size(59, 58);
            this.pct_dropBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_dropBox.TabIndex = 2;
            this.pct_dropBox.TabStop = false;
            this.pct_dropBox.Click += new System.EventHandler(this.pct_dropBox_Click);
            // 
            // pct_oneDrive
            // 
            this.pct_oneDrive.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.oneDrive;
            this.pct_oneDrive.Location = new System.Drawing.Point(41, 19);
            this.pct_oneDrive.Name = "pct_oneDrive";
            this.pct_oneDrive.Size = new System.Drawing.Size(59, 58);
            this.pct_oneDrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_oneDrive.TabIndex = 1;
            this.pct_oneDrive.TabStop = false;
            this.pct_oneDrive.Click += new System.EventHandler(this.pct_oneDrive_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.OK2;
            this.btn_guardar.Location = new System.Drawing.Point(256, 192);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(30, 30);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_registroCtasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 239);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.grb_oneDrive);
            this.Controls.Add(this.lbl_registroCtas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_registroCtasUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cuentas de Usuario";
            this.Load += new System.EventHandler(this.frm_registroCtasUsuario_Load);
            this.grb_oneDrive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_dropBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_oneDrive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_registroCtas;
        private System.Windows.Forms.PictureBox pct_oneDrive;
        private System.Windows.Forms.PictureBox pct_dropBox;
        private System.Windows.Forms.GroupBox grb_oneDrive;
        private System.Windows.Forms.Button btn_guardar;
    }
}