using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaVenta {
        private static LogicaVenta _LogicaVenta;

        public static LogicaVenta Instancia {
            get {
                if (_LogicaVenta == null) {
                    _LogicaVenta = new LogicaVenta();
                }
                return _LogicaVenta;
            }
        }

        public int Agregar(Venta venta) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("INSERT INTO Venta(fecha, total, estado_cobro, metodo_pago, id_caja) VALUES(@fecha, @total, @estado, @metodo, @idCaja); SELECT last_insert_rowid();", con);
                    cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                    cmd.Parameters.AddWithValue("@total", venta.Total);
                    cmd.Parameters.AddWithValue("@estado", venta.EstadoCobro);
                    cmd.Parameters.AddWithValue("@metodo", venta.MetodoPago);
                    cmd.Parameters.AddWithValue("@idCaja", venta.IdCaja);
                    MessageBox.Show("Venta cargada correctamente.");
                    return Convert.ToInt32(cmd.ExecuteScalar());

                }
            } catch {
                return -1;
            }
        }

        public List<Venta> Mostrar() {
            var lista = new List<Venta>();
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Venta", con);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        lista.Add(new Venta {
                            IdVenta = Convert.ToInt32(dr["id_venta"]),
                            Fecha = Convert.ToDateTime(dr["fecha"]),
                            Total = Convert.ToDouble(dr["total"]),
                            EstadoCobro = dr["estado_cobro"].ToString(),
                            MetodoPago = dr["metodo_pago"].ToString(),
                            IdCaja = Convert.ToInt32(dr["id_caja"])
                        });
                    }
                }
            } catch { }
            return lista;
        }

        public bool Editar(Venta venta) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("UPDATE Venta SET fecha = @fecha, total = @total, estado_cobro = @estado, metodo_pago = @metodo, id_caja = @idCaja WHERE id_venta = @id", con);
                    cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                    cmd.Parameters.AddWithValue("@total", venta.Total);
                    cmd.Parameters.AddWithValue("@estado", venta.EstadoCobro);
                    cmd.Parameters.AddWithValue("@metodo", venta.MetodoPago);
                    cmd.Parameters.AddWithValue("@idCaja", venta.IdCaja);
                    cmd.Parameters.AddWithValue("@id", venta.IdVenta);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public bool Eliminar(int idVenta) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("DELETE FROM Venta WHERE id_venta = @id", con);
                    cmd.Parameters.AddWithValue("@id", idVenta);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public Venta ObtenerPorId(int idVenta) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Venta WHERE id_venta = @id", con);
                    cmd.Parameters.AddWithValue("@id", idVenta);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        return new Venta {
                            IdVenta = Convert.ToInt32(dr["id_venta"]),
                            Fecha = Convert.ToDateTime(dr["fecha"]),
                            Total = Convert.ToDouble(dr["total"]),
                            EstadoCobro = dr["estado_cobro"].ToString(),
                            MetodoPago = dr["metodo_pago"].ToString(),
                            IdCaja = Convert.ToInt32(dr["id_caja"])
                        };
                    }
                }
            } catch { }
            return null;
        }
    }

}
