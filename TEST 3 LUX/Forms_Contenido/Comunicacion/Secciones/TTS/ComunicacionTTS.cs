using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using TEST_3_LUX.FORMS.Comunicacion3;

namespace TEST_3_LUX.FORMS.Comunicacion.Menus_secundarios
{
    public partial class ComunicacionTTS : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, bool wParam, int lParam);
        private const int WM_SETREDRAW = 0x000B;
        private bool isUpdating;
        private string Transicion;
        private bool Salida = false;
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private ComunicacionPrincipal cmp;
        public ComunicacionTTS(ComunicacionPrincipal cmp)
        {
            InitializeComponent();

            // Eventos suscritos a una misma función
            ControlAdded += new ControlEventHandler(Form_ControlChanged);
            ControlRemoved += new ControlEventHandler(Form_ControlChanged);

            this.cmp = cmp;
            cmp.Enabled = false;

            isUpdating = true;
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);
            SuspendDrawing(this);
            SuspendDrawing(panel21);
            SuspendDrawing(txtMensajeNota);
        }

        private async void ComunicacionTTS_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);
            ResumeDrawing(this);
            ResumeDrawing(panel21);
            ResumeDrawing(txtMensajeNota);
            SendMessage(this.Handle, WM_SETREDRAW, true, 0);
            this.Refresh();
        }

        #region CABECERA DE VENTANA
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            isUpdating = true;
            Transicion = "FadeOut";
            Salida = true;
            tmCarga.Start();
            cmp.Mostrar();
            cmp.Enabled = true;
        }
        #endregion

        #region FUNCIONES PARA TEXTO
        private void btnHablar_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync(txtMensajeNota.Text);
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
            parent.Invalidate();

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
                        cmp.Show();
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
        public void Mostrar()
        {
            Transicion = "FadeIn";
            isUpdating = true;
            Salida = true;
            Show();
            tmCarga.Start();
        }
        #endregion

       
    }
}
