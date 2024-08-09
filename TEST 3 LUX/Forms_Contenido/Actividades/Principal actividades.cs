using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Pictogramas.Puzzlee;

namespace TEST_3_LUX.FORMS
{
    public partial class Principal_actividades : Form
    {
    
        string Transicion;
       

        public Principal_actividades()
        {
            InitializeComponent();
            

        }

        private void Principal_actividades_Load(object sender, EventArgs e)
        {
           

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
            panel2.Visible = false;
            panel3.Visible = false;

            panel1.Visible = !panel1.Visible;
            



           
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;

            panel2.Visible = !panel2.Visible;
            

        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = false;

            panel3.Visible = !panel3.Visible;
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

        
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            Pictogramas_Actividades pictogramas_Actividades = new Pictogramas_Actividades(this);
            pictogramas_Actividades.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Puzzle puzzle = new Puzzle();
            puzzle.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calcar_Actividades ca = new Calcar_Actividades();
            ca.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DibujarActividades da = new DibujarActividades();
            da.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DibujarEscritura_Actividades dea = new DibujarEscritura_Actividades();
            dea.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
