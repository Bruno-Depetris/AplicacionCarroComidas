using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Cierre {
        public int CierreID { get; set; }
        public double MontoFinal { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
    }

}
