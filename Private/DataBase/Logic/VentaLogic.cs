using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AplicacionCarroComidas.Private.DataBase.Model;
using AplicacionCarroComidas.Private.DataBase;
public class VentaLogic {
    public static bool Agregar(Venta venta) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = @"
                    INSERT INTO Ventas (CajaID, ProductoID, Fecha, Total, FormaPago)
                    VALUES (@CajaID, @ProductoID, @Fecha, @Total, @FormaPago);";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CajaID", venta.CajaID);
                    cmd.Parameters.AddWithValue("@ProductoID", venta.ProductoID);
                    cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    cmd.Parameters.AddWithValue("@Total", venta.Total);
                    cmd.Parameters.AddWithValue("@FormaPago", venta.FormaPago);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al agregar venta: " + ex.Message);
            return false;
        }
    }

    public static List<Venta> MostrarPorCaja(int cajaID) {
        var lista = new List<Venta>();

        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "SELECT * FROM Ventas WHERE CajaID = @CajaID ORDER BY Fecha";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@CajaID", cajaID);

                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Venta {
                                HistorialID = Convert.ToInt32(reader["HistorialID"]),
                                CajaID = Convert.ToInt32(reader["CajaID"]),
                                ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                FormaPago = reader["FormaPago"].ToString()
                            });
                        }
                    }
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al mostrar ventas: " + ex.Message);
        }

        return lista;
    }

    public static List<Venta> MostrarPorFechas(DateTime desde, DateTime hasta) {
        var lista = new List<Venta>();

        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "SELECT * FROM Ventas WHERE Fecha BETWEEN @Desde AND @Hasta ORDER BY Fecha";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Desde", desde);
                    cmd.Parameters.AddWithValue("@Hasta", hasta);

                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            lista.Add(new Venta {
                                HistorialID = Convert.ToInt32(reader["HistorialID"]),
                                CajaID = Convert.ToInt32(reader["CajaID"]),
                                ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                FormaPago = reader["FormaPago"].ToString()
                            });
                        }
                    }
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al mostrar ventas por fecha: " + ex.Message);
        }

        return lista;
    }

    public static bool Eliminar(int historialID) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "DELETE FROM Ventas WHERE HistorialID = @ID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@ID", historialID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al eliminar venta: " + ex.Message);
            return false;
        }
    }
}
