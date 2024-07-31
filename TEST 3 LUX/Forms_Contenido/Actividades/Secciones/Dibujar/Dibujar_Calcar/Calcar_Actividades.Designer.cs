namespace TEST_3_LUX
{
    partial class Calcar_Actividades
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.picColor = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLLenar = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 699);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 26);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.picColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 176);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(770, 133);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(147, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // picColor
            // 
            this.picColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(571, 68);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(53, 42);
            this.picColor.TabIndex = 3;
            this.picColor.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 176);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1300, 523);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::TEST_3_LUX.Properties.Resources.Diseño_sin_título__99_;
            this.panel5.Controls.Add(this.btnRetroceder);
            this.panel5.Location = new System.Drawing.Point(12, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 130);
            this.panel5.TabIndex = 14;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(12, 62);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(71, 54);
            this.btnRetroceder.TabIndex = 9;
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::TEST_3_LUX.Properties.Resources.Diseño_sin_título__95_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(120, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 140);
            this.panel4.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(32, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 35);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(31, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 35);
            this.button10.TabIndex = 7;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(31, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 35);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(115, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 35);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(114, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 35);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(114, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 35);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(200, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 35);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(199, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 35);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(199, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 35);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::TEST_3_LUX.Properties.Resources.Diseño_sin_título__90_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnRectangulo);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnLinea);
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.btnLLenar);
            this.panel3.Controls.Add(this.btnCirculo);
            this.panel3.Controls.Add(this.btnBorrador);
            this.panel3.Controls.Add(this.btnLapiz);
            this.panel3.Location = new System.Drawing.Point(640, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 110);
            this.panel3.TabIndex = 3;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRectangulo.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangulo.FlatAppearance.BorderSize = 0;
            this.btnRectangulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRectangulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangulo.ForeColor = System.Drawing.Color.White;
            this.btnRectangulo.Location = new System.Drawing.Point(404, 27);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(82, 58);
            this.btnRectangulo.TabIndex = 18;
            this.btnRectangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(584, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(584, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // btnLinea
            // 
            this.btnLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLinea.BackColor = System.Drawing.Color.Transparent;
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinea.FlatAppearance.BorderSize = 0;
            this.btnLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.ForeColor = System.Drawing.Color.White;
            this.btnLinea.Location = new System.Drawing.Point(498, 26);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(69, 60);
            this.btnLinea.TabIndex = 17;
            this.btnLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(12, 26);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 60);
            this.btnColor.TabIndex = 11;
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLLenar
            // 
            this.btnLLenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLLenar.BackColor = System.Drawing.Color.Transparent;
            this.btnLLenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLLenar.FlatAppearance.BorderSize = 0;
            this.btnLLenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLLenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLLenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLLenar.ForeColor = System.Drawing.Color.White;
            this.btnLLenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLLenar.Location = new System.Drawing.Point(90, 26);
            this.btnLLenar.Name = "btnLLenar";
            this.btnLLenar.Size = new System.Drawing.Size(68, 60);
            this.btnLLenar.TabIndex = 12;
            this.btnLLenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLLenar.UseVisualStyleBackColor = false;
            this.btnLLenar.Click += new System.EventHandler(this.btnLLenar_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCirculo.BackColor = System.Drawing.Color.Transparent;
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCirculo.FlatAppearance.BorderSize = 0;
            this.btnCirculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCirculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.Color.White;
            this.btnCirculo.Location = new System.Drawing.Point(326, 26);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(66, 60);
            this.btnCirculo.TabIndex = 15;
            this.btnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrador.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrador.FlatAppearance.BorderSize = 0;
            this.btnBorrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrador.ForeColor = System.Drawing.Color.White;
            this.btnBorrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrador.Location = new System.Drawing.Point(248, 26);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(66, 60);
            this.btnBorrador.TabIndex = 14;
            this.btnBorrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapiz.BackColor = System.Drawing.Color.Transparent;
            this.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapiz.FlatAppearance.BorderSize = 0;
            this.btnLapiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLapiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.ForeColor = System.Drawing.Color.White;
            this.btnLapiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapiz.Location = new System.Drawing.Point(169, 26);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(68, 60);
            this.btnLapiz.TabIndex = 13;
            this.btnLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Image = global::TEST_3_LUX.Properties.Resources.color_palette;
            this.colorPicker.Location = new System.Drawing.Point(199, 18);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(356, 139);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 3;
            this.colorPicker.TabStop = false;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // Calcar_Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcar_Actividades";
            this.Text = "Calcar_Actividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calcar_Actividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button picColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnLLenar;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
    }
}