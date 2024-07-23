namespace TEST_3_LUX.FORMS.Comunicacion3
{
    partial class ComunicacionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComunicacionPrincipal));
            this.btnTemaAmarillo = new System.Windows.Forms.Button();
            this.btnTemaRojo = new System.Windows.Forms.Button();
            this.btnTemaVerde = new System.Windows.Forms.Button();
            this.tlpBotonesTemas = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbIncomodidad = new System.Windows.Forms.PictureBox();
            this.pbTranquilidad = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTablaPictograma = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpBotonesTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomodidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTranquilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemaAmarillo
            // 
            this.btnTemaAmarillo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaAmarillo.BackgroundImage")));
            this.btnTemaAmarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaAmarillo.ForeColor = System.Drawing.Color.Black;
            this.btnTemaAmarillo.Location = new System.Drawing.Point(3, 3);
            this.btnTemaAmarillo.Name = "btnTemaAmarillo";
            this.btnTemaAmarillo.Size = new System.Drawing.Size(213, 63);
            this.btnTemaAmarillo.TabIndex = 5;
            this.btnTemaAmarillo.Text = "Lorem ipsum";
            this.btnTemaAmarillo.UseVisualStyleBackColor = false;
            this.btnTemaAmarillo.Click += new System.EventHandler(this.btnDudas_Click);
            // 
            // btnTemaRojo
            // 
            this.btnTemaRojo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaRojo.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaRojo.BackgroundImage")));
            this.btnTemaRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaRojo.ForeColor = System.Drawing.Color.White;
            this.btnTemaRojo.Location = new System.Drawing.Point(222, 3);
            this.btnTemaRojo.Name = "btnTemaRojo";
            this.btnTemaRojo.Size = new System.Drawing.Size(213, 63);
            this.btnTemaRojo.TabIndex = 6;
            this.btnTemaRojo.Text = "Lorem ipsum";
            this.btnTemaRojo.UseVisualStyleBackColor = false;
            this.btnTemaRojo.Click += new System.EventHandler(this.btnTemaRojo_Click);
            // 
            // btnTemaVerde
            // 
            this.btnTemaVerde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaVerde.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaVerde.BackgroundImage")));
            this.btnTemaVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaVerde.ForeColor = System.Drawing.Color.White;
            this.btnTemaVerde.Location = new System.Drawing.Point(441, 3);
            this.btnTemaVerde.Name = "btnTemaVerde";
            this.btnTemaVerde.Size = new System.Drawing.Size(215, 63);
            this.btnTemaVerde.TabIndex = 7;
            this.btnTemaVerde.Text = "Lorem ipsum";
            this.btnTemaVerde.UseVisualStyleBackColor = false;
            this.btnTemaVerde.Click += new System.EventHandler(this.button2_Click);
            // 
            // tlpBotonesTemas
            // 
            this.tlpBotonesTemas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotonesTemas.ColumnCount = 3;
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.Controls.Add(this.btnTemaAmarillo, 0, 0);
            this.tlpBotonesTemas.Controls.Add(this.btnTemaVerde, 2, 0);
            this.tlpBotonesTemas.Controls.Add(this.btnTemaRojo, 1, 0);
            this.tlpBotonesTemas.Location = new System.Drawing.Point(343, 304);
            this.tlpBotonesTemas.Name = "tlpBotonesTemas";
            this.tlpBotonesTemas.RowCount = 1;
            this.tlpBotonesTemas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesTemas.Size = new System.Drawing.Size(659, 69);
            this.tlpBotonesTemas.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(378, 397);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 213);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // pbIncomodidad
            // 
            this.pbIncomodidad.BackColor = System.Drawing.Color.Transparent;
            this.pbIncomodidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIncomodidad.BackgroundImage")));
            this.pbIncomodidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIncomodidad.Location = new System.Drawing.Point(366, 174);
            this.pbIncomodidad.Name = "pbIncomodidad";
            this.pbIncomodidad.Size = new System.Drawing.Size(177, 144);
            this.pbIncomodidad.TabIndex = 11;
            this.pbIncomodidad.TabStop = false;
            // 
            // pbTranquilidad
            // 
            this.pbTranquilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTranquilidad.BackColor = System.Drawing.Color.Transparent;
            this.pbTranquilidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTranquilidad.BackgroundImage")));
            this.pbTranquilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTranquilidad.Location = new System.Drawing.Point(803, 174);
            this.pbTranquilidad.Name = "pbTranquilidad";
            this.pbTranquilidad.Size = new System.Drawing.Size(177, 144);
            this.pbTranquilidad.TabIndex = 13;
            this.pbTranquilidad.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(584, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 144);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRetroceder);
            this.panel1.Controls.Add(this.btnTablaPictograma);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 165);
            this.panel1.TabIndex = 15;
            // 
            // btnTablaPictograma
            // 
            this.btnTablaPictograma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTablaPictograma.BackgroundImage")));
            this.btnTablaPictograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTablaPictograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaPictograma.Location = new System.Drawing.Point(121, 32);
            this.btnTablaPictograma.Name = "btnTablaPictograma";
            this.btnTablaPictograma.Size = new System.Drawing.Size(85, 91);
            this.btnTablaPictograma.TabIndex = 16;
            this.btnTablaPictograma.UseVisualStyleBackColor = true;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.BackgroundImage")));
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(30, 32);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(85, 91);
            this.btnRetroceder.TabIndex = 17;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(212, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 91);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ComunicacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBotonesTemas);
            this.Controls.Add(this.pbIncomodidad);
            this.Controls.Add(this.pbTranquilidad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacionPrincipal";
            this.Text = "ComunicacionPrincipal";
            this.Load += new System.EventHandler(this.ComunicacionPrincipal_Load);
            this.tlpBotonesTemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomodidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTranquilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTemaAmarillo;
        private System.Windows.Forms.Button btnTemaRojo;
        private System.Windows.Forms.Button btnTemaVerde;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesTemas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbIncomodidad;
        private System.Windows.Forms.PictureBox pbTranquilidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTablaPictograma;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button button1;
    }
}