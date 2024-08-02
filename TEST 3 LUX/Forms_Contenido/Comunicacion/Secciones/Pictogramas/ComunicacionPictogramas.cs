using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_3_LUX.FORMS.Comunicacion3;

namespace TEST_3_LUX.FORMS.Comunicacion.Menus_secundarios
{
    public partial class ComunicacionPictogramas : Form
    {
        private ComunicacionPrincipal principalComunicacion;

        /// <summary>
        /// Constructor del formulario que mantiene instancia de su ventana antecesora
        /// </summary>
        /// <param name="principalComunicacion">Se usa para mentener noción de la ventana "ComunicacionPrincipal"</param>
        public ComunicacionPictogramas(ComunicacionPrincipal principalComunicacion)
        {
            InitializeComponent();
            this.principalComunicacion = principalComunicacion;
        }

        private void ComunicacionPictogramas_Load(object sender, EventArgs e)
        {

        }

        #region CABECERA DE VENTANA
        private void btnRetroceder_Click_1(object sender, EventArgs e)
        {
            this.Close();
            principalComunicacion.Mostrar();
        }
        #endregion
    }
}
