using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX
{
    public partial class DibujarActividades : Form
    {
        public DibujarActividades()
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
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = 1;
            trackBar1.TickFrequency = 1;
            trackBar1.Scroll += new EventHandler(trackBar1_Scroll);

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

       

        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(colorPicker, e.Location);
            picColor.BackColor = ((Bitmap)colorPicker.Image).GetPixel(point.X, point.Y);
            new_Color = picColor.BackColor;
            p.Color = picColor.BackColor;
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

        #region eventos del pickColor
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

        

        

        private void btnColor_Click_1(object sender, EventArgs e)
        {

            cd.ShowDialog();
            new_Color = cd.Color;
            picColor.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        

       

       

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            //Retroceder a la ventana principal
           Principal_actividades pa = new Principal_actividades();
           pa.Show();
           this.Hide();

        }

        private void btnLLenar_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DibujarActividades_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Actualizar el grosor del lápiz según el valor del TrackBar
            p.Width = trackBar1.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btnBorrador_Click_1(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnLapiz_Click_1(object sender, EventArgs e)
        {
            index = 1;
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

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }
        #endregion


        
    }
}
