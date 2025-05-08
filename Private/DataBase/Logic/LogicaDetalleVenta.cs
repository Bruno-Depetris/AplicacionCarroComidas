using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

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

        //Mostrar DetalleVenta (por fechas)
        public DataTable ObtenerVistaDetalleVenta(DateTime fechaDesde, DateTime fechaHasta)
        {
            var tabla = new DataTable();
            SQLiteConnection cn = null;
            try
            {
                cn = Conectar.ObtenerConexion();
                string query = @"
            SELECT DetalleVentaID, 
                   MedioPago, 
                   Productos, 
                   Total, 
                   Fecha || ' ' || Hora AS FechaCompleta
            FROM VistaVentasDetalladas 
            WHERE Fecha BETWEEN @desde AND @hasta";

                using (var cmd = new SQLiteCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@desde", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@hasta", fechaHasta.ToString("yyyy-MM-dd"));
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch
            {
                // Manejo de errores personalizado si querés
            }
            finally
            {
                cn?.Close();
            }
            return tabla;
        }

        //Mostrar ultimas 10 ventas
        public DataTable ObtenerUltimasVentas(int cantidad = 10)
        {
            var tabla = new DataTable();
            SQLiteConnection cn = null;
            try
            {
                cn = Conectar.ObtenerConexion();
                string query = @"
            SELECT DetalleVentaID, 
                   MedioPago, 
                   Productos, 
                   Total, 
                   Fecha || ' ' || Hora AS FechaCompleta
            FROM VistaVentasDetalladas ORDER BY Fecha DESC LIMIT @cantidad";
                using (var cmd = new SQLiteCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch
            {
                // Manejo de errores
            }
            finally
            {
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
        public int CargarDetalleVenta(DetalleVenta venta) {
            try {
                using (var cn = Conectar.ObtenerConexion()) {
                    string query = @"INSERT INTO DetallesVentas (MedioPago, Productos, Total, AperturaID) 
                             VALUES (@MedioPago,@Productos, @Total, @AperturaID); 
                             SELECT last_insert_rowid();";
                    using (var cmd = new SQLiteCommand(query, cn)) {
                        cmd.Parameters.AddWithValue("@MedioPago", venta.MedioPago);
                        cmd.Parameters.AddWithValue("@Total", venta.Total);
                        cmd.Parameters.AddWithValue("@AperturaID", venta.AperturaID);
                        cmd.Parameters.AddWithValue("@Productos", venta.Productos);

                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result); //Esto es el ID generado
                    }
                }
            } catch {
                return -1;
            }
        }

        public Task<bool> ImprimirDetalleVentaAsync(int detalleVentaID) {
            return Task.Run(() =>
            {
                SQLiteConnection cn = null;
                try {
                    cn = Conectar.ObtenerConexion();
                    string query = @"
            SELECT Productos, Total, MedioPago 
            FROM DetallesVentas
            WHERE DetalleVentaID = @id";

                    using (var cmd = new SQLiteCommand(query, cn)) {
                        cmd.Parameters.AddWithValue("@id", detalleVentaID);
                        using (var reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                string producto = reader["Productos"].ToString();
                                string total = reader["Total"].ToString();
                                string medio = reader["MedioPago"].ToString();

                                string productos = reader["Productos"].ToString();
                                string[] listaProductos = productos.Split('-'); 

                                
                                string comanda = "******* REPAS *******\n";
                                comanda += "----------------------\n\n\n";
                                comanda += "                      \n";
                                comanda += "                      \n";
                                comanda += $"ID: {detalleVentaID}\n";
                                comanda += "Su pedido:\n";

                                foreach (var dato in listaProductos) {
                                    string productoNombre = dato.Trim().ToLower();
                                    foreach (var comidas in LogicaComida.Instancia.MostrarComida()) {
                                        if (productoNombre == comidas.NombreComida.ToLower()) {
                                            comanda += $"{dato.Trim()}  ${comidas.Precio}\n";
                                            break; // ya lo encontró, no hace falta seguir buscando
                                        }
                                    }
                                }



                                comanda += $"Medio pago: {medio}\n";
                                comanda += $"Total: ${total}\n";
                                comanda += "----------------------\n";
                                comanda += "ALIAS:REPAS.IGA\n";
                                comanda += "ROMINA NOELIA GIRAUDO\n";
                                comanda += ".\n";
                                comanda += ".\n";


                                // Ruta del logo
                                string Logo = Path.Combine(Application.StartupPath, "Public/Icon", "repas sin fondo.png");

                                if (File.Exists(Logo)) {
                                    PrintDocument pd = new PrintDocument();
                                    pd.PrinterSettings.PrinterName = "XP-58"; 

                                    pd.PrintPage += (sender, e) =>
                                    {
                                        Font fuente = new Font("Courier New", 11);
                                        float y = 2;

                                        Image logoImg = Image.FromFile(Logo);
                                        int logoWidth = 60;
                                        int logoHeight = 60;

                                        // Redimensionar la imagen
                                        Image resizedLogo = logoImg.GetThumbnailImage(logoWidth, logoHeight, null, IntPtr.Zero);

                                        // Calcular la posición X para centrar la imagen en el ancho de la página
                                        float x = (e.PageBounds.Width - resizedLogo.Width) / 2; // Centrado horizontalmente

                                        // Dibuja el logo redimensionado
                                        e.Graphics.DrawImage(resizedLogo, x, y); // Dibuja la imagen en las coordenadas calculadas
                                        y += resizedLogo.Height + 10; // Ajusta el espacio después de la imagen

                                        // Dibuja el texto que contiene la comanda
                                        e.Graphics.DrawString(comanda, fuente, Brushes.Black, 0, y);
                                    };

                                    pd.Print();  

                                    return true;
                                } else {
                                    MessageBox.Show("No se encontró el logo en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error al imprimir comanda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } finally {
                    cn?.Close();
                }

                return false;
            });
        }






    }

}
