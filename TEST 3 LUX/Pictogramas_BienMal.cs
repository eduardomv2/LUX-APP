using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3_LUX
{


    public class Pictogramas_BienMal
    {
        public string RutaImagen { get; set; }
        public bool EsBuenaAccion { get; set; }

        public Pictogramas_BienMal(string rutaImagen, bool esBuenaAccion)
        {
            RutaImagen = rutaImagen;
            EsBuenaAccion = esBuenaAccion;
        }
    }



}
