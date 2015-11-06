namespace EnviarCorreo
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.asuntoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.archivoAdjTxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.examinarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mensajeTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.pct_atras = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_atras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinatarios:";
            // 
            // toTxt
            // 
            this.toTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTxt.Location = new System.Drawing.Point(127, 44);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(397, 20);
            this.toTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asunto:";
            // 
            // asuntoTxt
            // 
            this.asuntoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuntoTxt.Location = new System.Drawing.Point(127, 70);
            this.asuntoTxt.Name = "asuntoTxt";
            this.asuntoTxt.Size = new System.Drawing.Size(397, 20);
            this.asuntoTxt.TabIndex = 3;
            this.asuntoTxt.Text = "ALERTA - Sistema de Seguridad ha detectado movimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adjuntar archivo:";
            // 
            // archivoAdjTxt
            // 
            this.archivoAdjTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivoAdjTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoAdjTxt.Location = new System.Drawing.Point(127, 125);
            this.archivoAdjTxt.Name = "archivoAdjTxt";
            this.archivoAdjTxt.ReadOnly = true;
            this.archivoAdjTxt.Size = new System.Drawing.Size(316, 20);
            this.archivoAdjTxt.TabIndex = 5;
            this.archivoAdjTxt.Text = "C:\\Users\\Alex\\Documents\\Visual Studio 2013\\Projects\\EnviarCorreo\\EnviarCorreo\\Env" +
    "iarCorreo\\Resources\\Alerta_Azul.png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // examinarBtn
            // 
            this.examinarBtn.Location = new System.Drawing.Point(449, 125);
            this.examinarBtn.Name = "examinarBtn";
            this.examinarBtn.Size = new System.Drawing.Size(75, 23);
            this.examinarBtn.TabIndex = 6;
            this.examinarBtn.Text = "Examinar...";
            this.examinarBtn.UseVisualStyleBackColor = true;
            this.examinarBtn.Click += new System.EventHandler(this.examinarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mensaje:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mensajeTxt
            // 
            this.mensajeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeTxt.Location = new System.Drawing.Point(127, 182);
            this.mensajeTxt.Name = "mensajeTxt";
            this.mensajeTxt.Size = new System.Drawing.Size(397, 163);
            this.mensajeTxt.TabIndex = 8;
            this.mensajeTxt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.asuntoTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.archivoAdjTxt);
            this.groupBox1.Controls.Add(this.examinarBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mensajeTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 355);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correo Electrónico - Nuevo Mensaje";
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(461, 384);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(86, 33);
            this.enviarBtn.TabIndex = 9;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // pct_atras
            // 
            this.pct_atras.BackColor = System.Drawing.Color.Transparent;
            this.pct_atras.Image = global::EnviarCorreo.Properties.Resources.back_icon_1_;
            this.pct_atras.Location = new System.Drawing.Point(12, 384);
            this.pct_atras.Name = "pct_atras";
            this.pct_atras.Size = new System.Drawing.Size(30, 30);
            this.pct_atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_atras.TabIndex = 10;
            this.pct_atras.TabStop = false;
            this.pct_atras.Click += new System.EventHandler(this.pct_atras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnviarCorreo.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 424);
            this.Controls.Add(this.pct_atras);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envío de Alerta - Detección de Movimiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_atras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox asuntoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox archivoAdjTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button examinarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox mensajeTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.PictureBox pct_atras;
    }
}

