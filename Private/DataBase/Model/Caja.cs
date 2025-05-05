using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Caja {
        public int CajaID { get; set; }
        public decimal Apertura { get; set; }
        public decimal? Cierre { get; set; }
        public DateTime Fecha { get; set; }
    }

}
