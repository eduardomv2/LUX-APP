using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Controles_personalizados
{
    public class RBotonProp : Button
    {
        public string textoLeer { get; set; }
        public RBotonProp(string textoLeer, string imagen)
        {
            this.textoLeer = textoLeer;
            BackgroundImage = Image.FromFile(imagen);
            BackgroundImageLayout = ImageLayout.Zoom;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(255, 375);
            TabIndex = 0;
            UseVisualStyleBackColor = true;

        }

        // Exponer el evento Click como propiedad
        public event EventHandler Click
        {
            add { base.Click += value; }
            remove { base.Click -= value; }
        }

        protected async override void OnClick(EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.SpeakAsync(textoLeer);
        }
    }
}
