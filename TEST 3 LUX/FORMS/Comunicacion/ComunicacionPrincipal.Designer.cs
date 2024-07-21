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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnDudas = new System.Windows.Forms.Button();
            this.btnTemaRojo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tlpBotonesTemas = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCabecera.SuspendLayout();
            this.tlpBotonesTemas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.CausesValidation = false;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1212, 15);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaximizar.CausesValidation = false;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1238, 15);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecera.Controls.Add(this.btnRegresar);
            this.pnlCabecera.Controls.Add(this.btnMaximizar);
            this.pnlCabecera.Controls.Add(this.btnMinimizar);
            this.pnlCabecera.Location = new System.Drawing.Point(-1, -3);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1305, 41);
            this.pnlCabecera.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.Gold;
            this.btnRegresar.CausesValidation = false;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(1264, 15);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(20, 20);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnDudas
            // 
            this.btnDudas.BackColor = System.Drawing.Color.Transparent;
            this.btnDudas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDudas.BackgroundImage")));
            this.btnDudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDudas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDudas.ForeColor = System.Drawing.Color.Black;
            this.btnDudas.Location = new System.Drawing.Point(3, 3);
            this.btnDudas.Name = "btnDudas";
            this.btnDudas.Size = new System.Drawing.Size(213, 63);
            this.btnDudas.TabIndex = 5;
            this.btnDudas.Text = "Lorem ipsum";
            this.btnDudas.UseVisualStyleBackColor = false;
            this.btnDudas.Click += new System.EventHandler(this.btnDudas_Click);
            // 
            // btnTemaRojo
            // 
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(441, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lorem ipsum";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tlpBotonesTemas
            // 
            this.tlpBotonesTemas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpBotonesTemas.ColumnCount = 3;
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotonesTemas.Controls.Add(this.btnDudas, 0, 0);
            this.tlpBotonesTemas.Controls.Add(this.button2, 2, 0);
            this.tlpBotonesTemas.Controls.Add(this.btnTemaRojo, 1, 0);
            this.tlpBotonesTemas.Location = new System.Drawing.Point(335, 161);
            this.tlpBotonesTemas.Name = "tlpBotonesTemas";
            this.tlpBotonesTemas.RowCount = 1;
            this.tlpBotonesTemas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesTemas.Size = new System.Drawing.Size(659, 69);
            this.tlpBotonesTemas.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(392, 255);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 213);
            this.tableLayoutPanel1.TabIndex = 9;
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
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacionPrincipal";
            this.Text = "ComunicacionPrincipal";
            this.Load += new System.EventHandler(this.ComunicacionPrincipal_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.tlpBotonesTemas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnDudas;
        private System.Windows.Forms.Button btnTemaRojo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesTemas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}