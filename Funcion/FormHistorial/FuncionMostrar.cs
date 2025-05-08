using AplicacionCarroComidas.Private.DataBase.Logic;
using System;
using System.Data;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Funcion.FormHistorial
{
    internal class FuncionMostrar
    {
        public static void MostrarHistorialPorFecha(DataGridView dgv, DateTime desde, DateTime hasta)
        {
            try
            {
                dgv.Rows.Clear();
                DataTable tabla = LogicaDetalleVenta.Instancia.ObtenerVistaDetalleVenta(desde, hasta);

                foreach (DataRow row in tabla.Rows)
                {
                    dgv.Rows.Add(
                        row["DetalleVentaID"],
                        row["FechaCompleta"],
                        row["MedioPago"],
                        row["Productos"],
                        row["Total"],
                        "Eliminar",
                        "Imprimir"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }
        public static void MostrarUltimasVentas(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                DataTable tabla = LogicaDetalleVenta.Instancia.ObtenerUltimasVentas();

                foreach (DataRow row in tabla.Rows)
                {
                    dgv.Rows.Add(
                        row["DetalleVentaID"],
                        row["FechaCompleta"],
                        row["MedioPago"],
                        row["Productos"],
                        row["Total"],
                        "Eliminar",
                        "Imprimir"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar últimas ventas: " + ex.Message);
            }
        }


    }
}