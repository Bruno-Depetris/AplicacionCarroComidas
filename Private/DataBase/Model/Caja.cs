using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Caja {
        public int IdCaja { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? HoraCierre { get; set; }
        public double CambioInicial { get; set; }
        public double? CambioFinal { get; set; }
        public string Estado { get; set; } // ABIERTA o CERRADA
    }

}
