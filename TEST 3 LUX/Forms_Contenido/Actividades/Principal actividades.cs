﻿using System;
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

        private Pictogramas_Actividades pictogramasActividades;



        public Principal_actividades()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;


        }

        private void Principal_actividades_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            

            
        }

        

       
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
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
            // Alternar la visibilidad de panel2
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            DibujarActividades dibujarActividades = new DibujarActividades();
            dibujarActividades.Show();
            this.Hide();
        }

        private void panelActividadesSubBotones_Paint_1(object sender, PaintEventArgs e)
        {
            panelActividadesSubBotones.BackColor = Color.FromArgb(128, 0, 0, 0);
        }
    }
}
