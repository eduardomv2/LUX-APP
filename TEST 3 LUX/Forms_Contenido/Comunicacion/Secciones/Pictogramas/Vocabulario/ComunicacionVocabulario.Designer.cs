namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Pictogramas.Vocabulario
{
    partial class ComunicacionVocabulario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComunicacionVocabulario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpTabla = new TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados.DoubleBufferedFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAbecedario = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.tmCarga = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.flpTabla);
            this.panel2.Location = new System.Drawing.Point(12, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 456);
            this.panel2.TabIndex = 25;
            // 
            // flpTabla
            // 
            this.flpTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabla.AutoScroll = true;
            this.flpTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(105)))));
            this.flpTabla.Location = new System.Drawing.Point(20, 8);
            this.flpTabla.Name = "flpTabla";
            this.flpTabla.Size = new System.Drawing.Size(1221, 416);
            this.flpTabla.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnAnimales);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnRetroceder);
            this.panel1.Controls.Add(this.btnAbecedario);
            this.panel1.Controls.Add(this.btnColores);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 171);
            this.panel1.TabIndex = 22;
            // 
            // btnAnimales
            // 
            this.btnAnimales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnimales.BackgroundImage")));
            this.btnAnimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnimales.FlatAppearance.BorderSize = 0;
            this.btnAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimales.Location = new System.Drawing.Point(398, 24);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(114, 105);
            this.btnAnimales.TabIndex = 20;
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(694, 24);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 105);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetroceder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.BackgroundImage")));
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(38, 24);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(114, 105);
            this.btnRetroceder.TabIndex = 17;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAbecedario
            // 
            this.btnAbecedario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbecedario.BackgroundImage")));
            this.btnAbecedario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbecedario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbecedario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbecedario.FlatAppearance.BorderSize = 0;
            this.btnAbecedario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbecedario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbecedario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbecedario.Location = new System.Drawing.Point(278, 24);
            this.btnAbecedario.Name = "btnAbecedario";
            this.btnAbecedario.Size = new System.Drawing.Size(114, 105);
            this.btnAbecedario.TabIndex = 18;
            this.btnAbecedario.UseVisualStyleBackColor = true;
            this.btnAbecedario.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnColores
            // 
            this.btnColores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColores.BackgroundImage")));
            this.btnColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnColores.FlatAppearance.BorderSize = 0;
            this.btnColores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnColores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.Location = new System.Drawing.Point(158, 24);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(114, 105);
            this.btnColores.TabIndex = 16;
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnAbecedario_Click);
            // 
            // tmCarga
            // 
            this.tmCarga.Enabled = true;
            this.tmCarga.Interval = 20;
            this.tmCarga.Tick += new System.EventHandler(this.tmCarga_Tick);
            // 
            // ComunicacionVocabulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacionVocabulario";
            this.Opacity = 0D;
            this.Text = "ComunicacionVocabulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComunicacionVocabulario_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAbecedario;
        private System.Windows.Forms.Button btnColores;
        private Controles_personalizados.DoubleBufferedFlowLayoutPanel flpTabla;
        private System.Windows.Forms.Timer tmCarga;
    }
}