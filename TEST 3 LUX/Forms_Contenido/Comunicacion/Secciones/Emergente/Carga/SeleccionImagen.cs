using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Carga
{
    public partial class SeleccionImagen : Form
    {
        private string mensaje = "Selecciona un apartado para crear una tarjeta";
        SpeechSynthesizer spech;
        public SeleccionImagen()
        {
            InitializeComponent();
            spech = new SpeechSynthesizer();
        }

        private void SeleccionImagen_Load(object sender, EventArgs e)
        {
            spech.SpeakAsync(mensaje);
            tmMensaje.Interval = 15000;
            tmMensaje.Start();
        }

        private void tmMensaje_Tick(object sender, EventArgs e)
        {
            spech.SpeakAsync(mensaje);
        }

        #region OPCIONES
        private void btnSiNo_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\SiNo"));
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Alimentos"));
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Personas"));
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Bebidas"));
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Objetos"));
        }

        private void btnEmociones_Click(object sender, EventArgs e)
        {
            CargarImagen(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Emociones"));
        }
        #endregion

        private void CargarImagen(string directoryPath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Selecciona la imagen a cargar";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                spech.SpeakAsync("Hubo un problema");
                Close();
            }

            try
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    // Cargar la imagen seleccionada por el usuario
                    Image userImage = Image.FromFile(file);

                    // Cargar la plantilla base
                    Image templateImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\CartaBase\baseDibujado.png"));

                    // Crear un bitmap nuevo donde se combinarán ambas imágenes
                    Bitmap finalImage = new Bitmap(templateImage.Width, templateImage.Height);

                    // Usar Graphics para dibujar sobre la imagen final
                    using (Graphics g = Graphics.FromImage(finalImage))
                    {
                        // Dibujar la plantilla
                        g.DrawImage(templateImage, new Point(0, 0));

                        // Dibujar la imagen del usuario en la posición deseadads
                        g.DrawImage(userImage, new Rectangle(35, 30, 342, 500));
                    }
                    finalImage.Save(Path.Combine(directoryPath, Path.GetFileName(file)), ImageFormat.Png);
                    spech.SpeakAsync($"Se agrego {Path.GetFileNameWithoutExtension(file)} a las tarjetas");
                }
            }
            catch (Exception ex)
            {
                spech.SpeakAsync("Hubo un problema");
            }

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionImagen_Click(object sender, EventArgs e)
        {
            tmMensaje.Interval += 20000;
        }
    }
}
