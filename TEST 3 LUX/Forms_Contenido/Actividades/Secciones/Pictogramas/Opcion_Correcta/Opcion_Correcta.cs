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

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Pictogramas.Opcion_Correcta
{
    public partial class Opcion_Correcta : Form
    {
        private List<string> imagenes;
        private int imagenActualIndex;
        private Dictionary<string, string> categorias; 
        private Random random;

        public Opcion_Correcta()
        {
            InitializeComponent();

         
            categorias = new Dictionary<string, string>
            {
                { "animales", "animal" },
                { "personas", "persona" },
                { "objetos", "objeto" },
                { "comida", "comida" }
            };

            random = new Random(); 

            //C:\Users\eduar\source\repos\LUX-APP\TEST 3 LUX\Forms_Contenido\Actividades\Secciones\Pictogramas\Opcion_Correcta\Recursos\
            CargarImagenesDeCarpeta(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Opcion_Correcta\Recursos\"));
            MezclarImagenes();

            imagenActualIndex = 0;
            MostrarImagenActual();

          
            btnAnimal.Click += (sender, e) => VerificarCategoria("animal");
            btnPersona.Click += (sender, e) => VerificarCategoria("persona");
            btnObjeto.Click += (sender, e) => VerificarCategoria("objeto");
            btnComida.Click += (sender, e) => VerificarCategoria("comida");
        }

        private void CargarImagenesDeCarpeta(string carpeta)
        {
           
            imagenes = Directory.GetFiles(carpeta, "*.png")
                .Concat(Directory.GetFiles(carpeta, "*.jpg"))
                .ToList();
        }

        private void MezclarImagenes()
        {
            imagenes = imagenes.OrderBy(x => random.Next()).ToList();
        }

        private void MostrarImagenActual()
        {
            if (imagenActualIndex < imagenes.Count)
            {
                string rutaImagenActual = imagenes[imagenActualIndex];
                panel2.BackgroundImage = Image.FromFile(rutaImagenActual);
                panel2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void VerificarCategoria(string categoria)
        {
            string rutaImagenActual = imagenes[imagenActualIndex].ToLower();

    
            if (rutaImagenActual.Contains(categoria))
            {
                imagenActualIndex++;

                if (imagenActualIndex >= imagenes.Count)
                {
                    MessageBox.Show("¡Has completado todas las imágenes!");
                    imagenActualIndex = 0;
                    MezclarImagenes(); 
                }

                MostrarImagenActual();
            }
            else
            {
                MessageBox.Show("¡Intenta de nuevo!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Opcion_Correcta_Load(object sender, EventArgs e)
        {

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {

        }

        private void btnObjeto_Click(object sender, EventArgs e)
        {

        }

        private void btnComida_Click(object sender, EventArgs e)
        {

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal_actividades principal_Actividades = new Principal_actividades();
            principal_Actividades.Show();
            this.Dispose();
        }
    }
}
