namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Impresion
{
    partial class SeleccionPDFSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionPDFSocial));
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnEmociones = new System.Windows.Forms.Button();
            this.btnSiNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimales
            // 
            this.btnAnimales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimales.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnimales.BackgroundImage")));
            this.btnAnimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnimales.FlatAppearance.BorderSize = 0;
            this.btnAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimales.Location = new System.Drawing.Point(147, 312);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(114, 105);
            this.btnAnimales.TabIndex = 24;
            this.btnAnimales.UseVisualStyleBackColor = false;
            // 
            // btnEmociones
            // 
            this.btnEmociones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmociones.BackColor = System.Drawing.Color.Transparent;
            this.btnEmociones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmociones.BackgroundImage")));
            this.btnEmociones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmociones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmociones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmociones.FlatAppearance.BorderSize = 0;
            this.btnEmociones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmociones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmociones.Location = new System.Drawing.Point(147, 90);
            this.btnEmociones.Name = "btnEmociones";
            this.btnEmociones.Size = new System.Drawing.Size(114, 105);
            this.btnEmociones.TabIndex = 23;
            this.btnEmociones.UseVisualStyleBackColor = false;
            this.btnEmociones.Click += new System.EventHandler(this.btnEmociones_Click);
            // 
            // btnSiNo
            // 
            this.btnSiNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiNo.BackColor = System.Drawing.Color.Transparent;
            this.btnSiNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiNo.BackgroundImage")));
            this.btnSiNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSiNo.FlatAppearance.BorderSize = 0;
            this.btnSiNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSiNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSiNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiNo.Location = new System.Drawing.Point(147, 201);
            this.btnSiNo.Name = "btnSiNo";
            this.btnSiNo.Size = new System.Drawing.Size(114, 105);
            this.btnSiNo.TabIndex = 22;
            this.btnSiNo.UseVisualStyleBackColor = false;
            this.btnSiNo.Click += new System.EventHandler(this.btnSiNo_Click);
            // 
            // SeleccionPDFSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 506);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.btnEmociones);
            this.Controls.Add(this.btnSiNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionPDFSocial";
            this.Text = "SeleccionPDFSocial";
            this.Load += new System.EventHandler(this.SeleccionPDFSocial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnEmociones;
        private System.Windows.Forms.Button btnSiNo;
    }
}