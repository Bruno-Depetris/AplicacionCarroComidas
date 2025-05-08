using AplicacionCarroComidas.Funcion.FormHistorial;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormHistorial {
    public partial class Historial : Form {
        public Historial() {

            InitializeComponent();
            poisonDateTime_Hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDateTime_Desde.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void poisonDateTime2_ValueChanged(object sender, EventArgs e) {

        }
        private void Borrar(int rowIndex) {
            if (rowIndex < 0 || rowIndex >= poisonDataGridView_HistorialVenta.Rows.Count) {
                MessageBox.Show("Índice fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var seleccionarRow = poisonDataGridView_HistorialVenta.Rows[rowIndex];
            int detalleVentaID = Convert.ToInt32(seleccionarRow.Cells[0].Value);

            MovimientoCaja mov = new MovimientoCaja();

            mov.AperturaID = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
            string valorTexto = seleccionarRow.Cells[3].Value.ToString();

            // Elimina todo lo que no sea número, coma o punto
            string valorLimpio = Regex.Replace(valorTexto, @"[^\d.,-]", "");

            // Intenta convertir usando culturas que entiendan "," o "."
            if (double.TryParse(valorLimpio, NumberStyles.Any, CultureInfo.CurrentCulture, out double monto) ||
                double.TryParse(valorLimpio, NumberStyles.Any, CultureInfo.InvariantCulture, out monto)) {
                mov.Monto = monto;
            } else {
                MessageBox.Show("Error al interpretar el monto: " + valorTexto);
            }


            mov.Metodo = seleccionarRow.Cells[1].Value.ToString();
            mov.Motivo = $"Eliminar venta {detalleVentaID}";
            mov.Tipo = "Egreso";

            Console.Write(mov.Monto);
            var confirm = MessageBox.Show("¿Está seguro que desea eliminar esta venta del historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (confirm == DialogResult.Yes) {
                FuncionEliminar.EliminarHistorial(detalleVentaID);
                LogicaMovimientosCaja.Instancia.CargarMovimientoCaja(mov);
            }
            CargarHistorial();
            
        }
        private void Imprimir(int rowIndex) {
            var seleccionarRow = poisonDataGridView_HistorialVenta.Rows[rowIndex];
            var confirm = MessageBox.Show("¿Está seguro que desea Imprimir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int detalleVentaID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            if (confirm == DialogResult.Yes) {
                LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(detalleVentaID);
             
            }
            CargarHistorial();
        }
        private void poisonDataGridView_HistorialVenta_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_HistorialVenta.Columns[e.ColumnIndex].Name;

                switch (columnName) {
                    case "Column_Imprimir":
                        Imprimir(e.RowIndex);
                        break;
                    case "Column_Eliminar":
                        Borrar(e.RowIndex);
                        break;

                }
            }

            
        }

        private void Historial_Load(object sender, EventArgs e) {
            CargarHistorial();
        }

        private void parrotButton_Actualizar_Click(object sender, EventArgs e) {
            FiltrarHistorial();
        }
        private void CargarHistorial() {
            FuncionMostrar.MostrarUltimasVentas(poisonDataGridView_HistorialVenta);
            
        }
        private void FiltrarHistorial() {
            DateTime desde = DateTime.Parse(poisonDateTime_Desde.Text);
            DateTime hasta = DateTime.Parse(poisonDateTime_Hasta.Text);

            if (desde > hasta) {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FuncionMostrar.MostrarHistorialPorFecha(poisonDataGridView_HistorialVenta, desde, hasta);
            
        }
        
    }
}
