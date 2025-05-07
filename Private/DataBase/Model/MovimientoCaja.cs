using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class MovimientoCaja {
        public int MovimientosCajaID { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // "Ingreso" o "Egreso"
        public double Monto { get; set; }
        public string Metodo { get; set; } = string.Empty; // efectivo, débito, etc.
        public int AperturaID { get; set; }
    }

}
