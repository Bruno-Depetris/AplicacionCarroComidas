using AplicacionCarroComidas.Forms.FormMovimientos;
using AplicacionCarroComidas.Forms.Notificacion;
using AplicacionCarroComidas.Private.DataBase;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using Repas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormCaja {
    public partial class Caja : Form {
        private FormPrincipal _formPrincipal;
        public bool estado = false;
        public Caja(FormPrincipal form) {
            InitializeComponent();
            _formPrincipal = form;
            ValidarEstadoCaja();
            Actualizar();
        }
        private void ValidarEstadoCaja() {
            estado = LogicaApertura.Instancia.EstaCajaAbierta();
            bigLabel_Estado.Visible = true;
            bigLabel_Estado.Text = estado ? "Caja Abierta" : "Caja Cerrada";
            _formPrincipal.ComprobarCaja(estado);
        }
        public void Actualizar() {
            var id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();

            var saldos = LogicaCaja.Instancia.ObtenerSaldosCaja(id);

            label_Efectivo.Text = $"${saldos.efectivo:N2}";
            label_Debit.Text = $"${saldos.debito:N2}";
            label_Transf.Text = $"${saldos.transferencia:N2}";
        }

        private void parrotButton_CerrarCaja_Click(object sender, EventArgs e) {
            if (!double.TryParse(hopeTextBox_IngreseCambio.Text, out double monto)) {
                MessageBox.Show("Ingrese un monto válido.");
                return;
            }

            if (!estado) {
                // ABRIR CAJA
                var apertura = new Apertura {
                    MontoInicio = monto,
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                    Hora = DateTime.Now.ToString("HH:mm:ss")
                };



                if (LogicaApertura.Instancia.CargarApertura(apertura)) {
                    // Obtener ID real de la apertura recién insertada
                    apertura.AperturaID = LogicaApertura.Instancia.ObtenerUltimaAperturaId();

                    // Asociar nueva apertura a la tabla Caja
                    AsociarAperturaACaja(apertura);

                    var movimiento = new MovimientoCaja {
                        Monto = monto,
                        AperturaID = apertura.AperturaID,
                        Tipo = "Ingreso",
                        Motivo = "Apertura",
                        Metodo = "Efectivo"
                    };

                    bool estado = LogicaMovimientosCaja.Instancia.CargarMovimientoCaja(movimiento);
                    if (estado) {
                        new Mensaje().Show("Caja", "Abierta con éxito", Color.Yellow, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                        Actualizar();
                    } else {
                        new Mensaje().Show("Error", "No se pudo registrar el movimiento de apertura", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    }

                } else {
                    new Mensaje().Show("Error", "No se pudo abrir la caja", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                }

            } else {
                // CERRAR CAJA
                int aperturaId = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
                if (aperturaId == -1) {
                    MessageBox.Show("No se encontró una apertura activa.");
                    return;
                }


                string montoTexto = hopeTextBox_IngreseCambio.Text.Replace(",", ".");

                // Intentar convertir el valor con el formato corregido
                if (!double.TryParse(montoTexto, out double montoEnCaja)) {
                    MessageBox.Show("Ingrese un monto válido.");
                    return;
                }




                // Validar que el monto ingresado coincida con el monto real
                double diferencia = monto - montoEnCaja;
                if (Math.Abs(diferencia) > 0.01) { // Usamos tolerancia por posibles decimales
                    string estado = diferencia > 0 ? "sobra" : "falta";
                    diferencia = Math.Abs(diferencia);
                    MessageBox.Show($"El monto ingresado no coincide con el efectivo.\nTe {estado} ${diferencia:F2}.");
                    return;
                }

                var cierre = new Cierre {
                    MontoFinal = monto,
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                    Hora = DateTime.Now.ToString("HH:mm:ss")
                };

                if (LogicaApertura.Instancia.CargarCierre(cierre, aperturaId)) {
                    new Mensaje().Show("Caja", "Cerrada con éxito", Color.Green, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                } else {
                    new Mensaje().Show("Error", "No se pudo cerrar la caja", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                }

            }

            ValidarEstadoCaja();
        }

        private void AsociarAperturaACaja(Apertura apertura) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "INSERT INTO Cajas (AperturaID) VALUES (@aperturaId)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@aperturaId", apertura.AperturaID);
                    cmd.ExecuteNonQuery();
                }
            } catch {
                MessageBox.Show("No se pudo registrar la caja.");
            } finally {
                cn?.Close();
            }
        }

        private void hopeTextBox_IngreseCambio_KeyPress(object sender, KeyPressEventArgs e) {
            // Solo números, punto y control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') {
                e.Handled = true;
            }

            // Solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) {
                e.Handled = true;
            }
        }
    }
}
