using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Comida {
        public int ComidaID { get; set; }
        public string NombreComida { get; set; }
        public decimal Precio { get; set; }
    }

}
