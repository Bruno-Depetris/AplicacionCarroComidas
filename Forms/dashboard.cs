using AplicacionCarroComidas.Private.DataBase.Model;
using AplicacionCarroComidas.Private.DataBase.Logic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AplicacionCarroComidas.Forms {
    public partial class dashboard : Form {
        private int aperturaIDActual;

        public dashboard(int aperturaID) {
            InitializeComponent();
            this.aperturaIDActual = aperturaID;
            CargarDatosDashboard();
        }

        private void CargarDatosDashboard() {
            try {
                // Obtener todas las ventas de la apertura actual
                var ventasHoy = LogicaDetalleVenta.Instancia.MostrarDetalleVenta(aperturaIDActual);

                if (ventasHoy == null || ventasHoy.Count == 0) {
                    MostrarDashboardVacio();
                    return;
                }

                // Calcular métricas principales
                CargarMetricasPrincipales(ventasHoy);

                // Cargar productos más vendidos
                CargarProductosTopVendidos(ventasHoy);

                // Cargar medios de pago
                CargarMediosDePago(ventasHoy);

                // Cargar producto más rentable
                CargarProductoMasRentable(ventasHoy);

                // Cargar comparativa con días anteriores
                CargarComparativaDias();

                // Actualizar fecha
                lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy",
                    new System.Globalization.CultureInfo("es-ES"));

            } catch (Exception ex) {
                MessageBox.Show($"Error al cargar el dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMetricasPrincipales(List<DetalleVenta> ventas) {
            // Ventas totales
            decimal totalVentas = ventas.Sum(v => (decimal)v.Total);
            lblVentasTotalValor.Text = $"${totalVentas:N0}";

            // Cantidad de ventas
            lblCantidadVentasValor.Text = ventas.Count.ToString();

            // Ticket promedio
            decimal ticketPromedio = ventas.Count > 0 ? totalVentas / ventas.Count : 0m;
            lblTicketPromedioValor.Text = $"${ticketPromedio:N0}";
        }

        private void CargarProductosTopVendidos(List<DetalleVenta> ventas) {
            // Diccionario para contar productos
            Dictionary<string, int> contadorProductos = new Dictionary<string, int>();

            foreach (var venta in ventas) {
                if (!string.IsNullOrEmpty(venta.Productos)) {
                    string[] productos = venta.Productos.Split('-');

                    foreach (var producto in productos) {
                        string productoLimpio = producto.Trim();
                        if (!string.IsNullOrEmpty(productoLimpio)) {
                            if (contadorProductos.ContainsKey(productoLimpio)) {
                                contadorProductos[productoLimpio]++;
                            } else {
                                contadorProductos[productoLimpio] = 1;
                            }
                        }
                    }
                }
            }

            // Ordenar por cantidad vendida (descendente)
            var topProductos = contadorProductos
                .OrderByDescending(p => p.Value)
                .Take(5)
                .ToList();

            // Asignar a los labels
            AsignarProductoALabel(lblProducto1, topProductos, 0, 1);
            AsignarProductoALabel(lblProducto2, topProductos, 1, 2);
            AsignarProductoALabel(lblProducto3, topProductos, 2, 3);
            AsignarProductoALabel(lblProducto4, topProductos, 3, 4);
            AsignarProductoALabel(lblProducto5, topProductos, 4, 5);
        }

        private void AsignarProductoALabel(Label label, List<KeyValuePair<string, int>> productos,
            int indice, int posicion) {
            if (indice < productos.Count) {
                var producto = productos[indice];
                label.Text = $"{posicion}. {producto.Key} - {producto.Value} unidades";
            } else {
                label.Text = $"{posicion}. Sin datos";
            }
        }

        private void CargarMediosDePago(List<DetalleVenta> ventas) {
            // Diccionario para contar medios de pago
            Dictionary<string, int> contadorMedios = new Dictionary<string, int>();

            foreach (var venta in ventas) {
                string medio = venta.MedioPago ?? "Sin especificar";

                if (contadorMedios.ContainsKey(medio)) {
                    contadorMedios[medio]++;
                } else {
                    contadorMedios[medio] = 1;
                }
            }

            // Calcular porcentajes
            int totalVentas = ventas.Count;
            var mediosPorcentaje = contadorMedios
                .OrderByDescending(m => m.Value)
                .Take(4)
                .ToList();

            // Asignar a los labels
            AsignarMedioPagoALabel(lblMedioPago1, mediosPorcentaje, 0, totalVentas);
            AsignarMedioPagoALabel(lblMedioPago2, mediosPorcentaje, 1, totalVentas);
            AsignarMedioPagoALabel(lblMedioPago3, mediosPorcentaje, 2, totalVentas);
            AsignarMedioPagoALabel(lblMedioPago4, mediosPorcentaje, 3, totalVentas);
        }

        private void AsignarMedioPagoALabel(Label label,
            List<KeyValuePair<string, int>> medios, int indice, int totalVentas) {
            if (indice < medios.Count) {
                var medio = medios[indice];
                double porcentaje = ( medio.Value * 100.0 ) / totalVentas;
                label.Text = $"{medio.Key} - {porcentaje:F0}%";
            } else {
                label.Text = "Sin datos";
            }
        }

        private void CargarProductoMasRentable(List<DetalleVenta> ventas) {
            // Diccionario para calcular ingresos por producto
            Dictionary<string, decimal> ingresosProductos = new Dictionary<string, decimal>();
            Dictionary<string, int> cantidadProductos = new Dictionary<string, int>();

            foreach (var venta in ventas) {
                if (!string.IsNullOrEmpty(venta.Productos)) {
                    string[] productos = venta.Productos.Split('-');

                    foreach (var producto in productos) {
                        string productoLimpio = producto.Trim();
                        if (!string.IsNullOrEmpty(productoLimpio)) {
                            // Buscar precio del producto
                            var comida = LogicaComida.Instancia.MostrarComida()
                                .FirstOrDefault(c => c.NombreComida.Equals(productoLimpio,
                                    StringComparison.OrdinalIgnoreCase));

                            if (comida != null) {
                                if (ingresosProductos.ContainsKey(productoLimpio)) {
                                    ingresosProductos[productoLimpio] += comida.Precio;
                                    cantidadProductos[productoLimpio]++;
                                } else {
                                    ingresosProductos[productoLimpio] = comida.Precio;
                                    cantidadProductos[productoLimpio] = 1;
                                }
                            }
                        }
                    }
                }
            }

            // Encontrar el más rentable
            if (ingresosProductos.Count > 0) {
                var masRentable = ingresosProductos.OrderByDescending(p => p.Value).First();
                lblHoraPicoValor.Text = masRentable.Key;
                lblHoraPicoDetalle.Text = $"${masRentable.Value:N0} en ingresos totales";
                lblTituloHoraPico.Text = "Producto Más Rentable";
            } else {
                lblHoraPicoValor.Text = "Sin datos";
                lblHoraPicoDetalle.Text = "No hay productos registrados";
                lblTituloHoraPico.Text = "Producto Más Rentable";
            }
        }

        private void CargarComparativaDias() {
            try {
                // Obtener ventas de hoy
                var ventasHoy = LogicaDetalleVenta.Instancia.MostrarDetalleVenta(aperturaIDActual);
                decimal totalHoy = ventasHoy.Sum(v => (decimal)v.Total);
                int cantidadHoy = ventasHoy.Count;

                // Obtener ventas de ayer (necesitas el ID de apertura de ayer)
                // Si no tienes forma de obtenerlo, puedes usar fecha
                DateTime ayer = DateTime.Now.AddDays(-1);
                var ventasAyer = LogicaDetalleVenta.Instancia.ObtenerVistaDetalleVentaBetween(
                    ayer.Date, ayer.Date, aperturaIDActual - 1); // Asumiendo que los IDs son consecutivos

                decimal totalAyer = ventasAyer.Sum(v => (decimal)v.Total);
                int cantidadAyer = ventasAyer.Count;

                // Calcular diferencias
                decimal diferenciaTotal = totalHoy - totalAyer;
                int diferenciaCantidad = cantidadHoy - cantidadAyer;

                string textoPrincipal = "";
                string textoDetalle = "";

                if (totalAyer > 0m) {
                    decimal porcentajeCambio = ( ( totalHoy - totalAyer ) / totalAyer ) * 100m;
                    string signo = porcentajeCambio >= 0m ? "+" : "";
                    textoPrincipal = $"{signo}{porcentajeCambio:F1}%";
                    textoDetalle = porcentajeCambio >= 0m
                        ? $"↑ ${Math.Abs(diferenciaTotal):N0} más que ayer"
                        : $"↓ ${Math.Abs(diferenciaTotal):N0} menos que ayer";
                } else {
                    textoPrincipal = "N/A";
                    textoDetalle = "Sin datos de comparación";
                }

                lblTituloVentasHora.Text = "Comparativa con Ayer";

                // Crear labels dinámicamente si no existen
                if (!panelVentasPorHora.Controls.ContainsKey("lblComparativaValor")) {
                    Label lblComparativaValor = new Label {
                        Name = "lblComparativaValor",
                        Font = new Font("Segoe UI", 32F, FontStyle.Bold),
                        ForeColor = diferenciaTotal >= 0m
                            ? Color.FromArgb(46, 204, 113)
                            : Color.FromArgb(231, 76, 60),
                        Location = new Point(20, 60),
                        Size = new Size(320, 50),
                        Text = textoPrincipal
                    };
                    panelVentasPorHora.Controls.Add(lblComparativaValor);

                    Label lblComparativaDetalle = new Label {
                        Name = "lblComparativaDetalle",
                        Font = new Font("Segoe UI", 11F),
                        ForeColor = Color.FromArgb(180, 180, 180),
                        Location = new Point(20, 120),
                        Size = new Size(320, 25),
                        Text = textoDetalle
                    };
                    panelVentasPorHora.Controls.Add(lblComparativaDetalle);

                    Label lblComparativaCantidad = new Label {
                        Name = "lblComparativaCantidad",
                        Font = new Font("Segoe UI", 10F),
                        ForeColor = Color.FromArgb(200, 200, 200),
                        Location = new Point(20, 160),
                        Size = new Size(320, 60),
                        Text = $"Ventas de hoy: {cantidadHoy}\nVentas de ayer: {cantidadAyer}"
                    };
                    panelVentasPorHora.Controls.Add(lblComparativaCantidad);
                } else {
                    panelVentasPorHora.Controls["lblComparativaValor"].Text = textoPrincipal;
                    panelVentasPorHora.Controls["lblComparativaDetalle"].Text = textoDetalle;
                    panelVentasPorHora.Controls["lblComparativaCantidad"].Text =
                        $"Ventas de hoy: {cantidadHoy}\nVentas de ayer: {cantidadAyer}";
                }

            } catch {
                lblTituloVentasHora.Text = "Comparativa con Ayer";
                if (panelVentasPorHora.Controls.ContainsKey("lblComparativaValor")) {
                    panelVentasPorHora.Controls["lblComparativaValor"].Text = "N/A";
                    panelVentasPorHora.Controls["lblComparativaDetalle"].Text = "Sin datos disponibles";
                }
            }
        }

        private void CargarHoraPico(List<DetalleVenta> ventas) {
            // Esta función requiere que tengas un campo de fecha/hora en DetalleVenta
            // Si no lo tienes, puedes omitir esta función por ahora

            lblHoraPicoValor.Text = "13:00 - 14:00";
            lblHoraPicoDetalle.Text = "23 ventas realizadas";
        }

        private void MostrarDashboardVacio() {
            lblVentasTotalValor.Text = "$0";
            lblCantidadVentasValor.Text = "0";
            lblTicketPromedioValor.Text = "$0";

            lblProducto1.Text = "1. Sin datos";
            lblProducto2.Text = "2. Sin datos";
            lblProducto3.Text = "3. Sin datos";
            lblProducto4.Text = "4. Sin datos";
            lblProducto5.Text = "5. Sin datos";

            lblMedioPago1.Text = "Sin datos";
            lblMedioPago2.Text = "Sin datos";
            lblMedioPago3.Text = "Sin datos";
            lblMedioPago4.Text = "Sin datos";

            lblHoraPicoValor.Text = "--:--";
            lblHoraPicoDetalle.Text = "Sin ventas registradas";
        }

        // Método público para actualizar el dashboard (llamar después de cada venta)
        public void ActualizarDashboard() {
            CargarDatosDashboard();
        }

        // Método para refrescar automáticamente cada cierto tiempo (opcional)
        private Timer timerActualizacion;

        private void IniciarActualizacionAutomatica(int intervaloSegundos = 30) {
            timerActualizacion = new Timer();
            timerActualizacion.Interval = intervaloSegundos * 1000;
            timerActualizacion.Tick += (s, e) => ActualizarDashboard();
            timerActualizacion.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            timerActualizacion?.Stop();
            timerActualizacion?.Dispose();
            base.OnFormClosing(e);
        }
    }
}