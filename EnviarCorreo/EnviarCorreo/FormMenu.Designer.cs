namespace EnviarCorreo
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.pct_seguridad = new System.Windows.Forms.PictureBox();
            this.pct_email = new System.Windows.Forms.PictureBox();
            this.lbl_registroEmail = new System.Windows.Forms.Label();
            this.lbl_envioEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_seguridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_email)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Location = new System.Drawing.Point(21, 17);
            this.lbl_bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(438, 15);
            this.lbl_bienvenida.TabIndex = 0;
            this.lbl_bienvenida.Text = "Bienvenido Alex, al menú de configuración de correos electrónicos.";
            // 
            // pct_seguridad
            // 
            this.pct_seguridad.BackColor = System.Drawing.Color.Transparent;
            this.pct_seguridad.Image = global::EnviarCorreo.Properties.Resources.seguridad;
            this.pct_seguridad.Location = new System.Drawing.Point(127, 41);
            this.pct_seguridad.Name = "pct_seguridad";
            this.pct_seguridad.Size = new System.Drawing.Size(80, 80);
            this.pct_seguridad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pct_seguridad.TabIndex = 1;
            this.pct_seguridad.TabStop = false;
            // 
            // pct_email
            // 
            this.pct_email.BackColor = System.Drawing.Color.Transparent;
            this.pct_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_email.Image = global::EnviarCorreo.Properties.Resources.email;
            this.pct_email.Location = new System.Drawing.Point(291, 41);
            this.pct_email.Name = "pct_email";
            this.pct_email.Size = new System.Drawing.Size(80, 80);
            this.pct_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pct_email.TabIndex = 2;
            this.pct_email.TabStop = false;
            // 
            // lbl_registroEmail
            // 
            this.lbl_registroEmail.AutoSize = true;
            this.lbl_registroEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_registroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registroEmail.Location = new System.Drawing.Point(129, 165);
            this.lbl_registroEmail.Name = "lbl_registroEmail";
            this.lbl_registroEmail.Size = new System.Drawing.Size(242, 20);
            this.lbl_registroEmail.TabIndex = 3;
            this.lbl_registroEmail.Text = "Registro de Correos Electrónicos";
            this.lbl_registroEmail.Click += new System.EventHandler(this.lbl_registroEmail_Click);
            // 
            // lbl_envioEmail
            // 
            this.lbl_envioEmail.AutoSize = true;
            this.lbl_envioEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_envioEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_envioEmail.Location = new System.Drawing.Point(139, 211);
            this.lbl_envioEmail.Name = "lbl_envioEmail";
            this.lbl_envioEmail.Size = new System.Drawing.Size(221, 20);
            this.lbl_envioEmail.TabIndex = 4;
            this.lbl_envioEmail.Text = "Envio de Correos Electrónicos";
            this.lbl_envioEmail.Click += new System.EventHandler(this.lbl_envioEmail_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnviarCorreo.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 302);
            this.Controls.Add(this.lbl_envioEmail);
            this.Controls.Add(this.lbl_registroEmail);
            this.Controls.Add(this.pct_email);
            this.Controls.Add(this.pct_seguridad);
            this.Controls.Add(this.lbl_bienvenida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMenu";
            this.Text = "Menú de Envío de Correos";
            ((System.ComponentModel.ISupportInitialize)(this.pct_seguridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.PictureBox pct_seguridad;
        private System.Windows.Forms.PictureBox pct_email;
        private System.Windows.Forms.Label lbl_registroEmail;
        private System.Windows.Forms.Label lbl_envioEmail;
    }
}