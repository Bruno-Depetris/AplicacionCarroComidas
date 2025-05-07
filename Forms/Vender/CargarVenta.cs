using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.Vender {
    public partial class CargarVenta : Form {
        private Vender _formVender;
        public CargarVenta(Vender formVender) {
            InitializeComponent();
            hopeComboBox_FormaPago.Items.Insert(0, "EFECTIVO");
            hopeComboBox_FormaPago.Items.Insert(1, "DEBITO");
            hopeComboBox_FormaPago.Items.Insert(2, "TRANSFERENCIA");
            hopeComboBox_FormaPago.SelectedIndex = 0;
            hopeComboBox_FormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            _formVender = formVender;
            hopeCheckBox_ImprimirCoimanda.Checked = true;
        }
        public double Total;
        public string Productos;
        private async void parrotButton_Vender_Click(object sender, EventArgs e) {
            var venta = new DetalleVenta {
                MedioPago = hopeComboBox_FormaPago.Text.ToString(),
                Productos = Productos,
                Total = Total,
                AperturaID = 1
            };

            // Guardar en BD  
            if (LogicaDetalleVenta.Instancia.CargarDetalleVenta(venta)) {
                MessageBox.Show("Venta cargada correctamente.");
            } else {
                MessageBox.Show("Error al cargar la venta.");
            }

            // Si quiere imprimir la comanda  
            if (hopeCheckBox_ImprimirCoimanda.Checked) {
                // Corrected method call to match the expected parameter type  
                await LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(venta.DetalleVentaID);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void materialSwitch_Cobrado_CheckedChanged(object sender, EventArgs e) {
            
        }
    }
}
