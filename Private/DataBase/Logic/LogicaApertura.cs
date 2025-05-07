using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaApertura {
        private static LogicaApertura _instancia;
        public static LogicaApertura Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaApertura();
                }
                return _instancia;
            }
        }

        public bool CargarApertura(Apertura apertura) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "INSERT INTO Aperturas (MontoInicio, Fecha, Hora) VALUES (@monto, @fecha, @hora)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@monto", apertura.MontoInicio);
                    cmd.Parameters.AddWithValue("@fecha", apertura.Fecha);
                    cmd.Parameters.AddWithValue("@hora", apertura.Hora);
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
