using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormMovimientos {
    public partial class Movimientos : Form {
        private int aperturaActual = LogicaApertura.Instancia.ObtenerUltimaAperturaId(); // ID de apertura activa (puedes cambiarlo según tu lógica)

        public Movimientos() {
            InitializeComponent();
            CargarHistorial();
            hopeComboBox_Metodo.DropDownStyle = ComboBoxStyle.DropDownList;
            hopeComboBox_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;

            hopeComboBox_Metodo.Items.Insert(0, "Efectivo");
            hopeComboBox_Metodo.Items.Insert(1, "Transferencia");
            hopeComboBox_Metodo.Items.Insert(2, "Debito");



            hopeComboBox_Tipo.Items.Insert(0, "Ingreso");
            hopeComboBox_Tipo.Items.Insert(1, "Egreso");

            hopeComboBox_Tipo.SelectedIndex = 0;
            hopeComboBox_Metodo.SelectedIndex = 0;
        }

        private void CargarHistorial() {
            poisonDataGridView_HistorialMovimientos.Rows.Clear();
            int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
            DataTable tabla = LogicaMovimientosCaja.Instancia.MostrarMovimientosCaja(id);

            foreach (DataRow row in tabla.Rows) {
                poisonDataGridView_HistorialMovimientos.Rows.Add(
                    Convert.ToInt32(row["MovimientosCajaID"]),
                    row["Metodo"].ToString(),
                    Convert.ToDouble(row["Monto"]),
                    row["Motivo"].ToString()
                );
            }
        }

        private void parrotButton_CargarMovimiento_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(hopeComboBox_Tipo.Text) ||
                string.IsNullOrWhiteSpace(hopeComboBox_Metodo.Text) || string.IsNullOrWhiteSpace(hopeTextBox_Monto.Text)) {
                MessageBox.Show("Completa todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var movimiento = new MovimientoCaja {
                Motivo = hopeRichTextBox_Motivo.Text,
                Tipo = hopeComboBox_Tipo.Text,
                Monto = double.Parse(hopeTextBox_Monto.Text),
                Metodo = hopeComboBox_Metodo.Text,
                AperturaID = aperturaActual
            };

            bool ok = LogicaMovimientosCaja.Instancia.CargarMovimientoCaja(movimiento);

            if (ok) {
                MessageBox.Show("Movimiento cargado con éxito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorial();
                hopeRichTextBox_Motivo.Clear();
                hopeTextBox_Monto.Clear();
            } else {
                MessageBox.Show("Error al cargar el movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
