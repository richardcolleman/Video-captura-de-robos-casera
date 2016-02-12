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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosManualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envíoDeCorreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirAOneDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.grb_contenido = new System.Windows.Forms.GroupBox();
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cmb_dispositivos = new System.Windows.Forms.ComboBox();
            this.lblGrabar = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcb_video = new System.Windows.Forms.PictureBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.grb_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_video)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.verToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.toolStripMenuItem1,
            this.procesosManualesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 25);
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
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_inicio;
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_fin;
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturasToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // capturasToolStripMenuItem
            // 
            this.capturasToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_capturas;
            this.capturasToolStripMenuItem.Name = "capturasToolStripMenuItem";
            this.capturasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.capturasToolStripMenuItem.Text = "Capturas";
            this.capturasToolStripMenuItem.Click += new System.EventHandler(this.capturasToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexionesToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.historialToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_log;
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // conexionesToolStripMenuItem
            // 
            this.conexionesToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_login;
            this.conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            this.conexionesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.conexionesToolStripMenuItem.Text = "Conexiones";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_alertas;
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cámaraToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cámaraToolStripMenuItem
            // 
            this.cámaraToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_camara;
            this.cámaraToolStripMenuItem.Name = "cámaraToolStripMenuItem";
            this.cámaraToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cámaraToolStripMenuItem.Text = "Cámara";
            this.cámaraToolStripMenuItem.Click += new System.EventHandler(this.cámaraToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.correosNotificacionesToolStripMenuItem,
            this.excepcionesToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.reg;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.usuarioToolStripMenuItem.Text = "Registro";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.nube;
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(284, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario y Almacenamiento (Nube)";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // correosNotificacionesToolStripMenuItem
            // 
            this.correosNotificacionesToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.correos2;
            this.correosNotificacionesToolStripMenuItem.Name = "correosNotificacionesToolStripMenuItem";
            this.correosNotificacionesToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.correosNotificacionesToolStripMenuItem.Text = "Correos (Notificaciones)";
            this.correosNotificacionesToolStripMenuItem.Click += new System.EventHandler(this.correosNotificacionesToolStripMenuItem_Click);
            // 
            // excepcionesToolStripMenuItem
            // 
            this.excepcionesToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_excep;
            this.excepcionesToolStripMenuItem.Name = "excepcionesToolStripMenuItem";
            this.excepcionesToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.excepcionesToolStripMenuItem.Text = "Excepciones";
            this.excepcionesToolStripMenuItem.Click += new System.EventHandler(this.excepcionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 21);
            this.toolStripMenuItem1.Text = "?";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_manual;
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.menu_info;
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.acerdaDeToolStripMenuItem.Text = "Acerca de...";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // procesosManualesToolStripMenuItem
            // 
            this.procesosManualesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envíoDeCorreosToolStripMenuItem,
            this.subirAOneDriveToolStripMenuItem});
            this.procesosManualesToolStripMenuItem.Name = "procesosManualesToolStripMenuItem";
            this.procesosManualesToolStripMenuItem.Size = new System.Drawing.Size(136, 21);
            this.procesosManualesToolStripMenuItem.Text = "Procesos Manuales";
            // 
            // envíoDeCorreosToolStripMenuItem
            // 
            this.envíoDeCorreosToolStripMenuItem.Name = "envíoDeCorreosToolStripMenuItem";
            this.envíoDeCorreosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.envíoDeCorreosToolStripMenuItem.Text = "Envío de Correos";
            this.envíoDeCorreosToolStripMenuItem.Click += new System.EventHandler(this.envíoDeCorreosToolStripMenuItem_Click);
            // 
            // subirAOneDriveToolStripMenuItem
            // 
            this.subirAOneDriveToolStripMenuItem.Name = "subirAOneDriveToolStripMenuItem";
            this.subirAOneDriveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.subirAOneDriveToolStripMenuItem.Text = "Subir a OneDrive";
            this.subirAOneDriveToolStripMenuItem.Click += new System.EventHandler(this.subirAOneDriveToolStripMenuItem_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.form_rec;
            this.btn_iniciar.Location = new System.Drawing.Point(280, 390);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(40, 40);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.form_stop;
            this.btn_detener.Location = new System.Drawing.Point(326, 390);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(40, 40);
            this.btn_detener.TabIndex = 5;
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // grb_contenido
            // 
            this.grb_contenido.BackColor = System.Drawing.Color.Transparent;
            this.grb_contenido.Controls.Add(this.txtMensajes);
            this.grb_contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_contenido.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grb_contenido.Location = new System.Drawing.Point(372, 183);
            this.grb_contenido.Name = "grb_contenido";
            this.grb_contenido.Size = new System.Drawing.Size(256, 201);
            this.grb_contenido.TabIndex = 6;
            this.grb_contenido.TabStop = false;
            this.grb_contenido.Text = "Log de Eventos";
            // 
            // txtMensajes
            // 
            this.txtMensajes.AcceptsReturn = true;
            this.txtMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajes.Location = new System.Drawing.Point(6, 21);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.ReadOnly = true;
            this.txtMensajes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensajes.Size = new System.Drawing.Size(244, 174);
            this.txtMensajes.TabIndex = 3;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDispositivo.Location = new System.Drawing.Point(12, 366);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(165, 16);
            this.lblDispositivo.TabIndex = 26;
            this.lblDispositivo.Text = "Dispositivos de Video:";
            // 
            // cmb_dispositivos
            // 
            this.cmb_dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dispositivos.FormattingEnabled = true;
            this.cmb_dispositivos.Location = new System.Drawing.Point(183, 363);
            this.cmb_dispositivos.Name = "cmb_dispositivos";
            this.cmb_dispositivos.Size = new System.Drawing.Size(183, 21);
            this.cmb_dispositivos.TabIndex = 25;
            // 
            // lblGrabar
            // 
            this.lblGrabar.AutoSize = true;
            this.lblGrabar.BackColor = System.Drawing.Color.Transparent;
            this.lblGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrabar.ForeColor = System.Drawing.Color.Red;
            this.lblGrabar.Location = new System.Drawing.Point(374, 399);
            this.lblGrabar.Name = "lblGrabar";
            this.lblGrabar.Size = new System.Drawing.Size(104, 20);
            this.lblGrabar.TabIndex = 27;
            this.lblGrabar.Text = "Grabando...";
            this.lblGrabar.Visible = false;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(534, 157);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(88, 20);
            this.txt_time.TabIndex = 28;
            this.txt_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcb_video
            // 
            this.pcb_video.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.offline;
            this.pcb_video.InitialImage = global::Video_Captura_Robos_ESPOL.Properties.Resources.offline;
            this.pcb_video.Location = new System.Drawing.Point(12, 75);
            this.pcb_video.Name = "pcb_video";
            this.pcb_video.Size = new System.Drawing.Size(354, 279);
            this.pcb_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_video.TabIndex = 1;
            this.pcb_video.TabStop = false;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblServicio.Location = new System.Drawing.Point(12, 403);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(173, 16);
            this.lblServicio.TabIndex = 29;
            this.lblServicio.Text = "El servicio iniciará en ...";
            this.lblServicio.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Video_Captura_Robos_ESPOL.Properties.Resources.fondo_principal;
            this.ClientSize = new System.Drawing.Size(639, 482);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lblGrabar);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.cmb_dispositivos);
            this.Controls.Add(this.grb_contenido);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.pcb_video);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema para video-captura de robos en pymes y hogares";
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
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcb_video;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.GroupBox grb_contenido;
        private System.Windows.Forms.ToolStripMenuItem procesosManualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envíoDeCorreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirAOneDriveToolStripMenuItem;
        internal System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cmb_dispositivos;
        private System.Windows.Forms.Label lblGrabar;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMensajes;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Timer timer2;
    }
}

