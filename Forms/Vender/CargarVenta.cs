using AplicacionCarroComidas.Forms.Notificacion;
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
        public string Productos;

        private async void parrotButton_Vender_Click(object sender, EventArgs e) {
            int aperturaID = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
            var venta = new DetalleVenta {
                MedioPago = hopeComboBox_FormaPago.Text.ToString(),
                Productos = Productos,
                Total = Total,
                AperturaID = aperturaID
            };

            int detalleVentaID = LogicaDetalleVenta.Instancia.CargarDetalleVenta(venta);


            if (detalleVentaID > 0) {
                // 1. Registrar el movimiento de caja
                var movimiento = new MovimientoCaja {
                    Motivo = "Venta",
                    Tipo = "Ingreso",
                    Monto = Total,
                    Metodo = venta.MedioPago,
                    AperturaID = venta.AperturaID
                };

                bool movimientoExitoso = LogicaMovimientosCaja.Instancia.CargarMovimientoCaja(movimiento);
                if (!movimientoExitoso) {
                    MessageBox.Show("Error al registrar el movimiento de caja.");
                }

                // 2. Mostrar mensaje de éxito y continuar
                Mensaje msj = new Mensaje();
                msj.Show("Éxito", "Venta Realizada", Color.Green, Color.White, Mensaje.TipoIcono.Cash, Mensaje.TipoSonido.Money);
                _formVender.Restaurar();

                if (hopeCheckBox_ImprimirCoimanda.Checked) {
                    await LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(detalleVentaID);
                    timer_Espera.Start();
                    timer_Espera.Stop();
                    await LogicaDetalleVenta.Instancia.ImprimirDetalleVentaAsync(detalleVentaID);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void parrotButton_Volver_Click(object sender, EventArgs e) {
            _formVender.Restaurar();
            this.Close();
        }
    }
}
