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
        private DoubleBufferedFlowLayoutPanel flowLayoutPanel;
        public string textoLeer { get; set; }

        public RBotonProp(string textoLeer, string imagen, DoubleBufferedFlowLayoutPanel panel = null)
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
            flowLayoutPanel = panel;
        }

        public RBotonProp(string textoLeer)
        {
            this.textoLeer = textoLeer;
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

            if (flowLayoutPanel != null && flowLayoutPanel.Controls.Count <= 4)
            {
                RBotonProp copia = new RBotonProp(textoLeer);
                copia.BackgroundImage = BackgroundImage;
                copia.BackgroundImageLayout = ImageLayout.Zoom;
                copia.FlatAppearance.BorderSize = 0;
                copia.FlatAppearance.MouseDownBackColor = Color.Transparent;
                copia.FlatAppearance.MouseOverBackColor = Color.Transparent;
                copia.FlatStyle = FlatStyle.Flat;
                copia.Size = new Size(119, 172);
                copia.TabIndex = 0;
                copia.UseVisualStyleBackColor = true;
                flowLayoutPanel.Controls.Add(copia);
            }
        }
    }
}
