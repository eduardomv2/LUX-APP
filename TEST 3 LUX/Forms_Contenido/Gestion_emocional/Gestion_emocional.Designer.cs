namespace TEST_3_LUX.Forms_Contenido.Gestion_emocional
{
    partial class Gestion_emocional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_emocional));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnNotasAudio = new System.Windows.Forms.Button();
            this.btnCanciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.doubleBufferedTableLayoutPanel1 = new TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados.DoubleBufferedTableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnVideo);
            this.panel1.Controls.Add(this.btnRetroceder);
            this.panel1.Controls.Add(this.btnNotasAudio);
            this.panel1.Controls.Add(this.btnCanciones);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 171);
            this.panel1.TabIndex = 32;
            // 
            // btnVideo
            // 
            this.btnVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVideo.BackgroundImage")));
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Location = new System.Drawing.Point(271, 24);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(114, 105);
            this.btnVideo.TabIndex = 19;
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.BackgroundImage")));
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(31, 24);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(114, 105);
            this.btnRetroceder.TabIndex = 17;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnNotasAudio
            // 
            this.btnNotasAudio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotasAudio.BackgroundImage")));
            this.btnNotasAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotasAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotasAudio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNotasAudio.FlatAppearance.BorderSize = 0;
            this.btnNotasAudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNotasAudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNotasAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotasAudio.Location = new System.Drawing.Point(391, 24);
            this.btnNotasAudio.Name = "btnNotasAudio";
            this.btnNotasAudio.Size = new System.Drawing.Size(114, 105);
            this.btnNotasAudio.TabIndex = 18;
            this.btnNotasAudio.UseVisualStyleBackColor = true;
            // 
            // btnCanciones
            // 
            this.btnCanciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCanciones.BackgroundImage")));
            this.btnCanciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCanciones.FlatAppearance.BorderSize = 0;
            this.btnCanciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCanciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanciones.Location = new System.Drawing.Point(151, 24);
            this.btnCanciones.Name = "btnCanciones";
            this.btnCanciones.Size = new System.Drawing.Size(114, 105);
            this.btnCanciones.TabIndex = 16;
            this.btnCanciones.UseVisualStyleBackColor = true;
            this.btnCanciones.Click += new System.EventHandler(this.btnCanciones_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(16)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnPlayPause);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnDetener);
            this.panel2.Location = new System.Drawing.Point(20, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 76);
            this.panel2.TabIndex = 34;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(235, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(68, 67);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.BackgroundImage")));
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Location = new System.Drawing.Point(161, 3);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(68, 67);
            this.btnPlayPause.TabIndex = 22;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(87, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(68, 67);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetener.BackgroundImage")));
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetener.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDetener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Location = new System.Drawing.Point(13, 3);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(68, 67);
            this.btnDetener.TabIndex = 20;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // wmpVideo
            // 
            this.wmpVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(20, 4);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(890, 437);
            this.wmpVideo.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.wmpVideo);
            this.panel3.Location = new System.Drawing.Point(0, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 497);
            this.panel3.TabIndex = 36;
            // 
            // doubleBufferedTableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedTableLayoutPanel1.BackColor = System.Drawing.Color.Salmon;
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(926, 4);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 1;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(301, 483);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 37;
            this.doubleBufferedTableLayoutPanel1.Click += new System.EventHandler(this.doubleBufferedTableLayoutPanel1_Click);
            // 
            // Gestion_emocional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 686);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_emocional";
            this.Text = "Gestion_emocional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gestion_emocional_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnNotasAudio;
        private System.Windows.Forms.Button btnCanciones;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Panel panel3;
        private Comunicacion.Controles_personalizados.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }
}