using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Impresion
{
    public partial class SeccionPDFVocabulario : Form
    {
        private string mensaje = "Selecciona un botón para obtener tu pdf y poder llevarlo a imprimir";
        SpeechSynthesizer speechSynthesizer;
        public string _SeleccionPDF { get; set; }

        public SeccionPDFVocabulario()
        {
            InitializeComponent();
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakAsync(mensaje);
        }

        private void SeleccionPDF_Load(object sender, EventArgs e)
        {
            tmMensaje.Interval = 15000;
            tmMensaje.Start();
        }

        #region OPCIONES - BOTONES
        private void btnAbecedario_Click(object sender, EventArgs e)
        {
            CrearCopia(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Impresiones\Abecedario.pdf"));

        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            CrearCopia(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Impresiones\Colores.pdf"));
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            CrearCopia(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Impresiones\Animales.pdf"));
        }
        #endregion
        private void CrearCopia(string rutaOriginal)
        {
            try
            {
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string nombreArchivo = Path.GetFileName(rutaOriginal);
                string rutaDestino = Path.Combine(rutaEscritorio, nombreArchivo);
                File.Copy(rutaOriginal, rutaDestino, overwrite: true);
                speechSynthesizer.SpeakAsync("El archivo se ha copiado exitosamente en el escritorio.");
            }
            catch (Exception ex)
            {
                speechSynthesizer.SpeakAsync("Ocurrió un error al copiar el archivo");
            }
            this.Close();
        }

        private void tmMensaje_Tick(object sender, EventArgs e)
        {
            speechSynthesizer?.SpeakAsync(mensaje);
        }
    }
}
