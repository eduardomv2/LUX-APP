using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.FORMS.Comunicacion.Controles_personalizados
{
    public class RBotonVerde : Button
    {
        private const string imagePath = @"Resources\Comunicacion\Temas de botones\Desplegados\temaVerde.png";

        /// <summary>
        /// Genera un botón con una imagen guardada en un subdirectorio de "Resources" ubicado en "Debug"
        /// </summary>
        public RBotonVerde()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            this.BackgroundImage = Image.FromFile(fullPath);
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.Black;
            this.Location = new Point(3, 3);
            this.Size = new Size(213, 63);
            this.TabIndex = 6;
            this.Text = "Lorem ipsum";
            this.UseVisualStyleBackColor = false;
        }

        // Exponer el evento Click como propiedad
        public event EventHandler Click
        {
            add { base.Click += value; }
            remove { base.Click -= value; }
        }

        protected override void OnClick(EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.SpeakAsync(this.Text);
        }
    }
}
