using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Venta {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public string EstadoCobro { get; set; } // PENDIENTE o COBRADO
        public string MetodoPago { get; set; }  // EFECTIVO, TRANSFERENCIA, DEBITO, ''
        public int IdCaja { get; set; }
    }

}
