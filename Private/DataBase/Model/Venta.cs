using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Venta {
        public int HistorialID { get; set; }
        public int CajaID { get; set; }
        public int ProductoID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string FormaPago { get; set; } = string.Empty;
    }

}
