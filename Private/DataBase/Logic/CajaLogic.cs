using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AplicacionCarroComidas.Private.DataBase.Model;
using AplicacionCarroComidas.Private.DataBase;
public class CajaLogic {
    public static bool AbrirCaja(Caja caja) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = @"INSERT INTO Caja (Apertura, Cierre, Fecha)
                                 VALUES (@Apertura, NULL, @Fecha)";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Apertura", caja.Apertura.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Fecha", caja.Fecha.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al abrir caja: " + ex.Message);
            return false;
        }
    }

    public static bool CerrarCaja(int cajaID, DateTime cierre) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "UPDATE Caja SET Cierre = @Cierre WHERE CajaID = @CajaID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Cierre", cierre.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CajaID", cajaID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al cerrar caja: " + ex.Message);
            return false;
        }
    }

    public static List<Caja> MostrarTodas() {
        var lista = new List<Caja>();

        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "SELECT * FROM Caja ORDER BY Fecha DESC, Apertura DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        lista.Add(new Caja {
                            CajaID = Convert.ToInt32(reader["CajaID"]),
                            //Apertura = Convert.ToDecimal(reader["Apertura"]),
                            //Cierre = reader["Cierre"] == DBNull.Value ? null : Convert.ToDateTime(reader["Cierre"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"])
                        });
                    }
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al mostrar cajas: " + ex.Message);
        }

        return lista;
    }

    public static bool Eliminar(int cajaID) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "DELETE FROM Caja WHERE CajaID = @CajaID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CajaID", cajaID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al eliminar caja: " + ex.Message);
            return false;
        }
    }
}