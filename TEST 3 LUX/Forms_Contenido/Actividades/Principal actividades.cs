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
    
        string Transicion;


        public Principal_actividades()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;  

        }

        private void Principal_actividades_Load(object sender, EventArgs e)
        {
            //button3.Image = Image.FromFile("C:\\Users\\eduar\\source\\repos\\LUX-APP\\TEST 3 LUX\\Forms_Contenido\\Actividades\\GIF\\011535.gif");

            this.Top = this.Top + 15;
            Transicion = "FadeIn";
            tmTransicion.Start();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            

            
        }

        

       
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Transicion = "FadeOut";
            tmTransicion.Start();

        }

        private void btnPictogramas_Click(object sender, EventArgs e)
        {
            //Abrir formulario de Pictogramas
            Pictogramas_Actividades pictogramas_Actividades = new Pictogramas_Actividades(this);
            pictogramas_Actividades.Show();
            this.Hide();



           
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //tableLayoutPanel1
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;
         
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir formulario de dibujar
            DibujarActividades dibujarActividades = new DibujarActividades();
            dibujarActividades.Show();
            this.Hide();
        }

       

        

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            DibujarActividades dibujarActividades = new DibujarActividades();
            dibujarActividades.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmTransicion_Tick(object sender, EventArgs e)
        {     
            if (Transicion == "FadeIn")
            {
                if (this.Opacity == 1)
                {
                    tmTransicion.Stop();
                }
                else
                {
                    this.Opacity = this.Opacity + .15;
                    this.Top = this.Top - 3;
                }
            }
            else if (Transicion == "FadeOut")
            {
                if (this.Opacity == 0)
                {
                    Principal principal = new Principal();
                    principal.Show();
                    tmTransicion.Stop();
                    this.Dispose();
                }
                else
                {
                    this.Opacity = this.Opacity - .15;
                    this.Top = this.Top + 3;
                }
            }
            else if (Transicion == "FadeOutExit")
            {
                if (this.Opacity == 0)
                {
                    tmTransicion.Stop();
                    Application.Exit();
                }
                else
                {
                    this.Opacity = this.Opacity - .10;
                    this.Left = this.Left + 3;
                }
            }
        }
    }
}
