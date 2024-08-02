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
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private ComunicacionPrincipal cmp;
        public ComunicacionTTS(ComunicacionPrincipal cmp)
        {
            InitializeComponent();
            this.cmp = cmp;
        }

        #region CABECERA DE VENTANA
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmp.Mostrar();
        }
        #endregion

        #region FUNCIONES PARA TEXTO
        private void btnHablar_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync(txtMensajeNota.Text);
        }
        #endregion

    }
}
