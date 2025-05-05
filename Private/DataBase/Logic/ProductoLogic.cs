using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AplicacionCarroComidas.Private.DataBase.Model;
using AplicacionCarroComidas.Private.DataBase;

public class ProductoLogic {
    public static bool Agregar(Producto producto) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "INSERT INTO Productos (Producto, Precio) VALUES (@Nombre, @Precio)";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Nombre", producto.ProductoNombre);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al agregar producto: " + ex.Message);
            return false;
        }
    }

    public static List<Producto> MostrarTodos() {
        var lista = new List<Producto>();

        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "SELECT * FROM Productos ORDER BY Producto ASC";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        lista.Add(new Producto {
                            ProductoID = Convert.ToInt32(reader["ProductoID"]),
                            ProductoNombre = reader["Producto"].ToString(),
                            Precio = Convert.ToDecimal(reader["Precio"])
                        });
                    }
                }
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al mostrar productos: " + ex.Message);
        }

        return lista;
    }

    public static bool Editar(Producto producto) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "UPDATE Productos SET Producto = @Nombre, Precio = @Precio WHERE ProductoID = @ID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@Nombre", producto.ProductoNombre);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@ID", producto.ProductoID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al editar producto: " + ex.Message);
            return false;
        }
    }

    public static bool Eliminar(int id) {
        try {
            using (var conn = Conectar.ObtenerConexion()) {
                string query = "DELETE FROM Productos WHERE ProductoID = @ID";

                using (var cmd = new SQLiteCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        } catch (Exception ex) {
            Console.WriteLine("Error al eliminar producto: " + ex.Message);
            return false;
        }
    }
}
