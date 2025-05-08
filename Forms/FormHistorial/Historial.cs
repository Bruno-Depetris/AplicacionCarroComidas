using System;
using System.Collections.Generic;
using AplicacionCarroComidas.Funcion.FormHistorial;
using AplicacionCarroComidas.Private.DataBase.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormHistorial
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
            poisonDateTime_Hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDateTime_Desde.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDataGridView_HistorialVenta.CellClick += poisonDataGridView_HistorialVenta_CellClick; //Esto lo agregue para que funcione el evento de click en la celda
        }

        private void poisonDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e)
        {
            FiltrarHistorial();
        }
        private void poisonDataGridView_HistorialVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var grid = poisonDataGridView_HistorialVenta;

            int detalleVentaID = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["DetalleVentaID"].Value);

            if (grid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var confirm = MessageBox.Show("¿Está seguro que desea eliminar esta venta del historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    FuncionEliminar.EliminarHistorial(detalleVentaID);
                    CargarHistorial();
                }
            }


            if (grid.Columns[e.ColumnIndex].Name == "Imprimir")
            {
                LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(detalleVentaID);
            }
        }

        private void CargarHistorial()
        {
            FuncionMostrar.MostrarUltimasVentas(poisonDataGridView_HistorialVenta);
            AgregarBotones();
        }
        private void FiltrarHistorial()
        {
            DateTime desde = DateTime.Parse(poisonDateTime_Desde.Text);
            DateTime hasta = DateTime.Parse(poisonDateTime_Hasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FuncionMostrar.MostrarHistorialPorFecha(poisonDataGridView_HistorialVenta, desde, hasta);
            AgregarBotones();
        }
        private void AgregarBotones()
        {

            if (!poisonDataGridView_HistorialVenta.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Name = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.DefaultCellStyle.BackColor = Color.Red;
                btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                poisonDataGridView_HistorialVenta.Columns.Add(btnEliminar);
            }

            if (!poisonDataGridView_HistorialVenta.Columns.Contains("Imprimir"))
            {
                DataGridViewButtonColumn btnImprimir = new DataGridViewButtonColumn();
                btnImprimir.HeaderText = "Imprimir";
                btnImprimir.Name = "Imprimir";
                btnImprimir.Text = "Imprimir";
                btnImprimir.UseColumnTextForButtonValue = true;
                poisonDataGridView_HistorialVenta.Columns.Add(btnImprimir);
            }
        }



    }
}