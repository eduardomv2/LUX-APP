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

namespace TEST_3_LUX.FORMS.Comunicacion.Menus_secundarios
{
    public partial class ComunicacionTTS : Form
    {
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public ComunicacionTTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync(textBox1.Text);
        }
    }
}
