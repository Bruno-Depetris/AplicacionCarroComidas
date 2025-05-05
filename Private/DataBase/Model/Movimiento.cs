using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Movimiento {
        public int MovimientoID { get; set; }
        public int CajaID { get; set; }
        public string MovimientoDescripcion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Accion { get; set; } = string.Empty; // 'Ingreso' o 'Egreso'
        public string Forma { get; set; } = string.Empty;  // 'Efectivo', 'Transferencia', etc.
        public decimal Monto { get; set; }
    }

}
