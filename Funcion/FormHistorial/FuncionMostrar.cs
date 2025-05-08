using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model; // Asegurate de tener esta referencia para usar DetalleVenta
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Funcion.FormHistorial {
    internal class FuncionMostrar {

        public static void MostrarHistorialPorFecha(DataGridView dgv, DateTime desde, DateTime hasta) {
            try {
                dgv.Rows.Clear();
                int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
                List<DetalleVenta> lista = LogicaDetalleVenta.Instancia.ObtenerVistaDetalleVentaBetween(desde, hasta, id);

                foreach (var detalle in lista) {
                    dgv.Rows.Add(
                        detalle.DetalleVentaID,
                        "", // FechaCompleta no está en el modelo, podés agregarla si querés mostrarla
                        detalle.MedioPago,
                        detalle.Productos,
                        detalle.Total.ToString("C", new System.Globalization.CultureInfo("es-AR"))

                    );
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        public static void MostrarUltimasVentas(DataGridView dgv) {
            try {
                int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
                dgv.Rows.Clear();
                List<DetalleVenta> lista = LogicaDetalleVenta.Instancia.MostrarDetalleVenta(id);

                foreach (var detalle in lista) {
                    dgv.Rows.Add(
                        detalle.DetalleVentaID,
                        "", // Agregar propiedad Fecha si querés mostrarla
                        detalle.MedioPago, // Asegurate de que 'FormaPago' sea lo mismo que 'MedioPago'
                        detalle.Productos, // 'Pedido' es lo mismo que 'Productos' en tu modelo
                        detalle.Total.ToString("C")

                    );
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al cargar últimas ventas: " + ex.Message);
            }
        }
    }
}
