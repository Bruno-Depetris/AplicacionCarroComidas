using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Model {
    public class Producto {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}

