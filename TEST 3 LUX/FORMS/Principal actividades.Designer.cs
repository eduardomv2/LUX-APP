namespace TEST_3_LUX.FORMS
{
    partial class Principal_actividades
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPictogramas = new System.Windows.Forms.PictureBox();
            this.pictureboxRetroceder = new System.Windows.Forms.PictureBox();
            this.panelActividadesBotones = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictogramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRetroceder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BackgroundImage = global::TEST_3_LUX.Properties.Resources.PanelSuperiorActividades;
            this.panelSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSuperior.Controls.Add(this.pictureBox3);
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.pictureBoxPictogramas);
            this.panelSuperior.Controls.Add(this.pictureboxRetroceder);
            this.panelSuperior.Location = new System.Drawing.Point(2, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(669, 146);
            this.panelSuperior.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TEST_3_LUX.Properties.Resources.TecladoActividades;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(351, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 108);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TEST_3_LUX.Properties.Resources.DibujarActividades;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(242, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 108);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxPictogramas
            // 
            this.pictureBoxPictogramas.BackgroundImage = global::TEST_3_LUX.Properties.Resources.PictogramasActividades;
            this.pictureBoxPictogramas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPictogramas.Location = new System.Drawing.Point(134, 21);
            this.pictureBoxPictogramas.Name = "pictureBoxPictogramas";
            this.pictureBoxPictogramas.Size = new System.Drawing.Size(104, 108);
            this.pictureBoxPictogramas.TabIndex = 1;
            this.pictureBoxPictogramas.TabStop = false;
            // 
            // pictureboxRetroceder
            // 
            this.pictureboxRetroceder.BackgroundImage = global::TEST_3_LUX.Properties.Resources.RetrocederActividades;
            this.pictureboxRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxRetroceder.Location = new System.Drawing.Point(38, 32);
            this.pictureboxRetroceder.Name = "pictureboxRetroceder";
            this.pictureboxRetroceder.Size = new System.Drawing.Size(90, 81);
            this.pictureboxRetroceder.TabIndex = 1;
            this.pictureboxRetroceder.TabStop = false;
            // 
            // panelActividadesBotones
            // 
            this.panelActividadesBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActividadesBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelActividadesBotones.Location = new System.Drawing.Point(-6, 285);
            this.panelActividadesBotones.Name = "panelActividadesBotones";
            this.panelActividadesBotones.Size = new System.Drawing.Size(1306, 296);
            this.panelActividadesBotones.TabIndex = 1;
            this.panelActividadesBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActividadesBotones_Paint);
            // 
            // Principal_actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::TEST_3_LUX.Properties.Resources.FondodeActividades;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.panelActividadesBotones);
            this.Controls.Add(this.panelSuperior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal_actividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictogramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxRetroceder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureboxRetroceder;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxPictogramas;
        private System.Windows.Forms.Panel panelActividadesBotones;
    }
}