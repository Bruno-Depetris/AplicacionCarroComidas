using AplicacionCarroComidas.Funcion.FormHistorial;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormHistorial {
    public partial class Historial : Form {
        public Historial() {

            InitializeComponent();
            poisonDateTime_Hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDateTime_Desde.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDataGridView_HistorialVenta.CellContentClick += poisonDataGridView_HistorialVenta_CellContentClick;

        }

        private void poisonDateTime2_ValueChanged(object sender, EventArgs e) {

        }
        private void Imprimir(int rowIndex) {
            var seleccionarRow = poisonDataGridView_HistorialVenta.Rows[rowIndex];
            var confirm = MessageBox.Show("¿Está seguro que desea imprimir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int detalleVentaID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            if (confirm == DialogResult.Yes) {
                FuncionEliminar.EliminarHistorial(detalleVentaID);
                CargarHistorial();
            }
        }
        private void Borrar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_HistorialVenta.Rows[rowIndex];
            var confirm = MessageBox.Show("¿Está seguro que desea eliminar esta venta del historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int detalleVentaID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            if (confirm == DialogResult.Yes) {
                LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(detalleVentaID);
                CargarHistorial();
            }
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
            /*
            if (e.RowIndex < 0) return;

            var grid = poisonDataGridView_HistorialVenta;

            int detalleVentaID = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["DetalleVentaID"].Value);

            if (grid.Columns[e.ColumnIndex].Name == "Eliminar") {
                
            }


            if (grid.Columns[e.ColumnIndex].Name == "Imprimir") {
               
            }
            */
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
