using AplicacionCarroComidas.Private.DataBase.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Funcion.FormHistorial {
    internal class FuncionEliminar {
        public static void EliminarHistorial(int detalleVentaID) {
            try {

                LogicaDetalleVenta.Instancia.BorrarDetalleVenta(detalleVentaID);
 


            } catch (Exception ex) {
                MessageBox.Show("Error al eliminar el historial: " + ex.Message);
            }
        }
    }
}