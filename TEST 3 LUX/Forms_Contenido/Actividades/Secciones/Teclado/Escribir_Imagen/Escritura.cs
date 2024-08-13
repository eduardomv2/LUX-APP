using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Teclado
{
    public partial class Escritura : Form
    {

        private List<string> imagenes;
        private int imagenActualIndex;
        private List<string> secciones;
        private int seccionActualIndex;


        public Escritura()
        {
            InitializeComponent();
            panel2.Visible = false;
            button7.Visible = false;
            // Obtener la ruta base del directorio donde se está ejecutando la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Definir las rutas relativas a las carpetas de recursos
            secciones = new List<string>
            {
                Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Alimentos\"),
                Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Objetos\"),
                Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Animales\")
            };

            seccionActualIndex = 0;
            CargarImagenesDeCarpeta(secciones[seccionActualIndex]);
            ConfigurarProgressBar();
            CargarImagen(imagenes[imagenActualIndex]);
        }

        private void CargarImagenesDeCarpeta(string carpeta)
        {
            imagenes = Directory.GetFiles(carpeta, "*.png").ToList();
            imagenActualIndex = 0;
            progressBar1.Maximum = imagenes.Count;
            progressBar1.Value = 0;
            if (imagenes.Count > 0)
            {
                CargarImagen(imagenes[imagenActualIndex]);
            }
        }

        private void ConfigurarProgressBar()
        {
           
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
        }

        private void CargarImagen(string rutaImagen)
        {
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //alternar visibilidad del panel2
            panel2.Visible = !panel2.Visible;
            button1.Visible = false;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string palabraCorrecta = Path.GetFileNameWithoutExtension(imagenes[imagenActualIndex]);

            if (textBox1.Text.ToLower() == palabraCorrecta.ToLower())
            {
                progressBar1.PerformStep();  // Avanza el progressBar

                imagenActualIndex++;
                if (imagenActualIndex < imagenes.Count)
                {
                    CargarImagen(imagenes[imagenActualIndex]);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("¡Felicidades! Has completado esta sección.");
                    // Al finalizar las imágenes de la sección, pasar a la siguiente
                    seccionActualIndex++;
                    if (seccionActualIndex < secciones.Count)
                    {
                        CargarImagenesDeCarpeta(secciones[seccionActualIndex]);
                        CargarImagen(imagenes[imagenActualIndex]);
                    }
                    else
                    {
                        MessageBox.Show("¡Felicidades! Has completado todas las secciones.");
                        // Aquí podrías reiniciar o hacer algo más si lo deseas
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrecto, intenta de nuevo.");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            CargarImagenesDeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Alimentos\"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            CargarImagenesDeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Objetos\"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            CargarImagenesDeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Escribir_Imagen\Recursos\Animales\"));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //alternar visibilidad del panel2
            panel2.Visible = !panel2.Visible;
            button1.Visible = true;
            button7.Visible = false;
        }
    }
}
