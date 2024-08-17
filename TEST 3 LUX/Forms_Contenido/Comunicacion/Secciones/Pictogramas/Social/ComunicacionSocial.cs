using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS.Comunicacion3;
using TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados;
using TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Carga;
using TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Emergente.Eliminar;
using TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Impresion;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Pictogramas.Social
{
    public partial class ComunicacionSocial : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, bool wParam, int lParam);
        private const int WM_SETREDRAW = 0x000B;
        private bool isUpdating;
        private string Transicion;
        private bool Salida = false;
        private Timer scrollTimer;
        private string pdfFilePath = @"C:\Users\axel1\Downloads\abcLux.pdf";
        ComunicacionPrincipal comunicacionPrincipal;
        public ComunicacionSocial(ComunicacionPrincipal comunicacionPrincipal)
        {
            InitializeComponent();

            this.comunicacionPrincipal = comunicacionPrincipal;

            // Eventos suscritos a una misma función
            ControlAdded += new ControlEventHandler(Form_ControlChanged);
            ControlRemoved += new ControlEventHandler(Form_ControlChanged);

            // Inicializar el temporizador
            scrollTimer = new Timer();
            scrollTimer.Interval = 50; // 50 ms de inactividad
            scrollTimer.Tick += ScrollTimer_Tick;
        }

        private void ComunicacionSocial_Load(object sender, EventArgs e)
        {

        }

        #region CABECERA DE VENTANA
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            comunicacionPrincipal.Mostrar();
            isUpdating = true;
            this.Close();
        }
        private void btnEmociones_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\Emociones");
        }
        private void btnSiNo_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\SiNo");
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\Bebidas");
            //GenerarBotones(@"Resources\Comunicacion\Social\Bebidas\Cargados");
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\Alimentos");
            //GenerarBotones(@"Resources\Comunicacion\Social\Alimentos\Cargados");
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\Objetos");
            //GenerarBotones(@"Resources\Comunicacion\Social\Objetos\Cargados");
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            GenerarBotones(@"Resources\Comunicacion\Social\Personas");
            //GenerarBotones(@"Resources\Comunicacion\Social\Personas\Cargados");
        }
        #endregion

        public void GenerarBotones(string directoryPath)
        {
            flpTabla.SuspendLayout();
            flpTabla.Controls.Clear();

            string[] imageFiles = Directory
            .GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryPath), "*.*")
            .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                           file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                           file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                           file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                           file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
            .ToArray();

            foreach (string file in imageFiles)
            {
                flpTabla.Controls.Add(new RBotonProp(Path.GetFileNameWithoutExtension(file), file, doubleBufferedFlowLayoutPanel1));
            }
            flpTabla.ResumeLayout();
        }

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
                        comunicacionPrincipal.Show();
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
        }
        #endregion

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            scrollTimer.Stop();
            ResumeDrawing(this);
        }

        private void btnCargarImagenes_Click(object sender, EventArgs e)
        {
            using (SeleccionImagen select = new SeleccionImagen())
            {
                select.ShowDialog();
                select.Dispose();
            } 
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (SeleccionPDFSocial select = new SeleccionPDFSocial())
            {
                select.ShowDialog();
                select.Dispose();
            }    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ComunicacionEliminarTarjeta elmn = new ComunicacionEliminarTarjeta())
            {
                elmn.ShowDialog();
                elmn.Dispose();
            }
        }

        private void btnBorrarMensaje_Click(object sender, EventArgs e)
        {
            doubleBufferedFlowLayoutPanel1.Controls.Clear();
        }

        private async void btnReproducirMensaje_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            foreach (RBotonProp ctrl in doubleBufferedFlowLayoutPanel1.Controls)
            {
                speech.SpeakAsync(ctrl.textoLeer);
                await Task.Delay(1000);
            }
        }

        private void btnUpSuperior_Click(object sender, EventArgs e)
        {
            int change = doubleBufferedFlowLayoutPanel2.VerticalScroll.Value - doubleBufferedFlowLayoutPanel2.VerticalScroll.SmallChange * 25;
            doubleBufferedFlowLayoutPanel2.AutoScrollPosition = new Point(0, change);
        }

        private void btnDownSuperior_Click(object sender, EventArgs e)
        {
            int change = doubleBufferedFlowLayoutPanel2.VerticalScroll.Value + doubleBufferedFlowLayoutPanel2.VerticalScroll.SmallChange * 25;
            doubleBufferedFlowLayoutPanel2.AutoScrollPosition = new Point(0, change);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int change = doubleBufferedFlowLayoutPanel1.VerticalScroll.Value - doubleBufferedFlowLayoutPanel1.VerticalScroll.SmallChange * 6;
            doubleBufferedFlowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int change = doubleBufferedFlowLayoutPanel1.VerticalScroll.Value + doubleBufferedFlowLayoutPanel1.VerticalScroll.SmallChange * 6;
            doubleBufferedFlowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }
    }
}
