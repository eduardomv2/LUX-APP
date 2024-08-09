using TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComunicacionPrincipal));
            this.tmCarga = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados.DoubleBufferedFlowLayoutPanel();
            this.tlpBotonesTemas = new System.Windows.Forms.TableLayoutPanel();
            this.btnTemaAmarillo = new System.Windows.Forms.Button();
            this.btnTemaVerde = new System.Windows.Forms.Button();
            this.btnTemaRojo = new System.Windows.Forms.Button();
            this.pbIncomodidad = new System.Windows.Forms.PictureBox();
            this.pbTranquilidad = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVocabulario = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnNotasAudio = new System.Windows.Forms.Button();
            this.btnTablaPictograma = new System.Windows.Forms.Button();
            this.tlpBotonesTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomodidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTranquilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmCarga
            // 
            this.tmCarga.Enabled = true;
            this.tmCarga.Interval = 20;
            this.tmCarga.Tick += new System.EventHandler(this.tmCarga_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(165, 509);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(946, 130);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // tlpBotonesTemas
            // 
            this.tlpBotonesTemas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotonesTemas.BackColor = System.Drawing.Color.Transparent;
            this.tlpBotonesTemas.ColumnCount = 3;
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.Controls.Add(this.btnTemaAmarillo, 0, 0);
            this.tlpBotonesTemas.Controls.Add(this.btnTemaVerde, 2, 0);
            this.tlpBotonesTemas.Controls.Add(this.btnTemaRojo, 1, 0);
            this.tlpBotonesTemas.Location = new System.Drawing.Point(156, 424);
            this.tlpBotonesTemas.Name = "tlpBotonesTemas";
            this.tlpBotonesTemas.RowCount = 1;
            this.tlpBotonesTemas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesTemas.Size = new System.Drawing.Size(958, 69);
            this.tlpBotonesTemas.TabIndex = 32;
            // 
            // btnTemaAmarillo
            // 
            this.btnTemaAmarillo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaAmarillo.BackgroundImage")));
            this.btnTemaAmarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaAmarillo.FlatAppearance.BorderSize = 0;
            this.btnTemaAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaAmarillo.ForeColor = System.Drawing.Color.Black;
            this.btnTemaAmarillo.Location = new System.Drawing.Point(3, 3);
            this.btnTemaAmarillo.Name = "btnTemaAmarillo";
            this.btnTemaAmarillo.Size = new System.Drawing.Size(313, 63);
            this.btnTemaAmarillo.TabIndex = 5;
            this.btnTemaAmarillo.Text = "Lorem ipsum";
            this.btnTemaAmarillo.UseVisualStyleBackColor = false;
            this.btnTemaAmarillo.Click += new System.EventHandler(this.btnTemaAmarillo_Click);
            // 
            // btnTemaVerde
            // 
            this.btnTemaVerde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaVerde.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaVerde.BackgroundImage")));
            this.btnTemaVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaVerde.FlatAppearance.BorderSize = 0;
            this.btnTemaVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaVerde.ForeColor = System.Drawing.Color.White;
            this.btnTemaVerde.Location = new System.Drawing.Point(641, 3);
            this.btnTemaVerde.Name = "btnTemaVerde";
            this.btnTemaVerde.Size = new System.Drawing.Size(314, 63);
            this.btnTemaVerde.TabIndex = 7;
            this.btnTemaVerde.Text = "Lorem ipsum";
            this.btnTemaVerde.UseVisualStyleBackColor = false;
            this.btnTemaVerde.Click += new System.EventHandler(this.btnTemaVerde_Click);
            // 
            // btnTemaRojo
            // 
            this.btnTemaRojo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaRojo.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemaRojo.BackgroundImage")));
            this.btnTemaRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemaRojo.FlatAppearance.BorderSize = 0;
            this.btnTemaRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemaRojo.ForeColor = System.Drawing.Color.White;
            this.btnTemaRojo.Location = new System.Drawing.Point(322, 3);
            this.btnTemaRojo.Name = "btnTemaRojo";
            this.btnTemaRojo.Size = new System.Drawing.Size(313, 63);
            this.btnTemaRojo.TabIndex = 6;
            this.btnTemaRojo.Text = "Lorem ipsum";
            this.btnTemaRojo.UseVisualStyleBackColor = false;
            this.btnTemaRojo.Click += new System.EventHandler(this.btnTemaRojo_Click);
            // 
            // pbIncomodidad
            // 
            this.pbIncomodidad.BackColor = System.Drawing.Color.Transparent;
            this.pbIncomodidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIncomodidad.BackgroundImage")));
            this.pbIncomodidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIncomodidad.Location = new System.Drawing.Point(213, 218);
            this.pbIncomodidad.Name = "pbIncomodidad";
            this.pbIncomodidad.Size = new System.Drawing.Size(345, 209);
            this.pbIncomodidad.TabIndex = 33;
            this.pbIncomodidad.TabStop = false;
            // 
            // pbTranquilidad
            // 
            this.pbTranquilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTranquilidad.BackColor = System.Drawing.Color.Transparent;
            this.pbTranquilidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTranquilidad.BackgroundImage")));
            this.pbTranquilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTranquilidad.Location = new System.Drawing.Point(685, 223);
            this.pbTranquilidad.Name = "pbTranquilidad";
            this.pbTranquilidad.Size = new System.Drawing.Size(342, 209);
            this.pbTranquilidad.TabIndex = 34;
            this.pbTranquilidad.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(340, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(635, 217);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnVocabulario);
            this.panel1.Controls.Add(this.btnRetroceder);
            this.panel1.Controls.Add(this.btnNotasAudio);
            this.panel1.Controls.Add(this.btnTablaPictograma);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 171);
            this.panel1.TabIndex = 31;
            // 
            // btnVocabulario
            // 
            this.btnVocabulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVocabulario.BackgroundImage")));
            this.btnVocabulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVocabulario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVocabulario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVocabulario.FlatAppearance.BorderSize = 0;
            this.btnVocabulario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVocabulario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVocabulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVocabulario.Location = new System.Drawing.Point(391, 24);
            this.btnVocabulario.Name = "btnVocabulario";
            this.btnVocabulario.Size = new System.Drawing.Size(114, 105);
            this.btnVocabulario.TabIndex = 19;
            this.btnVocabulario.UseVisualStyleBackColor = true;
            this.btnVocabulario.Click += new System.EventHandler(this.btnVocabulario_Click);
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
            this.btnNotasAudio.Location = new System.Drawing.Point(271, 24);
            this.btnNotasAudio.Name = "btnNotasAudio";
            this.btnNotasAudio.Size = new System.Drawing.Size(114, 105);
            this.btnNotasAudio.TabIndex = 18;
            this.btnNotasAudio.UseVisualStyleBackColor = true;
            this.btnNotasAudio.Click += new System.EventHandler(this.btnNotasAudio_Click);
            // 
            // btnTablaPictograma
            // 
            this.btnTablaPictograma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTablaPictograma.BackgroundImage")));
            this.btnTablaPictograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTablaPictograma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTablaPictograma.FlatAppearance.BorderSize = 0;
            this.btnTablaPictograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTablaPictograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTablaPictograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaPictograma.Location = new System.Drawing.Point(151, 24);
            this.btnTablaPictograma.Name = "btnTablaPictograma";
            this.btnTablaPictograma.Size = new System.Drawing.Size(114, 105);
            this.btnTablaPictograma.TabIndex = 16;
            this.btnTablaPictograma.UseVisualStyleBackColor = true;
            this.btnTablaPictograma.Click += new System.EventHandler(this.btnTablaPictograma_Click);
            // 
            // ComunicacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.tlpBotonesTemas);
            this.Controls.Add(this.pbIncomodidad);
            this.Controls.Add(this.pbTranquilidad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Timer tmCarga;
        private DoubleBufferedFlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesTemas;
        private System.Windows.Forms.Button btnTemaAmarillo;
        private System.Windows.Forms.Button btnTemaVerde;
        private System.Windows.Forms.Button btnTemaRojo;
        private System.Windows.Forms.PictureBox pbIncomodidad;
        private System.Windows.Forms.PictureBox pbTranquilidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVocabulario;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnNotasAudio;
        private System.Windows.Forms.Button btnTablaPictograma;
    }
}