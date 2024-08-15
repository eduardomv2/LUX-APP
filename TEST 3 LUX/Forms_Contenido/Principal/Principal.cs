﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;
using TEST_3_LUX.FORMS.Comunicacion3;

namespace TEST_3_LUX
{
    public partial class Principal : Form
    {
        string Transicion;

        private List<Image> fondos;
        private int indiceFondoActual;


        public Principal()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
  
        private void Principal_Load(object sender, EventArgs e)
        {
            // Cambia esto por la ruta relativa dentro del proyecto
            string carpetaFondos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms_Contenido\Principal\Resources\Fondos");
            fondos = new List<Image>();

            // Cargar todas las imágenes de la carpeta
            foreach (string archivo in Directory.GetFiles(carpetaFondos, "*.png"))
            {
                fondos.Add(Image.FromFile(archivo));
            }

            // Inicializar el índice de la imagen actual
            indiceFondoActual = 0;

            Transicion = "FadeIn";
            this.Top = this.Top + 15;
            tmTransicion.Start();
        }

        private void CambiarFondo()
        {
            if (fondos.Count > 0)
            {
                // Establecer la imagen de fondo del formulario
                this.BackgroundImage = fondos[indiceFondoActual];
                this.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar la imagen al tamaño del formulario
                this.BackColor = DefaultBackColor; // Resetear el color de fondo a su valor por defecto
            }
        }


        #region BOTONES PARA MANEJO DE VENTANA
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar ventana
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            Transicion = "FadeOutExit";
            tmTransicion.Start();
        }
        #endregion


        #region BOTOENES PRINCIPALES DE MENU
        private void btnActividades_Click_1(object sender, EventArgs e)
        {
            Principal_actividades act = new Principal_actividades();
            act.Show();
            this.Hide();

            Transicion = "FadeOut";
            tmTransicion.Start();


        }

        private void btnComunicacion_Click_1(object sender, EventArgs e)
        {
            ComunicacionPrincipal com = new ComunicacionPrincipal(this);
            com.Show();
            this.Hide();


        }
        #endregion


        #region OPCIONES
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            // Alternar la visibilidad de panel2
            
            panel2.Visible = !panel2.Visible;
        }

        private void btnPaginaWeb_Click(object sender, EventArgs e)
        {
            //FUNCION PROVICIONAL HASTA TENER AL MENOS UN PROTOTIPO DE LA PAG

            //ABRIR GITHUB DEL PROYECTO
            System.Diagnostics.Process.Start("https://github.com/eduardomv2/LUX-APP");
        }
        #endregion

        private void tmTransicion_Tick(object sender, EventArgs e)
        {
            if (Transicion == "FadeOut")
            {
                if (this.Opacity == 0)
                {
                    tmTransicion.Stop();                
                    this.Hide();
                }
                else
                {
                    this.Opacity = this.Opacity - .15;
                    this.Top = this.Top + 3;   
                }
            }
            else if (Transicion == "FadeIn")
            {
                if (this.Opacity == 1)
                {
                    tmTransicion.Stop();
                }
                else
                {
                    this.Opacity = this.Opacity + .15;
                    this.Top = this.Top - 10;
                }
            }
            else if (Transicion == "FadeOutExit")
            {
                if (this.Opacity == 0)
                {
                    tmTransicion.Stop();
                    Application.Exit();
                }
                else
                {
                    this.Opacity = this.Opacity - .10;
                    this.Left = this.Left + 10;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Incrementar el índice del fondo actual
            indiceFondoActual = (indiceFondoActual + 1) % fondos.Count;

            // Cambiar el fondo
            CambiarFondo();
        }

      

        
    }
}