namespace Video_Captura_Robos_ESPOL
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cámaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.correosNotificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosManualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envíoDeCorreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirAOneDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.grb_contenido = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_envCorreo = new System.Windows.Forms.Button();
            this.cmb_contenido = new System.Windows.Forms.ComboBox();
            this.pcb_video = new System.Windows.Forms.PictureBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cmb_dispositivos = new System.Windows.Forms.ComboBox();
            this.lblGrabar = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grb_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_video)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.verToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.procesosManualesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturasToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // capturasToolStripMenuItem
            // 
            this.capturasToolStripMenuItem.Name = "capturasToolStripMenuItem";
            this.capturasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.capturasToolStripMenuItem.Text = "Capturas";
            this.capturasToolStripMenuItem.Click += new System.EventHandler(this.capturasToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexionesToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // conexionesToolStripMenuItem
            // 
            this.conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            this.conexionesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.conexionesToolStripMenuItem.Text = "Conexiones";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cámaraToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cámaraToolStripMenuItem
            // 
            this.cámaraToolStripMenuItem.Name = "cámaraToolStripMenuItem";
            this.cámaraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cámaraToolStripMenuItem.Text = "Cámara";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.correosNotificacionesToolStripMenuItem,
            this.excepcionesToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.usuarioToolStripMenuItem.Text = "Registro";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario y Almacenamiento (Nube)";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // correosNotificacionesToolStripMenuItem
            // 
            this.correosNotificacionesToolStripMenuItem.Name = "correosNotificacionesToolStripMenuItem";
            this.correosNotificacionesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.correosNotificacionesToolStripMenuItem.Text = "Correos (Notificaciones)";
            this.correosNotificacionesToolStripMenuItem.Click += new System.EventHandler(this.correosNotificacionesToolStripMenuItem_Click);
            // 
            // excepcionesToolStripMenuItem
            // 
            this.excepcionesToolStripMenuItem.Name = "excepcionesToolStripMenuItem";
            this.excepcionesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.excepcionesToolStripMenuItem.Text = "Excepciones";
            // 
            // procesosManualesToolStripMenuItem
            // 
            this.procesosManualesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envíoDeCorreosToolStripMenuItem,
            this.subirAOneDriveToolStripMenuItem});
            this.procesosManualesToolStripMenuItem.Name = "procesosManualesToolStripMenuItem";
            this.procesosManualesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.procesosManualesToolStripMenuItem.Text = "Procesos Manuales";
            // 
            // envíoDeCorreosToolStripMenuItem
            // 
            this.envíoDeCorreosToolStripMenuItem.Name = "envíoDeCorreosToolStripMenuItem";
            this.envíoDeCorreosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.envíoDeCorreosToolStripMenuItem.Text = "Envío de Correos";
            this.envíoDeCorreosToolStripMenuItem.Click += new System.EventHandler(this.envíoDeCorreosToolStripMenuItem_Click);
            // 
            // subirAOneDriveToolStripMenuItem
            // 
            this.subirAOneDriveToolStripMenuItem.Name = "subirAOneDriveToolStripMenuItem";
            this.subirAOneDriveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.subirAOneDriveToolStripMenuItem.Text = "Subir a OneDrive";
            this.subirAOneDriveToolStripMenuItem.Click += new System.EventHandler(this.subirAOneDriveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.licenciaToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de...";
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(14, 321);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(101, 30);
            this.btn_foto.TabIndex = 2;
            this.btn_foto.Text = "Instantánea";
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(140, 321);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(101, 30);
            this.btn_grabar.TabIndex = 3;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.Location = new System.Drawing.Point(267, 321);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(101, 30);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar Servicio";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Location = new System.Drawing.Point(267, 355);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(101, 30);
            this.btn_detener.TabIndex = 5;
            this.btn_detener.Text = "Detener Servicio";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // grb_contenido
            // 
            this.grb_contenido.Controls.Add(this.txtMensajes);
            this.grb_contenido.Controls.Add(this.btn_eliminar);
            this.grb_contenido.Controls.Add(this.btn_envCorreo);
            this.grb_contenido.Controls.Add(this.cmb_contenido);
            this.grb_contenido.Location = new System.Drawing.Point(382, 36);
            this.grb_contenido.Name = "grb_contenido";
            this.grb_contenido.Size = new System.Drawing.Size(240, 349);
            this.grb_contenido.TabIndex = 6;
            this.grb_contenido.TabStop = false;
            this.grb_contenido.Text = "Contenido";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.trash1;
            this.btn_eliminar.Location = new System.Drawing.Point(184, 310);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 33);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_envCorreo
            // 
            this.btn_envCorreo.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.email1;
            this.btn_envCorreo.Location = new System.Drawing.Point(128, 310);
            this.btn_envCorreo.Name = "btn_envCorreo";
            this.btn_envCorreo.Size = new System.Drawing.Size(50, 33);
            this.btn_envCorreo.TabIndex = 1;
            this.btn_envCorreo.UseVisualStyleBackColor = true;
            // 
            // cmb_contenido
            // 
            this.cmb_contenido.FormattingEnabled = true;
            this.cmb_contenido.Items.AddRange(new object[] {
            "Todo el contenido capturado",
            "Vídeos Capturados",
            "Fotos Capturadas"});
            this.cmb_contenido.Location = new System.Drawing.Point(6, 19);
            this.cmb_contenido.Name = "cmb_contenido";
            this.cmb_contenido.Size = new System.Drawing.Size(227, 21);
            this.cmb_contenido.TabIndex = 0;
            // 
            // pcb_video
            // 
            this.pcb_video.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.offline;
            this.pcb_video.Location = new System.Drawing.Point(14, 36);
            this.pcb_video.Name = "pcb_video";
            this.pcb_video.Size = new System.Drawing.Size(354, 275);
            this.pcb_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_video.TabIndex = 1;
            this.pcb_video.TabStop = false;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(12, 396);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(111, 13);
            this.lblDispositivo.TabIndex = 26;
            this.lblDispositivo.Text = "Dispositivos de Video:";
            // 
            // cmb_dispositivos
            // 
            this.cmb_dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dispositivos.FormattingEnabled = true;
            this.cmb_dispositivos.Location = new System.Drawing.Point(140, 393);
            this.cmb_dispositivos.Name = "cmb_dispositivos";
            this.cmb_dispositivos.Size = new System.Drawing.Size(228, 21);
            this.cmb_dispositivos.TabIndex = 25;
            // 
            // lblGrabar
            // 
            this.lblGrabar.AutoSize = true;
            this.lblGrabar.Location = new System.Drawing.Point(12, 372);
            this.lblGrabar.Name = "lblGrabar";
            this.lblGrabar.Size = new System.Drawing.Size(63, 13);
            this.lblGrabar.TabIndex = 27;
            this.lblGrabar.Text = "Grabando...";
            this.lblGrabar.Visible = false;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(497, 393);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(125, 20);
            this.txt_time.TabIndex = 28;
            this.txt_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMensajes
            // 
            this.txtMensajes.Location = new System.Drawing.Point(6, 63);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.ReadOnly = true;
            this.txtMensajes.Size = new System.Drawing.Size(227, 229);
            this.txtMensajes.TabIndex = 3;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 447);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lblGrabar);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.cmb_dispositivos);
            this.Controls.Add(this.grb_contenido);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.pcb_video);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "Video Captura Robos (Monitoreo Casero)";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_contenido.ResumeLayout(false);
            this.grb_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cámaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem correosNotificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excepcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcb_video;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.GroupBox grb_contenido;
        private System.Windows.Forms.ComboBox cmb_contenido;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_envCorreo;
        private System.Windows.Forms.ToolStripMenuItem procesosManualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envíoDeCorreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirAOneDriveToolStripMenuItem;
        internal System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cmb_dispositivos;
        private System.Windows.Forms.Label lblGrabar;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMensajes;
    }
}

