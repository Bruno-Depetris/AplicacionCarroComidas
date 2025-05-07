using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaDetalleVenta {
        private static LogicaDetalleVenta _LogicaDetalleVenta;

        public static LogicaDetalleVenta Instancia {
            get {
                if (_LogicaDetalleVenta == null) {
                    _LogicaDetalleVenta = new LogicaDetalleVenta();
                }
                return _LogicaDetalleVenta;
            }
        }

        public bool Agregar(DetalleVenta detalle) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("INSERT INTO DetalleVenta(id_venta, Detalle, cantidad, subtotal) VALUES(@venta, @producto, @cantidad, @subtotal)", con);
                    cmd.Parameters.AddWithValue("@venta", detalle.IdVenta);
                    cmd.Parameters.AddWithValue("@producto", detalle.IdProducto);
                    cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public List<DetalleVenta> ObtenerPorVenta(int idVenta) {
            var lista = new List<DetalleVenta>();
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM DetalleVenta WHERE id_venta = @idVenta", con);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        lista.Add(new DetalleVenta {
                            IdDetalle = Convert.ToInt32(dr["id_detalle"]),
                            IdVenta = Convert.ToInt32(dr["id_venta"]),
                            IdProducto = Convert.ToInt32(dr["Detalle"]),
                            Cantidad = Convert.ToInt32(dr["cantidad"]),
                            Subtotal = Convert.ToDouble(dr["subtotal"])
                        });
                    }
                }
            } catch { }
            return lista;
        }

        public bool EliminarPorVenta(int idVenta) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("DELETE FROM DetalleVenta WHERE id_venta = @idVenta", con);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }
    
    // Método para imprimir la comanda de venta
    public void ImprimirComanda(int idVenta) {
            var venta = LogicaVenta.Instancia.ObtenerPorId(1);
            if (venta == null) {
                MessageBox.Show("Venta no encontrada.");
                return;
            }

            var detalles = ObtenerPorVenta(idVenta);

            if (detalles.Count == 0) {
                MessageBox.Show("No hay productos en esta venta.");
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler((sender, e) => {
                e.Graphics.DrawString("Comanda - Venta #" + venta.IdVenta, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, 20);

                float yPosition = 60;
                e.Graphics.DrawString("Fecha: " + venta.Fecha.ToString("dd/MM/yyyy HH:mm"), new Font("Arial", 10), Brushes.Black, 100, yPosition);
                yPosition += 20;

                e.Graphics.DrawString("Productos:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 100, yPosition);
                yPosition += 20;

                foreach (var detalle in detalles) {
                    var producto = LogicaProducto.Instancia.ObtenerPorId(detalle.IdProducto);
                    e.Graphics.DrawString($"{producto.Nombre} x{detalle.Cantidad} - ${detalle.Subtotal:F2}", new Font("Arial", 10), Brushes.Black, 100, yPosition);
                    yPosition += 20;
                }

                yPosition += 10;  // Espacio antes del total
                e.Graphics.DrawString($"Total: ${venta.Total:F2}", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, yPosition);
            });

            pd.Print();
        }
    }
}
