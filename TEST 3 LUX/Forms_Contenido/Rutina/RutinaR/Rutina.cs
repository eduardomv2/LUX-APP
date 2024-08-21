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

namespace TEST_3_LUX.Forms_Contenido.Rutina
{
    public partial class Rutina : Form
    {
      

        public Rutina()
        {
            InitializeComponent();

            // Configurar doble búfer para mejorar el rendimiento
            this.DoubleBuffered = true;

            // Asignar eventos de clic a los paneles
            AsignarEventosPaneles();
        }


        private void AsignarEventosPaneles()
        {
            // Asignar eventos a todos los paneles
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Click += Panel_Click;
                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel != null)
            {
                Cartas cartasForm = new Cartas();
                if (cartasForm.ShowDialog() == DialogResult.OK)
                {
                    panel.BackgroundImage = cartasForm.ImagenSeleccionada;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Rutina_Load(object sender, EventArgs e)
        {
           

            // Configurar PictureBox para mostrar GIFs
            ConfigurarPictureBox(pictureBox1, @"Forms_Contenido\Rutina\RutinaR\Recursos\Mañana1.gif");
            ConfigurarPictureBox(pictureBox2, @"Forms_Contenido\Rutina\RutinaR\Recursos\Tarde1.gif");
            ConfigurarPictureBox(pictureBox3, @"Forms_Contenido\Rutina\RutinaR\Recursos\Noche.gif");

        }

       

        private void ConfigurarPictureBox(PictureBox pictureBox, string rutaGif)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            string gifPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaGif);

            if (File.Exists(gifPath))
            {
                pictureBox.Image = Image.FromFile(gifPath);
            }
            else
            {
                MessageBox.Show("No se encontró el GIF en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            pr.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cartas ca = new Cartas();
            ca.Show();
            this.Hide();
        }
    }
}
