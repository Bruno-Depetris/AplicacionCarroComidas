using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaCierre {
        private static LogicaCierre _instancia;
        public static LogicaCierre Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaCierre();
                }
                return _instancia;
            }
        }

        public bool CargarCierre(Cierre cierre) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "INSERT INTO Cierres (MontoFinal, Fecha, Hora) VALUES (@monto, @fecha, @hora)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@monto", cierre.MontoFinal);
                    cmd.Parameters.AddWithValue("@fecha", cierre.Fecha);
                    cmd.Parameters.AddWithValue("@hora", cierre.Hora);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }
    }

}
