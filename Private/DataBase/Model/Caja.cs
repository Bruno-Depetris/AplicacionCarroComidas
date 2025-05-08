using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Caja {
        public int CajaID { get; set; }
        public int AperturaID { get; set; }
        public int? CierreID { get; set; }
        public double SaldoEfectivo { get; set; } = 0;
        public double SaldoDebito { get; set; } = 0;
        public double SaldoTransferencia { get; set; } = 0;
    }

}
