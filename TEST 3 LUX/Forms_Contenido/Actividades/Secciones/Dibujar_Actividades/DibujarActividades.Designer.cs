namespace TEST_3_LUX
{
    partial class DibujarActividades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnLLenar = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnRetroceder);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.picColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 157);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(1207, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1207, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picColor
            // 
            this.picColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(555, 54);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(67, 45);
            this.picColor.TabIndex = 3;
            this.picColor.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnRectangulo);
            this.panel3.Controls.Add(this.btnLinea);
            this.panel3.Controls.Add(this.btnCirculo);
            this.panel3.Controls.Add(this.btnLLenar);
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.btnBorrador);
            this.panel3.Controls.Add(this.btnLapiz);
            this.panel3.Location = new System.Drawing.Point(637, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 106);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 699);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 26);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 157);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1300, 542);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.BackgroundImage = global::TEST_3_LUX.Properties.Resources.DiseñoRetroceder;
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(24, 38);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(112, 77);
            this.btnRetroceder.TabIndex = 9;
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Image = global::TEST_3_LUX.Properties.Resources.color_palette;
            this.colorPicker.Location = new System.Drawing.Point(165, 3);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(371, 148);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 3;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangulo.ForeColor = System.Drawing.Color.White;
            this.btnRectangulo.Image = global::TEST_3_LUX.Properties.Resources.rectangle;
            this.btnRectangulo.Location = new System.Drawing.Point(393, 15);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(83, 59);
            this.btnRectangulo.TabIndex = 22;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.ForeColor = System.Drawing.Color.White;
            this.btnLinea.Image = global::TEST_3_LUX.Properties.Resources.line;
            this.btnLinea.Location = new System.Drawing.Point(482, 24);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(63, 59);
            this.btnLinea.TabIndex = 21;
            this.btnLinea.Text = "Linea";
            this.btnLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.Color.White;
            this.btnCirculo.Image = global::TEST_3_LUX.Properties.Resources.circle;
            this.btnCirculo.Location = new System.Drawing.Point(324, 24);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(63, 59);
            this.btnCirculo.TabIndex = 20;
            this.btnCirculo.Text = "Circle";
            this.btnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnLLenar
            // 
            this.btnLLenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLLenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLLenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLLenar.ForeColor = System.Drawing.Color.White;
            this.btnLLenar.Image = global::TEST_3_LUX.Properties.Resources.bucket;
            this.btnLLenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLLenar.Location = new System.Drawing.Point(108, 22);
            this.btnLLenar.Name = "btnLLenar";
            this.btnLLenar.Size = new System.Drawing.Size(63, 59);
            this.btnLLenar.TabIndex = 19;
            this.btnLLenar.Text = "Llenar";
            this.btnLLenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLLenar.UseVisualStyleBackColor = false;
            this.btnLLenar.Click += new System.EventHandler(this.btnLLenar_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::TEST_3_LUX.Properties.Resources.color;
            this.btnColor.Location = new System.Drawing.Point(29, 23);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(69, 59);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrador.ForeColor = System.Drawing.Color.White;
            this.btnBorrador.Image = global::TEST_3_LUX.Properties.Resources.eraser;
            this.btnBorrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrador.Location = new System.Drawing.Point(255, 23);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(63, 59);
            this.btnBorrador.TabIndex = 14;
            this.btnBorrador.Text = "Borrador";
            this.btnBorrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click_1);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.ForeColor = System.Drawing.Color.White;
            this.btnLapiz.Image = global::TEST_3_LUX.Properties.Resources.pencil;
            this.btnLapiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapiz.Location = new System.Drawing.Point(183, 23);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(63, 59);
            this.btnLapiz.TabIndex = 13;
            this.btnLapiz.Text = "Lapiz";
            this.btnLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click_1);
            // 
            // DibujarActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DibujarActividades";
            this.Text = "DibujarActividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DibujarActividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button picColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnLLenar;
    }
}