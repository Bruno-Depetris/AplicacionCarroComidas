using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Builders;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionCarroComidas.Funcion.FormVender;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
namespace AplicacionCarroComidas.Forms.Vender {
    public partial class Vender : Form {
        private FuncionVender funcionVender; // Add an instance of FuncionVender  

        string[] precios = new string[7];
        public Vender() {
            InitializeComponent();
            funcionVender = new FuncionVender(); // Initialize the instance  
            CargarLabel();
            label_TotalDetalle.Text = "0.00"; // Initialize the total label
        }
        private void ActualizarTotal() {
            decimal total = 0;

            foreach (DataGridViewRow row in poisonDataGridView_DetalleVenta.Rows) {
                if (row.Cells[2].Value != null) // columna 3 = índice 2
                {
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out decimal precio)) {
                        total += precio;
                    }
                }
            }

            label_TotalDetalle.Text = total.ToString("0.00");
        }
        public void CargarLabel() {
            var productos = LogicaComida.Instancia.MostrarComida().ToList();

            if (productos.Count >= 7) {
                label_PrecioGaseosa.Text = productos[0].Precio.ToString("0.00");
                label_PrecioCerveza.Text = productos[1].Precio.ToString("0.00");
                label_PrecioConoPapas.Text = productos[2].Precio.ToString("0.00");
                label1_PrecioConoPapasXXL.Text = productos[3].Precio.ToString("0.00");
                label_PrecioChoripan.Text = productos[4].Precio.ToString("0.00");
                label_PrecioPancho.Text = productos[5].Precio.ToString("0.00");
                label_PrecioFoccacia.Text = productos[6].Precio.ToString("0.00");
            } else {
                MessageBox.Show("Faltan productos en la base de datos");
            }



        }
        private void parrotPictureBox_Gaseosa_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(1, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_Cerveza_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(2, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_ConoPapas_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(3, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_ConoPapasXXL_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(4, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_Choripan_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(5, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_Pancho_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(6, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotPictureBox_Focacia_Click(object sender, EventArgs e) {
            bool dato = funcionVender.CargarDetalle(7, poisonDataGridView_DetalleVenta); // Use the instance  
            if (dato) {
                ActualizarTotal();
            }
        }
        private void parrotButton2_Click(object sender, EventArgs e) {
            Editar formEditar = new Editar(this);
            formEditar.Show();
        }
        private void Borrar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_DetalleVenta.Rows[rowIndex];

            int IDselected = Convert.ToInt32(seleccionarRow.Cells[0].Value);

            poisonDataGridView_DetalleVenta.Rows.RemoveAt(rowIndex);
            ActualizarTotal(); // actualiza el total después de borrar
        }
        private void poisonDataGridView_DetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_DetalleVenta.Columns[e.ColumnIndex].Name;

                switch (columnName) {
                    case "Column_Eliminar":
                        Borrar(e.RowIndex);
                        break;

                }
            }
        }
        private void parrotButton1_Click(object sender, EventArgs e) {
            int totalFilas = poisonDataGridView_DetalleVenta.Rows.Count;

            if (totalFilas > 0) {
                int ultimoIndice = totalFilas - 1;
                Borrar(ultimoIndice);
            } else {
                MessageBox.Show("No hay registros para borrar.");
            }
        }
        public void Restaurar() {
            poisonDataGridView_DetalleVenta.Rows.Clear();
            label_TotalDetalle.Text = "0.00"; 
        }
        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            CargarVenta _CargarVenta = new CargarVenta(this);
            _CargarVenta.Total = Convert.ToDouble(label_TotalDetalle.Text);
            string productosConcatenados = "";

            foreach (DataGridViewRow fila in poisonDataGridView_DetalleVenta.Rows) {
                if (fila.Cells["Column_Producto"].Value != null) {
                    productosConcatenados += fila.Cells["Column_Producto"].Value.ToString() + " - ";
                }
            }
            if (productosConcatenados.EndsWith(" - ")) {// Eliminar el último guión si existe
                productosConcatenados = productosConcatenados.Substring(0, productosConcatenados.Length - 3);
            }
            _CargarVenta.Productos = productosConcatenados;
            _CargarVenta.Show();
        }
        public void label_TotalDetalle_Click(object sender, EventArgs e) {

        }
    }
}
