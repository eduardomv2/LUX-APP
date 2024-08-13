using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Teclado.Cartas
{
    public partial class Cartas : Form
    {
        public Cartas()
        {
            InitializeComponent();

            // Obtener la ruta base del directorio donde se está ejecutando la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Asignar eventos a los botones con rutas relativas
            button4.Click += (s, e) => CambiarImagenPanel(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Cartas\Recursos\Amigos_Familiares\"));
            button3.Click += (s, e) => CambiarImagenPanel(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Cartas\Recursos\Navidad\"));
            button2.Click += (s, e) => CambiarImagenPanel(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Cartas\Recursos\SanValentin\"));
            button1.Click += (s, e) => CambiarImagenPanel(Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Teclado\Cartas\Recursos\Cumpleaños\"));

            panel2.Visible = false;
        }

        private void Cartas_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Close();
        }


        private void CambiarImagenPanel(string rutaCarpeta)
        {
            // Obtiene el primer archivo de imagen en la carpeta
            string rutaImagen = Directory.GetFiles(rutaCarpeta, "*.jpg").FirstOrDefault() ??
                                Directory.GetFiles(rutaCarpeta, "*.png").FirstOrDefault();

            if (rutaImagen != null && File.Exists(rutaImagen))
            {
                panel2.BackgroundImage = Image.FromFile(rutaImagen);
                panel2.BackgroundImageLayout = ImageLayout.Stretch; // Ajusta la imagen según tus preferencias
            }
            else
            {
                MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }


        private void GuardarPanelComoImagen(Panel panel)
        {
            // Crear un Bitmap con el tamaño del Panel
            Bitmap bmp = new Bitmap(panel.ClientSize.Width, panel.ClientSize.Height);

            // Dibujar el contenido visible del Panel en el Bitmap
            panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.ClientSize.Width, panel.ClientSize.Height));

            // Guardar la imagen
            GuardarImagen(bmp);
        }

        private void GuardarImagen(Bitmap bmp)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.png; *.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            GuardarPanelComoImagen(panel2);
        }
    }
}
