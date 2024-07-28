using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;
using TEST_3_LUX.FORMS;
using static System.Net.Mime.MediaTypeNames;
using TEST_3_LUX.Properties;

namespace TEST_3_LUX
{
    public partial class Pictogramas_Actividades : Form
    {
        private List<Pictogramas_BienMal> actividades;
        private int indiceActual;
        private Principal_actividades formularioAnterior;

        public Pictogramas_Actividades(Principal_actividades anterior)
        {
            InitializeComponent();
            formularioAnterior = anterior;
            InicializarActividades();
            MostrarActividad();
        }

        private void InicializarActividades()
        {
            actividades = new List<Pictogramas_BienMal>
            {
                
                new Pictogramas_BienMal(@"C:\Users\eduar\source\repos\LUX-APP\TEST 3 LUX\Resources\GRITAR.png", false),
                new Pictogramas_BienMal(@"C:\Users\eduar\source\repos\LUX-APP\TEST 3 LUX\Resources\accionmala.jpg", false),
                // Agrega más imágenes aquí...
                

            };

            indiceActual = 0;
        }

        private void MostrarActividad()
        {
            if (indiceActual < actividades.Count)
            {
                var actividad = actividades[indiceActual];
                pictureBoxActividad.Image = System.Drawing.Image.FromFile(actividad.RutaImagen);
                lblFeedback.Text = "";
            }
            else
            {
                // Mostrar mensaje de felicitaciones y cerrar formulario
                MessageBox.Show("¡Felicidades! Has completado todas las actividades.", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario actual
                formularioAnterior.Show(); // Muestra el formulario anterior
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pictogramas_Actividades_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(false);
        }

        private void btnBien_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(true);
        }

        private void VerificarRespuesta(bool respuestaUsuario)
        {
            var actividad = actividades[indiceActual];

            if (respuestaUsuario == actividad.EsBuenaAccion)
            {
                lblFeedback.Text = "Correcto!";
                indiceActual++;
                MostrarActividad();
            }
            else
            {
                lblFeedback.Text = "Incorrecto, intentalo de nuevo.";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
