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
    public partial class Cartas : Form
    {

        public Image ImagenSeleccionada { get; private set; }

        public Cartas()
        {
            InitializeComponent();
            ConfigurarFlowLayoutPanel();
            CargarYMostrarImagenes();
        }

        private void ConfigurarFlowLayoutPanel()
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Padding = new Padding(15, 5, 5, 5);

            // Desactivar el redibujado automático al agregar controles
            flowLayoutPanel1.SuspendLayout();
        }

        private void CargarYMostrarImagenes()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Forms_Contenido\\Rutina\\Cartas\\Recursos\\");

            if (flowLayoutPanel1 == null)
            {
                MessageBox.Show("FlowLayoutPanel no está inicializado.");
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            string[] archivosImagenes = Directory.GetFiles(rutaCarpeta, "*.png");

            if (archivosImagenes.Length == 0)
            {
                MessageBox.Show("No se encontraron imágenes en la carpeta: " + rutaCarpeta);
                return;
            }

            // Precargar y mostrar las imágenes
            foreach (string archivo in archivosImagenes)
            {
                using (var imagen = Image.FromFile(archivo))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = new Bitmap(imagen), // Crear un nuevo Bitmap para evitar problemas de acceso concurrente
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 200,
                        Height = 215,
                        Margin = new Padding(20),
                        BorderStyle = BorderStyle.None,
                        Cursor = Cursors.Hand // Cambiar el cursor al pasar por encima de la imagen
                    };

                    pictureBox.Click += (s, e) =>
                    {
                        ImagenSeleccionada = pictureBox.Image;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    };

                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }

            flowLayoutPanel1.ResumeLayout(true);
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin seleccionar ninguna imagen
            Rutina ru = new Rutina();
            ru.Show();
            this.Close();

        }
    } 

}
