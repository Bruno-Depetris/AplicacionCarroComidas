using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaDetalleVenta {
        private static LogicaDetalleVenta _instancia;
        public static LogicaDetalleVenta Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaDetalleVenta();
                }
                return _instancia;
            }
        }

        // Mostrar DetalleVenta (muestra todos los detalles de una venta por AperturaID)
        public DataTable MostrarDetalleVenta(int aperturaID) {
            var tabla = new DataTable();
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT * FROM DetallesVentas WHERE AperturaID = @aperturaID";
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

        // Editar DetalleVenta
        public bool EditarDetalleVenta(DetalleVenta detalleVenta) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "UPDATE DetallesVentas SET MedioPago = @medioPago, Productos = @productos, Total = @total, AperturaID = @aperturaID WHERE DetalleVentaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@medioPago", detalleVenta.MedioPago);
                    cmd.Parameters.AddWithValue("@productos", detalleVenta.Productos);
                    cmd.Parameters.AddWithValue("@total", detalleVenta.Total);
                    cmd.Parameters.AddWithValue("@aperturaID", detalleVenta.AperturaID);
                    cmd.Parameters.AddWithValue("@id", detalleVenta.DetalleVentaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Borrar DetalleVenta
        public bool BorrarDetalleVenta(int detalleVentaID) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "DELETE FROM DetallesVentas WHERE DetalleVentaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@id", detalleVentaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Cargar DetalleVenta (Insertar una nueva venta)
        public bool CargarDetalleVenta(DetalleVenta detalleVenta) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "INSERT INTO DetallesVentas (MedioPago, Productos, Total, AperturaID) VALUES (@medioPago, @productos, @total, @aperturaID)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@medioPago", detalleVenta.MedioPago);
                    cmd.Parameters.AddWithValue("@productos", detalleVenta.Productos);
                    cmd.Parameters.AddWithValue("@total", detalleVenta.Total);
                    cmd.Parameters.AddWithValue("@aperturaID", detalleVenta.AperturaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        // Imprimir (asíncrona)
        public async Task<bool> ImprimirDetalleVentaAsync(int detalleVentaID) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT * FROM DetallesVentas WHERE DetalleVentaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@id", detalleVentaID);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {
                            // Lógica de impresión (dependiendo del tipo de impresión que uses)
                            // Simulación de impresión:
                            Console.WriteLine($"Imprimiendo detalles de venta {detalleVentaID}");
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
