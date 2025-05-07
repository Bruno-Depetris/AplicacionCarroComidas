using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Apertura {
        public int AperturaID { get; set; }
        public double MontoInicio { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
    }

}
