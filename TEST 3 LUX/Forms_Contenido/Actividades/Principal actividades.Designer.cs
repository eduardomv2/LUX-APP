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
            this.components = new System.ComponentModel.Container();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnPictogramas = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tmTransicion = new System.Windows.Forms.Timer(this.components);
            this.panelSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BackgroundImage = global::TEST_3_LUX.Properties.Resources.Diseño_sin_título__74_;
            this.panelSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSuperior.Controls.Add(this.btnTeclado);
            this.panelSuperior.Controls.Add(this.btnDibujar);
            this.panelSuperior.Controls.Add(this.btnPictogramas);
            this.panelSuperior.Controls.Add(this.btnRetroceder);
            this.panelSuperior.Location = new System.Drawing.Point(12, 16);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(729, 160);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeclado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTeclado.FlatAppearance.BorderSize = 0;
            this.btnTeclado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTeclado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclado.Location = new System.Drawing.Point(416, 30);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(112, 100);
            this.btnTeclado.TabIndex = 10;
            this.btnTeclado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDibujar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDibujar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDibujar.FlatAppearance.BorderSize = 0;
            this.btnDibujar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDibujar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(278, 29);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(111, 96);
            this.btnDibujar.TabIndex = 9;
            this.btnDibujar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnPictogramas
            // 
            this.btnPictogramas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPictogramas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPictogramas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPictogramas.FlatAppearance.BorderSize = 0;
            this.btnPictogramas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPictogramas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPictogramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictogramas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictogramas.Location = new System.Drawing.Point(140, 30);
            this.btnPictogramas.Name = "btnPictogramas";
            this.btnPictogramas.Size = new System.Drawing.Size(104, 90);
            this.btnPictogramas.TabIndex = 0;
            this.btnPictogramas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPictogramas.UseVisualStyleBackColor = true;
            this.btnPictogramas.Click += new System.EventHandler(this.btnPictogramas_Click);
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
            this.btnRetroceder.Location = new System.Drawing.Point(24, 37);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(84, 83);
            this.btnRetroceder.TabIndex = 8;
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.34111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.93586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.17493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.915452F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.34111F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(364, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.0662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60279F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 266);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(478, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 161);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // tmTransicion
            // 
            this.tmTransicion.Enabled = true;
            this.tmTransicion.Interval = 20;
            this.tmTransicion.Tick += new System.EventHandler(this.tmTransicion_Tick);
            // 
            // Principal_actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::TEST_3_LUX.Properties.Resources.FondoActividades;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelSuperior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_actividades";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal_actividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_actividades_Load);
            this.panelSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnPictogramas;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tmTransicion;
    }
}