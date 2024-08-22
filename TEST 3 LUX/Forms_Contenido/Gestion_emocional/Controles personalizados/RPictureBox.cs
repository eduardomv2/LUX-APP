using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Gestion_emocional.Controles_personalizados
{
    public class RPictureBox : PictureBox
    {
        public string NombreRecurso {  get; set; }
        public RPictureBox(Image img, string nombreRecurso) 
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = img;
            NombreRecurso = nombreRecurso;
            Size = new Size(270, 150);
        }

    }
}
