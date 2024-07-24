using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.FORMS
{
    public partial class Principal_actividades : Form
    {
  


        public Principal_actividades()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Abrir formulario de actividades
            Principal pr = new Principal();
            pr.Show();
            this.Hide();
        }


        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {
            panelContenedor.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        private void panelContenedor_Resize(object sender, EventArgs e)
        {
           
        }

        private void Principal_actividades_Resize(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //abrir formulario de DibujarActividades
            DibujarActividades dib = new DibujarActividades();
            dib.Show();
            this.Hide();
        }
    }
}
