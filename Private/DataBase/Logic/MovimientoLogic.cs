using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AplicacionCarroComidas.Private.DataBase;
using AplicacionCarroComidas.Private.DataBase.Model;

public class MovimientoLogic {
    public static bool Agregar(Movimiento mov) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = @"INSERT INTO Movimientos 
                                (CajaID, Movimiento, Fecha, Accion, Forma, Monto) 
                                VALUES 
                                (@CajaID, @Movimiento, @Fecha, @Accion, @Forma, @Monto)";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CajaID", mov.CajaID);
                    cmd.Parameters.AddWithValue("@Movimiento", mov.MovimientoDescripcion);
                    cmd.Parameters.AddWithValue("@Fecha", mov.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Accion", mov.Accion);
                    cmd.Parameters.AddWithValue("@Forma", mov.Forma);
                    cmd.Parameters.AddWithValue("@Monto", mov.Monto);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al agregar movimiento: " + ex.Message);
            return false;
        }
    }

    public static List<Movimiento> MostrarPorCaja(int cajaID) {
        var lista = new List<Movimiento>();

        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "SELECT * FROM Movimientos WHERE CajaID = @CajaID ORDER BY Fecha DESC";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CajaID", cajaID);
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            var mov = new Movimiento {
                                MovimientoID = Convert.ToInt32(reader["MovimientoID"]),
                                CajaID = Convert.ToInt32(reader["CajaID"]),
                                MovimientoDescripcion = reader["Movimiento"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Accion = reader["Accion"].ToString(),
                                Forma = reader["Forma"].ToString(),
                                Monto = Convert.ToDecimal(reader["Monto"])
                            };

                            lista.Add(mov);
                        }
                    }
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al mostrar movimientos: " + ex.Message);
        }

        return lista;
    }

    public static bool Editar(Movimiento mov) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = @"UPDATE Movimientos SET 
                                Movimiento = @Movimiento,
                                Fecha = @Fecha,
                                Accion = @Accion,
                                Forma = @Forma,
                                Monto = @Monto
                                WHERE MovimientoID = @MovimientoID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Movimiento", mov.MovimientoDescripcion);
                    cmd.Parameters.AddWithValue("@Fecha", mov.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Accion", mov.Accion);
                    cmd.Parameters.AddWithValue("@Forma", mov.Forma);
                    cmd.Parameters.AddWithValue("@Monto", mov.Monto);
                    cmd.Parameters.AddWithValue("@MovimientoID", mov.MovimientoID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al editar movimiento: " + ex.Message);
            return false;
        }
    }

    public static bool Eliminar(int movimientoID) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "DELETE FROM Movimientos WHERE MovimientoID = @MovimientoID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@MovimientoID", movimientoID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al eliminar movimiento: " + ex.Message);
            return false;
        }
    }
}
