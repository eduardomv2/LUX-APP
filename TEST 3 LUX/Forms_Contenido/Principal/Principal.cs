using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;
using TEST_3_LUX.FORMS.Comunicacion3;

namespace TEST_3_LUX
{
    public partial class Principal : Form
    {


        public Principal()
        {
            InitializeComponent();
            panel2.Visible = false;

        }
  
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }



        #region BOTONES PARA MANEJO DE VENTANA
        private void button1_Click(object sender, EventArgs e)
        {
            //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar y restaurar ventana
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar ventana
            Application.Exit();
        }
        #endregion



        #region BOTOENES PRINCIPALES DE MENU

        private void btnHorario_Click(object sender, EventArgs e)
        {

        }


        private void btnActividades_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComunicacion_Click(object sender, EventArgs e)
        {
           
        }


        #endregion

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Alternar la visibilidad de panel2
            panel2.Visible = !panel2.Visible;
        }

        private void btnActividades_Click_1(object sender, EventArgs e)
        {
            Principal_actividades act = new Principal_actividades();
            act.Show();
            this.Hide();
        }

        private void btnComunicacion_Click_1(object sender, EventArgs e)
        {
            ComunicacionPrincipal com = new ComunicacionPrincipal(this);
            com.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FUNCION PROVICIONAL HASTA TENER AL MENOS UN PROTOTIPO DE LA PAG

            //ABRIR GITHUB DEL PROYECTO
            System.Diagnostics.Process.Start("https://github.com/eduardomv2/LUX-APP");
        }
    }
}
