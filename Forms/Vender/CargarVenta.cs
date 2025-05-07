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
            hopeComboBox_FormaPago.Items.Insert(0, "Efectivo");
            hopeComboBox_FormaPago.Items.Insert(1, "Debito");
            hopeComboBox_FormaPago.Items.Insert(2, "Transferencia");
            hopeComboBox_FormaPago.SelectedIndex = 0;
            hopeComboBox_FormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            _formVender = formVender;
            hopeCheckBox_ImprimirCoimanda.Checked = true;
        }
        public double Total;
        private void parrotButton_Vender_Click(object sender, EventArgs e) {
            // Validación básica


            // Crear la venta
            var venta = new Venta {
                MetodoPago = hopeComboBox_FormaPago.Text,
                Fecha = DateTime.Now,
                Total = Total,
                
                IdCaja = 1, // Cambiar por el ID de la caja actual
                EstadoCobro = "PENDIENTE", // Cambiar por el estado de cobro actual

            };

            // Guardar en BD
            LogicaVenta.Instancia.Agregar(venta);
            

                // Si quiere imprimir la comanda
            if (hopeCheckBox_ImprimirCoimanda.Checked) {
                LogicaDetalleVenta.Instancia.ImprimirComanda(venta.IdVenta);
            }

                this.DialogResult = DialogResult.OK;
                this.Close();
         
        }
    }
}
