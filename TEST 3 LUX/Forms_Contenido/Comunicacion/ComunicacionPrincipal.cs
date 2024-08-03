using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS.Comunicacion.Controles_personalizados;
using TEST_3_LUX.FORMS.Comunicacion.Menus_secundarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TEST_3_LUX.FORMS.Comunicacion3
{
    public partial class ComunicacionPrincipal : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, bool wParam, int lParam);
        private const int WM_SETREDRAW = 0x000B;
        private Principal FormPrincipal;
        private bool isUpdating;
        private string Transicion;
        private bool Salida = false;

        /// <summary>
        /// Genera una instancia del apartado de Comunicación tomando de referencia la posición en pantalla de la instancia recibida
        /// </summary>
        /// <param name="main">Se utiliza para no perder instancia del formulario "principal" en memoria y en tiempo de compilación</param>
        public ComunicacionPrincipal(Principal main)
        {
            InitializeComponent();
            this.FormPrincipal = main;
            this.WindowState = FormWindowState.Maximized;

            // Eventos suscritos a una misma función
            this.ControlAdded += new ControlEventHandler(Form_ControlChanged);
            this.ControlRemoved += new ControlEventHandler(Form_ControlChanged);

            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            SuspendDrawing(this);
            SuspendDrawing(tlpBotonesTemas);
            SuspendDrawing(flowLayoutPanel1);
            SuspendDrawing(panel1);

            btnRetroceder.SuspendLayout();
            btnTablaPictograma.SuspendLayout();
            btnNotasAudio.SuspendLayout(); 
        }

        private async void ComunicacionPrincipal_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);

            ResumeDrawing(this);
            ResumeDrawing(flowLayoutPanel1);
            ResumeDrawing(panel1);

            btnRetroceder.ResumeLayout();
            btnTablaPictograma.ResumeLayout();
            btnNotasAudio.ResumeLayout();

            isUpdating = true;
            ResumeDrawing(tlpBotonesTemas);
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
        }

        #region CABECERA DE VENTANA
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            SuspendDrawing(flowLayoutPanel1);
            flowLayoutPanel1 = null;

            Transicion = "FadeOut";
            isUpdating = true;
            Salida = true;
            tmCarga.Start();
        }
        private void btnTablaPictograma_Click(object sender, EventArgs e)
        {
            ComunicacionPictogramas cpm = new ComunicacionPictogramas(this);
            Transicion = "FadeOut";
            isUpdating = true;
            Salida = false;
            tmCarga.Start();
            cpm.Mostrar();
        }
        private void btnNotasAudio_Click(object sender, EventArgs e)
        {
            ComunicacionTTS tts = new ComunicacionTTS(this);
            Transicion = "FadeOut";
            isUpdating = true;
            Salida = false;
            tmCarga.Start();
            tts.Mostrar();
        }
        #endregion

        #region TEMAS DE CHARLA
        private void btnTemaAmarillo_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaAmarillo.csv");
            GenerarTabla(filePath, typeof(RBotonAmarillo));
        }

        private void btnTemaRojo_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaRojo.csv");
            GenerarTabla(filePath, typeof(RBotonRojo));
        }

        private void btnTemaVerde_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Temas de charla\TemaVerde.csv");
            GenerarTabla(filePath, typeof(RBotonVerde));
        }
        #endregion

        #region METODOS RELACIONADOS CON LA GENERACION DE DE BOTONES
        /// <summary>
        /// Genera a partir de un CSV una lista de botones en un TableLayoutPanel
        /// </summary>
        /// <param name="filePath">Ruta del archivo CSV con los mensajes a graficar para narrar</param>
        public void GenerarTabla(string filePath, Type btn)
        {
            SuspendDrawing(flowLayoutPanel1);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            int columnCount = 5;
            int controlWidth = flowLayoutPanel1.ClientSize.Width / columnCount - flowLayoutPanel1.Margin.Horizontal;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    string[] values = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        values = line.Split(',');
                    }

                    // Añadir botones al FlowLayoutPanel
                    for (int i = 0; i < values.Length; i++)
                    {
                        Button nuevoBoton = (Button)Activator.CreateInstance(btn);
                        nuevoBoton.Text = values[i];
                        nuevoBoton.Visible = true;
                        nuevoBoton.Width = controlWidth;

                        flowLayoutPanel1.Controls.Add(nuevoBoton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer CSV: " + ex.Message);
            }

            // Reanudar el dibujo después de un pequeño retraso
            Timer timer = new Timer();
            timer.Interval = 60; // 60 ms delay
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                flowLayoutPanel1.ResumeLayout();
                ResumeDrawing(flowLayoutPanel1);
                flowLayoutPanel1.Refresh(); // Forzar el repintado
            };
            timer.Start();
        }
        #endregion

        #region DIBUJADO DEL FORMULARIO
        /// <summary>
        /// Suspende las funciones de dibujo del control recibido
        /// </summary>
        /// <param name="parent">Control al que se le suspenderán sus funciones de dibujo</param>
        private void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        /// <summary>
        /// Reanuda las funciones de dibujo del control recibido
        /// </summary>
        /// <param name="parent">Control al que se le reanudaran sus funciones de dibujo</param>
        private void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
           
        }

        /// <summary>
        /// Función encargada de manejar los eventos "ControlAdded" y "ControlRemoved"
        /// </summary>
        /// <param name="sender">Control recibido</param>
        /// <param name="e">Evento que recibe o evento suscrito</param>
        private void Form_ControlChanged(object sender, ControlEventArgs e)
        {
            if (!isUpdating)
            {
                isUpdating = true;
                SuspendDrawing(this);

                // Reanudación después de un breve retraso para que todos los cambios se procesen
                Timer timer = new Timer();
                timer.Interval = 10; // 10 ms delay
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    ResumeDrawing(this);
                    isUpdating = false;
                };
                timer.Start();
            }
        }
        #endregion

        #region ANIMACIONES DE ENTRADA Y SALIDA
        private void tmCarga_Tick(object sender, EventArgs e)
        {
            if (Transicion == "FadeIn")
            {
                if (Opacity == 1)
                {
                    tmCarga.Stop();
                }
                Opacity += .15;
                Top -= 3;
            }
            else if (Transicion == "FadeOut")
            {
                if (Opacity == 0)
                {
                    tmCarga.Stop();
                    if (Salida)
                    {
                        FormPrincipal.Show();
                        Dispose();
                    }
                    else
                    {
                        Hide();
                    }
                }

                Opacity -= .15;
                Top += 3;
            }
        }
        #endregion

        #region FUNCIONES OVERRIDE O SIMILARES
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_SIZE = 0x0005;
            const int WM_PAINT = 0x000F;
            const int WM_WINDOWPOSCHANGED = 0x0047;

            if (m.Msg == WM_SIZE || m.Msg == WM_PAINT || m.Msg == WM_WINDOWPOSCHANGED)
            {
                Form_ControlChanged(this, null);
            }
        }

        // Nuevo método personalizado para mostrar el formulario
        public async void Mostrar()
        {
            Transicion = "FadeIn";
            isUpdating = true;
            Salida = true;

            Show();
            await Task.Delay(10);
            tmCarga.Start();
        }
        #endregion
    }
}