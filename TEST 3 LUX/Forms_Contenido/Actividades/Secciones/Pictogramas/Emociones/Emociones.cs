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

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Pictogramas.Emociones
{
    public partial class Emociones : Form
    {
        private List<(string emocion, string ruta)> emocionesImagenes; // Lista para almacenar emociones y rutas de imágenes
        private int imagenActualIndex;
        private List<Image> imagenesDeFondo;
        private int fondoActualIndex;


        public Emociones()
        {
            InitializeComponent();

            // Asignar las emociones a los Tags de los botones
            btnTriste.Tag = "triste";
            btnFeliz.Tag = "feliz";
            btnEnojado.Tag = "enojado";
            btnAsustado.Tag = "asustado";
            btnSorprendido.Tag = "sorprendido";

            // Cargar imágenes de emociones y de fondo
            CargarImagenesDeCarpeta(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Emociones\Recursos\Acciones\"));
            imagenActualIndex = 0;
            MostrarImagenActual();

            CargarFondosDeCarpeta(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Emociones\Recursos\Emociones\"));

            // Asignar eventos a los botones de emociones
            btnTriste.Click += btnEmocion_Click;
            btnFeliz.Click += btnEmocion_Click;
            btnEnojado.Click += btnEmocion_Click;
            btnAsustado.Click += btnEmocion_Click;
            btnSorprendido.Click += btnEmocion_Click;
        }

        private void Emociones_Load_1(object sender, EventArgs e)
        {
            // Asignar las emociones a los Tags de los botones
            btnTriste.Tag = "triste";
            btnFeliz.Tag = "feliz";
            btnEnojado.Tag = "enojado";
            btnAsustado.Tag = "asustado";
            btnSorprendido.Tag = "sorprendido";
        }

        private void btnEmocion_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            string emocionSeleccionada = btnClicked.Tag.ToString();

            VerificarYCambiarImagen(emocionSeleccionada);
        }

        private void VerificarYCambiarImagen(string emocionSeleccionada)
        {
            string emocionActual = emocionesImagenes[imagenActualIndex].emocion;

            if (emocionSeleccionada == emocionActual)
            {
                imagenActualIndex++;
                if (imagenActualIndex < emocionesImagenes.Count)
                {
                    MostrarImagenActual();
                }
                else
                {
                    MessageBox.Show("¡Has completado todas las imágenes!");
                    imagenActualIndex = 0; // Reiniciar para comenzar de nuevo si lo deseas
                }
            }
        }

        private void CargarImagenesDeCarpeta(string carpeta)
        {
            emocionesImagenes = new List<(string emocion, string ruta)>();

            var archivos = Directory.GetFiles(carpeta, "*.png").OrderBy(f => f).ToList();

            foreach (var archivo in archivos)
            {
                var nombreArchivo = Path.GetFileNameWithoutExtension(archivo).ToLower();

                string emocion = null;

                if (nombreArchivo.Contains("triste"))
                    emocion = "triste";
                else if (nombreArchivo.Contains("feliz"))
                    emocion = "feliz";
                else if (nombreArchivo.Contains("enojado"))
                    emocion = "enojado";
                else if (nombreArchivo.Contains("asustado"))
                    emocion = "asustado";
                else if (nombreArchivo.Contains("sorprendido"))
                    emocion = "sorprendido";

                if (emocion != null)
                {
                    emocionesImagenes.Add((emocion, archivo));
                }
            }
        }

        private void MostrarImagenActual()
        {
            string rutaImagenActual = emocionesImagenes[imagenActualIndex].ruta;
            panel1.BackgroundImage = Image.FromFile(rutaImagenActual);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void CargarFondosDeCarpeta(string carpeta)
        {
            imagenesDeFondo = new List<Image>();

            var archivos = Directory.GetFiles(carpeta, "*.png").Concat(Directory.GetFiles(carpeta, "*.jpg")).ToArray();

            foreach (var archivo in archivos)
            {
                imagenesDeFondo.Add(Image.FromFile(archivo));
            }
        }

        private void CambiarFondoPanel2()
        {
            if (imagenesDeFondo.Count > 0)
            {
                fondoActualIndex = (fondoActualIndex + 1) % imagenesDeFondo.Count;
                panel2.BackgroundImage = imagenesDeFondo[fondoActualIndex];
                panel2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CambiarFondoPanel2();
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Dispose();
        }

       
    }
}
