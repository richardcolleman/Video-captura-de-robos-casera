namespace Video_Captura_Robos_ESPOL
{
    partial class frm_EnvioCorreos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EnvioCorreos));
            this.grb_envioCorreo = new System.Windows.Forms.GroupBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.rtxt_mensaje = new System.Windows.Forms.RichTextBox();
            this.txt_adjunto = new System.Windows.Forms.TextBox();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.txt_destinatarios = new System.Windows.Forms.TextBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.lbl_adjunto = new System.Windows.Forms.Label();
            this.lbl_asunto = new System.Windows.Forms.Label();
            this.lbl_destinatarios = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_envioCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_envioCorreo
            // 
            this.grb_envioCorreo.Controls.Add(this.btn_examinar);
            this.grb_envioCorreo.Controls.Add(this.rtxt_mensaje);
            this.grb_envioCorreo.Controls.Add(this.txt_adjunto);
            this.grb_envioCorreo.Controls.Add(this.txt_asunto);
            this.grb_envioCorreo.Controls.Add(this.txt_destinatarios);
            this.grb_envioCorreo.Controls.Add(this.lbl_mensaje);
            this.grb_envioCorreo.Controls.Add(this.lbl_adjunto);
            this.grb_envioCorreo.Controls.Add(this.lbl_asunto);
            this.grb_envioCorreo.Controls.Add(this.lbl_destinatarios);
            this.grb_envioCorreo.Location = new System.Drawing.Point(10, 16);
            this.grb_envioCorreo.Name = "grb_envioCorreo";
            this.grb_envioCorreo.Size = new System.Drawing.Size(401, 250);
            this.grb_envioCorreo.TabIndex = 0;
            this.grb_envioCorreo.TabStop = false;
            this.grb_envioCorreo.Text = "Correo Electrónico - Nuevo Mensaje";
            // 
            // btn_examinar
            // 
            this.btn_examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar.Location = new System.Drawing.Point(359, 73);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(35, 20);
            this.btn_examinar.TabIndex = 8;
            this.btn_examinar.Text = "...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // rtxt_mensaje
            // 
            this.rtxt_mensaje.Location = new System.Drawing.Point(101, 101);
            this.rtxt_mensaje.Name = "rtxt_mensaje";
            this.rtxt_mensaje.Size = new System.Drawing.Size(294, 143);
            this.rtxt_mensaje.TabIndex = 7;
            this.rtxt_mensaje.Text = resources.GetString("rtxt_mensaje.Text");
            // 
            // txt_adjunto
            // 
            this.txt_adjunto.Location = new System.Drawing.Point(101, 74);
            this.txt_adjunto.Name = "txt_adjunto";
            this.txt_adjunto.Size = new System.Drawing.Size(252, 20);
            this.txt_adjunto.TabIndex = 6;
            this.txt_adjunto.Text = "C:\\captura.png";
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(101, 48);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(294, 20);
            this.txt_asunto.TabIndex = 5;
            this.txt_asunto.Text = "ALERTA - Sistema de Seguridad ha detectado movimiento";
            // 
            // txt_destinatarios
            // 
            this.txt_destinatarios.Enabled = false;
            this.txt_destinatarios.Location = new System.Drawing.Point(101, 23);
            this.txt_destinatarios.Name = "txt_destinatarios";
            this.txt_destinatarios.Size = new System.Drawing.Size(294, 20);
            this.txt_destinatarios.TabIndex = 4;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(6, 103);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(50, 13);
            this.lbl_mensaje.TabIndex = 3;
            this.lbl_mensaje.Text = "Mensaje:";
            // 
            // lbl_adjunto
            // 
            this.lbl_adjunto.AutoSize = true;
            this.lbl_adjunto.Location = new System.Drawing.Point(6, 77);
            this.lbl_adjunto.Name = "lbl_adjunto";
            this.lbl_adjunto.Size = new System.Drawing.Size(87, 13);
            this.lbl_adjunto.TabIndex = 2;
            this.lbl_adjunto.Text = "Adjuntar archivo:";
            // 
            // lbl_asunto
            // 
            this.lbl_asunto.AutoSize = true;
            this.lbl_asunto.Location = new System.Drawing.Point(6, 51);
            this.lbl_asunto.Name = "lbl_asunto";
            this.lbl_asunto.Size = new System.Drawing.Size(43, 13);
            this.lbl_asunto.TabIndex = 1;
            this.lbl_asunto.Text = "Asunto:";
            // 
            // lbl_destinatarios
            // 
            this.lbl_destinatarios.AutoSize = true;
            this.lbl_destinatarios.Location = new System.Drawing.Point(6, 26);
            this.lbl_destinatarios.Name = "lbl_destinatarios";
            this.lbl_destinatarios.Size = new System.Drawing.Size(71, 13);
            this.lbl_destinatarios.TabIndex = 0;
            this.lbl_destinatarios.Text = "Destinatarios:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(309, 275);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(96, 29);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_EnvioCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 316);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.grb_envioCorreo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EnvioCorreos";
            this.Text = "Envío de Notificaciones por Correo";
            this.Load += new System.EventHandler(this.frm_EnvioCorreos_Load);
            this.grb_envioCorreo.ResumeLayout(false);
            this.grb_envioCorreo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_envioCorreo;
        private System.Windows.Forms.TextBox txt_adjunto;
        private System.Windows.Forms.TextBox txt_asunto;
        private System.Windows.Forms.TextBox txt_destinatarios;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Label lbl_adjunto;
        private System.Windows.Forms.Label lbl_asunto;
        private System.Windows.Forms.Label lbl_destinatarios;
        private System.Windows.Forms.RichTextBox rtxt_mensaje;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}