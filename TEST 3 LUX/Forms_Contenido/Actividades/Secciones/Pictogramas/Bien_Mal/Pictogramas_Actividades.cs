 using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;
using System.IO;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX
{
    public partial class Pictogramas_Actividades : Form
    {

        //PROVISIONAL SOLO PARA QUE SE VEA EL FUNCIONAMIENTO
        private List<Pictogramas_BienMal> actividades;
        private List<Pictogramas_BienMal> actividadesHigiene;
        private List<Pictogramas_BienMal> actividadesAula;
        private List<Pictogramas_BienMal> actividadesAmigos;
        private List<Pictogramas_BienMal> actividadesSocial;
        private List<Pictogramas_BienMal> actividadesSeguridad;
        private List<Pictogramas_BienMal> actividadesEmociones;


        private int indiceActual;

        public Pictogramas_Actividades(Principal_actividades anterior)
        {
            InitializeComponent();  
            InicializarActividades();
            MostrarActividad();
        }

        private void InicializarActividades()
        {
            panel5.Visible = false;
            button2.Visible = false;

            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Inicial\"));

            actividadesHigiene = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Higiene\"));
            actividadesAula = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Aula\"));
            actividadesAmigos = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Amigos\"));
            actividadesSocial = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Social\"));
            actividadesSeguridad = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Seguridad\"));
            actividadesEmociones = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Emociones\"));

            

            // Establecer cualquier lista como inicial
            // actividades = actividadesHigiene;

            //Por lo pronto quiero que sea Inicial asi que la voy a dejar con 0 para que inicie con esa
            indiceActual = 0;
        }

        private List<Pictogramas_BienMal> CargarImagenesDesdeCarpeta(string rutaCarpeta)
        {
            var listaActividades = new List<Pictogramas_BienMal>();

           
            if (Directory.Exists(rutaCarpeta))
            {
                
                string rutaBueno = Path.Combine(rutaCarpeta, "Bueno");
                string rutaMalo = Path.Combine(rutaCarpeta, "Malo");

                CargarImagenesDeSubcarpeta(rutaBueno, true, listaActividades);

                CargarImagenesDeSubcarpeta(rutaMalo, false, listaActividades);
            }
            else
            {
                MessageBox.Show("La carpeta no existe: " + rutaCarpeta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaActividades;
        }

        private void CargarImagenesDeSubcarpeta(string rutaSubcarpeta, bool esBuenaAccion, List<Pictogramas_BienMal> listaActividades)
        {
            if (Directory.Exists(rutaSubcarpeta))
            {
                
                string[] archivosImagenes = Directory.GetFiles(rutaSubcarpeta, "*.png");

                foreach (string archivo in archivosImagenes)
                {
                    listaActividades.Add(new Pictogramas_BienMal(archivo, esBuenaAccion));
                }
            }
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
               
                MessageBox.Show("¡Felicidades! Has completado todas las actividades.", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
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

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            button1.Visible = false;
            button2.Visible = true;

            panel5.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            button2.Visible = false;

           
            panel5.Visible = false;
        }

        private void btn_Higiene_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Higiene\"));
            indiceActual = 0;
            MostrarActividad();
        }

        private void btn_Aula_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Aula\"));
            indiceActual = 0;
            MostrarActividad();
        }

        private void btn_Amigos_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Amigos\"));
            indiceActual = 0;
            MostrarActividad();
        }

        private void btn_Social_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Social\"));
            indiceActual = 0;
            MostrarActividad();
        }

        private void btn_Seguridad_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Seguridad\"));
            indiceActual = 0;
            MostrarActividad();
        }

        private void btn_Emociones_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            actividades = CargarImagenesDesdeCarpeta(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Bien_Mal\Emociones\"));
            indiceActual = 0;
            MostrarActividad();
        }
    }
}
