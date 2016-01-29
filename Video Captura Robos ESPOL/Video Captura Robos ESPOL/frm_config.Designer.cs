namespace Video_Captura_Robos_ESPOL
{
    partial class frm_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_config));
            this.grb_cont1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tiempoInicial = new System.Windows.Forms.ComboBox();
            this.cmb_dispositivos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_tam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_calidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tiempo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_cont1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_cont1
            // 
            this.grb_cont1.Controls.Add(this.label7);
            this.grb_cont1.Controls.Add(this.cmb_dispositivos);
            this.grb_cont1.Controls.Add(this.label3);
            this.grb_cont1.Controls.Add(this.cmb_tiempoInicial);
            this.grb_cont1.Controls.Add(this.label2);
            this.grb_cont1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_cont1.Location = new System.Drawing.Point(12, 57);
            this.grb_cont1.Name = "grb_cont1";
            this.grb_cont1.Size = new System.Drawing.Size(304, 99);
            this.grb_cont1.TabIndex = 0;
            this.grb_cont1.TabStop = false;
            this.grb_cont1.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la configuración correspondiente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiempo de Espera Inicial:";
            // 
            // cmb_tiempoInicial
            // 
            this.cmb_tiempoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tiempoInicial.FormattingEnabled = true;
            this.cmb_tiempoInicial.Items.AddRange(new object[] {
            "20",
            "30",
            "40"});
            this.cmb_tiempoInicial.Location = new System.Drawing.Point(158, 20);
            this.cmb_tiempoInicial.Name = "cmb_tiempoInicial";
            this.cmb_tiempoInicial.Size = new System.Drawing.Size(62, 23);
            this.cmb_tiempoInicial.TabIndex = 1;
            // 
            // cmb_dispositivos
            // 
            this.cmb_dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dispositivos.FormattingEnabled = true;
            this.cmb_dispositivos.Location = new System.Drawing.Point(158, 58);
            this.cmb_dispositivos.Name = "cmb_dispositivos";
            this.cmb_dispositivos.Size = new System.Drawing.Size(135, 23);
            this.cmb_dispositivos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dispositivo de Captura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_tiempo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_tam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_calidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // cmb_tam
            // 
            this.cmb_tam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tam.FormattingEnabled = true;
            this.cmb_tam.Items.AddRange(new object[] {
            "160 x 120",
            "176 x 144",
            "320 x 240",
            "352 x 258",
            "640 x 480"});
            this.cmb_tam.Location = new System.Drawing.Point(158, 58);
            this.cmb_tam.Name = "cmb_tam";
            this.cmb_tam.Size = new System.Drawing.Size(132, 23);
            this.cmb_tam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamaño del Video:";
            // 
            // cmb_calidad
            // 
            this.cmb_calidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_calidad.FormattingEnabled = true;
            this.cmb_calidad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmb_calidad.Location = new System.Drawing.Point(158, 20);
            this.cmb_calidad.Name = "cmb_calidad";
            this.cmb_calidad.Size = new System.Drawing.Size(132, 23);
            this.cmb_calidad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calidad de Captura:";
            // 
            // cmb_tiempo
            // 
            this.cmb_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tiempo.FormattingEnabled = true;
            this.cmb_tiempo.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmb_tiempo.Location = new System.Drawing.Point(158, 97);
            this.cmb_tiempo.Name = "cmb_tiempo";
            this.cmb_tiempo.Size = new System.Drawing.Size(59, 23);
            this.cmb_tiempo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiempo de Captura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Segundos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Segundos";
            // 
            // button1
            // 
            this.button1.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.OK22;
            this.button1.Location = new System.Drawing.Point(275, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.config;
            this.pictureBox1.Location = new System.Drawing.Point(265, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_cont1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de la Cámara y Video";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.grb_cont1.ResumeLayout(false);
            this.grb_cont1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_cont1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_dispositivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tiempoInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_tiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_calidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}