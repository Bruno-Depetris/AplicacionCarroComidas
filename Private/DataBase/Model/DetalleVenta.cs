using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class DetalleVenta {
        public int DetalleVentaID { get; set; }
        public string MedioPago { get; set; } = string.Empty;
        public string Productos { get; set; } = string.Empty;
        public double Total { get; set; }
        public int AperturaID { get; set; }
    }

}
