namespace Video_Captura_Robos_ESPOL
{
    partial class VisorPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorPrincipal));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain = new Video_Captura_Robos_ESPOL.ThumbnailFlowLayoutPanel();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.lbl_select = new System.Windows.Forms.Label();
            this.cmb_escoger = new System.Windows.Forms.ComboBox();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.parar;
            this.buttonCancel.Location = new System.Drawing.Point(507, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(30, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.flowLayoutPanelMain);
            this.panelMain.Location = new System.Drawing.Point(12, 41);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(615, 429);
            this.panelMain.TabIndex = 4;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelMain.CausesValidation = false;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(615, 429);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSize.AutoSize = false;
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(341, 10);
            this.trackBarSize.Maximum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(124, 23);
            this.trackBarSize.TabIndex = 5;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 1;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(12, 17);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(165, 13);
            this.lbl_select.TabIndex = 6;
            this.lbl_select.Text = "Seleccionar que desea visualizar:";
            // 
            // cmb_escoger
            // 
            this.cmb_escoger.FormattingEnabled = true;
            this.cmb_escoger.Items.AddRange(new object[] {
            "Imágenes",
            "Videos"});
            this.cmb_escoger.Location = new System.Drawing.Point(183, 12);
            this.cmb_escoger.Name = "cmb_escoger";
            this.cmb_escoger.Size = new System.Drawing.Size(152, 21);
            this.cmb_escoger.TabIndex = 7;
            this.cmb_escoger.Text = "Seleccionar...";
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Image = global::Video_Captura_Robos_ESPOL.Properties.Resources.buscar;
            this.buttonBrowseFolder.Location = new System.Drawing.Point(471, 3);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(30, 30);
            this.buttonBrowseFolder.TabIndex = 1;
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // VisorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 482);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.cmb_escoger);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonBrowseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Imágenes y Videos Capturados";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ThumbnailFlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.ComboBox cmb_escoger;
    }
}

