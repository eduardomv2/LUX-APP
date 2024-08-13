using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Teclado.Escribir_Libre
{
    public partial class Escribir_Libre : Form
    {
        public Escribir_Libre()
        {
            InitializeComponent();
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal_actividades principal = new Principal_actividades();
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          

        }





        


        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Crear un OpenFileDialog para seleccionar una imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
            }
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

        private void Escribir_Libre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GuardarPanelComoImagen(panel2);
        }
    }
}
