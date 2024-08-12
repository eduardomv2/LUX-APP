namespace TEST_3_LUX.FORMS.Comunicacion.Menus_secundarios
{
    partial class ComunicacionTTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComunicacionTTS));
            this.tmCarga = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMensajeNota = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnHablar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmCarga
            // 
            this.tmCarga.Enabled = true;
            this.tmCarga.Interval = 20;
            this.tmCarga.Tick += new System.EventHandler(this.tmCarga_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMensajeNota);
            this.panel1.Location = new System.Drawing.Point(12, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 481);
            this.panel1.TabIndex = 21;
            // 
            // txtMensajeNota
            // 
            this.txtMensajeNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensajeNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(105)))));
            this.txtMensajeNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensajeNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeNota.ForeColor = System.Drawing.Color.White;
            this.txtMensajeNota.Location = new System.Drawing.Point(17, 8);
            this.txtMensajeNota.Multiline = true;
            this.txtMensajeNota.Name = "txtMensajeNota";
            this.txtMensajeNota.Size = new System.Drawing.Size(1079, 438);
            this.txtMensajeNota.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Transparent;
            this.panel21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel21.BackgroundImage")));
            this.panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel21.Controls.Add(this.btnRetroceder);
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1173, 166);
            this.panel21.TabIndex = 20;
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
            this.btnRetroceder.Location = new System.Drawing.Point(29, 25);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(114, 105);
            this.btnRetroceder.TabIndex = 17;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnHablar
            // 
            this.btnHablar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHablar.BackColor = System.Drawing.Color.Transparent;
            this.btnHablar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHablar.BackgroundImage")));
            this.btnHablar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHablar.FlatAppearance.BorderSize = 0;
            this.btnHablar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHablar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHablar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHablar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHablar.Location = new System.Drawing.Point(1131, 608);
            this.btnHablar.Name = "btnHablar";
            this.btnHablar.Size = new System.Drawing.Size(114, 105);
            this.btnHablar.TabIndex = 19;
            this.btnHablar.UseVisualStyleBackColor = false;
            this.btnHablar.Click += new System.EventHandler(this.btnHablar_Click);
            // 
            // ComunicacionTTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.btnHablar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacionTTS";
            this.Opacity = 0D;
            this.Text = "ComunicacionTTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComunicacionTTS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmCarga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMensajeNota;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnHablar;
    }
}