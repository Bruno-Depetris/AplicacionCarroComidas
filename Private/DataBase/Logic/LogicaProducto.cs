using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaProducto {
        private static LogicaProducto _LogicaProducto;
        public static LogicaProducto Instancia {
            get {
                if (_LogicaProducto == null) {
                    _LogicaProducto = new LogicaProducto();
                }
                return _LogicaProducto;
            }
        }

        public bool Agregar(Producto producto) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("INSERT INTO Producto(nombre, precio) VALUES(@nombre, @precio)", con);
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public List<Producto> Mostrar() {
            var lista = new List<Producto>();
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Producto", con);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        lista.Add(new Producto {
                            IdProducto = Convert.ToInt32(dr["id_producto"]),
                            Nombre = dr["nombre"].ToString(),
                            Precio = Convert.ToDouble(dr["precio"])
                        });
                    }
                }
            } catch { }
            return lista;
        }
        public Producto ObtenerPorId(int idProducto) {
            Producto producto = null;
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Producto WHERE id_producto = @idProducto", con);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        producto = new Producto {
                            IdProducto = Convert.ToInt32(dr["id_producto"]),
                            Nombre = dr["nombre"].ToString(),
                            Precio = Convert.ToDouble(dr["precio"])
                        };
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al obtener el producto: " + ex.Message);
            }
            return producto;
        }
        public bool Editar(Producto producto) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("UPDATE Producto SET nombre = @nombre, precio = @precio WHERE id_producto = @id", con);
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@id", producto.IdProducto);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public bool Eliminar(int idProducto) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("DELETE FROM Producto WHERE id_producto = @id", con);
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }
    }

}
