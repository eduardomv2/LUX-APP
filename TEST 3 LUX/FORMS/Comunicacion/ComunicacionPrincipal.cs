﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS.Comunicacion.Controles_personalizados;

namespace TEST_3_LUX.FORMS.Comunicacion3
{
    public partial class ComunicacionPrincipal : Form
    {
        private Principal FormPrincipal;

        /// <summary>
        /// Genera una instancia del apartado de Comunicación tomando de referencia la posición en pantalla de la instancia recibida
        /// </summary>
        /// <param name="main">Se utiliza para no perder instancia del formulario "principal" en memoria y en tiempo de compilación</param>
        public ComunicacionPrincipal(Principal main)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = main.Location;
            this.WindowState = main.WindowState;
            this.FormPrincipal = main;
        }

        #region CABECERA DE VENTANA
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar y restaurar ventana
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal.Show();
        }


        #endregion

        #region TEMAS DE CHARLA
        private void btnDudas_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaAmarillo.csv");
            GenerarTabla(filePath, typeof(RBotonAmarillo));
        }

        private void btnTemaRojo_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaRojo.csv");
            GenerarTabla(filePath, typeof(RBotonRojo));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaVerde.csv");
            GenerarTabla(filePath, typeof(RBotonVerde));
        }
        #endregion

        #region METODOS RELACIONADOS CON LA GENERACION DE DE BOTONES
        /// <summary>
        /// Genera a partir de un CSV una lista de botones en un TableLayoutPanel
        /// </summary>
        /// <param name="filePath">Ruta del archivo CSV con los mensajes a graficar para narrar</param>
        public void GenerarTabla(string filePath, Type btn)
        {
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 0;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    string[] values = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        values = line.Split(',');
                    }

                    int columnCount = tableLayoutPanel1.ColumnCount;

                    // Asegurar que haya suficientes filas
                    int requiredRowCount = (int)Math.Ceiling(values.Length / (double)columnCount);
                    while (tableLayoutPanel1.RowCount < requiredRowCount)
                    {
                        tableLayoutPanel1.RowCount++;
                        RowStyle newRowStyle = new RowStyle(SizeType.AutoSize);
                        tableLayoutPanel1.RowStyles.Add(newRowStyle);
                    }

                    // Añadir botones a las celdas nuevas
                    for (int i = 0; i < values.Length; i++)
                    {
                        Button nuevoBoton = (Button)Activator.CreateInstance(btn);
                        nuevoBoton.Text = values[i];
                        nuevoBoton.Visible = true;


                        int row = i / columnCount;
                        int column = i % columnCount;

                        tableLayoutPanel1.Controls.Add(nuevoBoton, column, row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer CSV: " + ex.Message);
            }

            tableLayoutPanel1.ResumeLayout();
        }

        #endregion

        private void ComunicacionPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}