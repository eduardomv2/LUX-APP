using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEST_3_LUX
{
    public partial class DibujarEscritura_Actividades : Form
    {
        private List<string> imagenes;
        private Random random;

        public DibujarEscritura_Actividades()
        {
            InitializeComponent();

            this.Width = 1300;
            this.Height = 910;
            pic.Size = new Size(this.Width, this.Height);
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            this.Resize += new EventHandler(Form_Resize);

            // Configurar el TrackBar para ajustar el grosor del lápiz
            trackBar2.Minimum = 1;
            trackBar2.Maximum = 20;
            trackBar2.Value = 1;
            trackBar2.TickFrequency = 1;
            trackBar2.Scroll += new EventHandler(trackBar2_Scroll);

            CargarImagenes();
            random = new Random();

        }



        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int cX, cY, sX, sY;

        ColorDialog cd = new ColorDialog();
        Color new_Color;



        private void CargarImagenes()
        {
            // Obtener la ruta base del directorio donde se está ejecutando la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta completa a la carpeta de imágenes relativa a la ruta base
            string carpetaImagenes = Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Dibujar\Dibujar_Escritura\Recursos_DibujarEscritura\");

            // Verificar si la carpeta de imágenes existe
            if (Directory.Exists(carpetaImagenes))
            {
                // Obtener todas las imágenes en la carpeta
                imagenes = Directory.GetFiles(carpetaImagenes, "*.jpg")
                    .Concat(Directory.GetFiles(carpetaImagenes, "*.png"))
                    .Concat(Directory.GetFiles(carpetaImagenes, "*.jpeg"))
                    .ToList();
            }
            else
            {
                MessageBox.Show("La carpeta de imágenes no se encontró: " + carpetaImagenes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

          
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Hide();

        }

       

       

       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
            {
                MessageBox.Show("No se encontraron imágenes en la carpeta.");
                return;
            }

            string imagenSeleccionada = imagenes[random.Next(imagenes.Count)];
            MostrarImagen(imagenSeleccionada);
        }


        private void MostrarImagen(string rutaImagen)
        {
            Image imagen = Image.FromFile(rutaImagen);
            panel4.BackgroundImage = imagen;
            panel4.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar la imagen al tamaño del panel
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.Filter = "Image(*.jpg) | *.jpg | *.* | *.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(save.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada con exito");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // Actualizar el grosor del lápiz según el valor del TrackBar
            p.Width = trackBar2.Value;
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX - cX, sY - cY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX - cX, sY - cY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, sX, sY);
                }
            }
        }

        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(pictureBox1, e.Location);
            button4.BackColor = ((Bitmap)pictureBox1.Image).GetPixel(point.X, point.Y);
            new_Color = button4.BackColor;
            p.Color = button4.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_Color);
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void DibujarEscritura_Actividades_Resize(object sender, EventArgs e)
        {

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = SetPoint(pic, e.Location);
                Fill(bm, point.X, point.Y, new_Color);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            pic.Size = new Size(this.Width, this.Height);
            Bitmap newBm = new Bitmap(pic.Width, pic.Height);
            Graphics newG = Graphics.FromImage(newBm);
            newG.Clear(Color.White);
            newG.DrawImage(bm, 0, 0);

            bm = newBm;
            g = Graphics.FromImage(bm);
            pic.Image = bm;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, py, px);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, py, px);
                    py = px;
                }
            }
            pic.Refresh();

            sX = e.X;
            sY = e.Y;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = e.X;
            sY = e.Y;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX - cX, sY - cY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX - cX, sY - cY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, sX, sY);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //alternar visibilidad del panel4
            panel4.Visible = !panel4.Visible;

            //alternar color del botón verde y rojo
            button2.BackColor = panel4.Visible ? Color.ForestGreen : Color.Red;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //abrir formulario principal actividades
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        public void Fill(Bitmap bm, int x, int y, Color new_Color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_Color);
            if (old_color == new_Color) return;

            while (pixel.Count > 0)
            {
                Point pt = pixel.Pop();
                if (pt.X > 0 && pt.X < bm.Width - 1 && pt.Y > 0 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_Color);
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_Color);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_Color);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_Color);
                }
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {

            cd.ShowDialog();
            new_Color = cd.Color;
            button4.BackColor = cd.Color;
            p.Color = cd.Color;
        }
    }
}
