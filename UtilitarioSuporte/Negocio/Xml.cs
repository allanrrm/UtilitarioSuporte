using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitarioSuporte.Negocio
{
    public class Xml
    {
        public int Autorizadas { get; set; }
        public int Canceladas { get; set; }
        public int Saltadas { get; set; }
        public double ValorTotal { get; set; }
        public double ValorTotalXml { get; set; }

        public Xml()
        {

        }

    }
}
