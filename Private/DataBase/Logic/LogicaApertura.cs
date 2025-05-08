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
        public bool CargarCierre(Cierre cierre, int aperturaId) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();

                // Insertar el cierre
                string insertCierre = "INSERT INTO Cierres (MontoFinal, Fecha, Hora) VALUES (@monto, @fecha, @hora); SELECT last_insert_rowid();";
                long cierreId;
                using (var cmd = new SQLiteCommand(insertCierre, cn)) {
                    cmd.Parameters.AddWithValue("@monto", cierre.MontoFinal);
                    cmd.Parameters.AddWithValue("@fecha", cierre.Fecha);
                    cmd.Parameters.AddWithValue("@hora", cierre.Hora);
                    cierreId = (long)cmd.ExecuteScalar();
                }

                // Actualizar la caja con el cierre
                string updateCaja = "UPDATE Cajas SET CierreID = @cierreId WHERE AperturaID = @aperturaId";
                using (var cmd = new SQLiteCommand(updateCaja, cn)) {
                    cmd.Parameters.AddWithValue("@cierreId", cierreId);
                    cmd.Parameters.AddWithValue("@aperturaId", aperturaId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        public bool EstaCajaAbierta() {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT COUNT(*) FROM Cajas WHERE CierreID IS NULL";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    long abiertas = (long)cmd.ExecuteScalar();
                    return abiertas > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }

        public int ObtenerUltimaAperturaId() {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();

                // Consulta para obtener el último AperturaID
                string query = "SELECT AperturaID FROM Aperturas ORDER BY AperturaID DESC LIMIT 1";

                using (var cmd = new SQLiteCommand(query, cn)) {
                    var result = cmd.ExecuteScalar();
                    if (result != null) {
                        return Convert.ToInt32(result);
                    } else {
                        // Si no hay registros de apertura, devolver -1
                        return -1;
                    }
                }
            } catch (Exception ex) {
                // Log de excepción si es necesario
                Console.WriteLine($"Error al obtener AperturaID: {ex.Message}");
                return -1;
            } finally {
                cn?.Close();
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
        public List<Apertura> MostrarAperturas() {
            SQLiteConnection cn = null;
            List<Apertura> lista = new List<Apertura>();
            try {
                cn = Conectar.ObtenerConexion();
                string query = "SELECT * FROM Aperturas ORDER BY Fecha DESC, Hora DESC";
                using (var cmd = new SQLiteCommand(query, cn))
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Apertura apertura = new Apertura {
                            AperturaID = Convert.ToInt32(reader["Id"]),
                            MontoInicio = Convert.ToDouble(reader["MontoInicio"]),
                            Fecha = Convert.ToString(reader["Fecha"]),
                            Hora = Convert.ToString(reader["Hora"])
                        };
                        lista.Add(apertura);
                    }
                }
            } catch {
                lista = new List<Apertura>(); // Devolver lista vacía si falla
            } finally {
                cn?.Close();
            }
            return lista;
        }

    }

}
