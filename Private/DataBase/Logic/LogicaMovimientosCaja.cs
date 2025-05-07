using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaMovimientosCaja {
        private static LogicaMovimientosCaja _instancia;
        public static LogicaMovimientosCaja Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaMovimientosCaja();
                }
                return _instancia;
            }
        }

        // Mostrar MovimientosCaja (muestra todos los movimientos de una apertura)
        public DataTable MostrarMovimientosCaja(int aperturaID) {
            var tabla = new DataTable();
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT * FROM MovimientosCaja WHERE AperturaID = @aperturaID";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@aperturaID", aperturaID);
                    using (var da = new SQLiteDataAdapter(cmd)) {
                        da.Fill(tabla);
                    }
                }
            } catch {
                // Manejo de errores (puedes personalizarlo)
            } finally {
                cn?.Close();
            }
            return tabla;
        }

        // Editar MovimientosCaja
        public bool EditarMovimientoCaja(MovimientoCaja movimientoCaja) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "UPDATE MovimientosCaja SET Motivo = @motivo, Tipo = @tipo, Monto = @monto, Metodo = @metodo, AperturaID = @aperturaID WHERE MovimientosCajaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@motivo", movimientoCaja.Motivo);
                    cmd.Parameters.AddWithValue("@tipo", movimientoCaja.Tipo);
                    cmd.Parameters.AddWithValue("@monto", movimientoCaja.Monto);
                    cmd.Parameters.AddWithValue("@metodo", movimientoCaja.Metodo);
                    cmd.Parameters.AddWithValue("@aperturaID", movimientoCaja.AperturaID);
                    cmd.Parameters.AddWithValue("@id", movimientoCaja.MovimientosCajaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Borrar MovimientosCaja
        public bool BorrarMovimientoCaja(int movimientosCajaID) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "DELETE FROM MovimientosCaja WHERE MovimientosCajaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@id", movimientosCajaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Cargar MovimientosCaja (Insertar un nuevo movimiento)
        public bool CargarMovimientoCaja(MovimientoCaja movimientoCaja) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "INSERT INTO MovimientosCaja (Motivo, Tipo, Monto, Metodo, AperturaID) VALUES (@motivo, @tipo, @monto, @metodo, @aperturaID)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@motivo", movimientoCaja.Motivo);
                    cmd.Parameters.AddWithValue("@tipo", movimientoCaja.Tipo);
                    cmd.Parameters.AddWithValue("@monto", movimientoCaja.Monto);
                    cmd.Parameters.AddWithValue("@metodo", movimientoCaja.Metodo);
                    cmd.Parameters.AddWithValue("@aperturaID", movimientoCaja.AperturaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Imprimir MovimientosCaja (asíncrona)
        public async Task<bool> ImprimirMovimientoCajaAsync(int movimientosCajaID) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT * FROM MovimientosCaja WHERE MovimientosCajaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@id", movimientosCajaID);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {
                            // Lógica de impresión (dependiendo del tipo de impresión que uses)
                            // Simulación de impresión:
                            Console.WriteLine($"Imprimiendo movimiento de caja {movimientosCajaID}");
                            return true;
                        }
                    }
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
            return false;
        }
    }

}
