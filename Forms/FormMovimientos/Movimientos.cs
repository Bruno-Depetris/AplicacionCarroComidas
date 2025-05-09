using System;
using AplicacionCarroComidas.Private.DataBase.Model;
using AplicacionCarroComidas.Private.DataBase;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Forms.Notificacion;
using AplicacionCarroComidas.Forms.FormCaja;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacionCarroComidas.Forms.FormMovimientos
{
    public partial class Movimientos : Form 
    {

        private FormCaja.Caja _formCaja;
        public Movimientos(FormCaja.Caja formCaja)
        {
            InitializeComponent();
            _formCaja = formCaja;
            
        }

        private void ValidarEstadocaja()
        {
            bool estado = LogicaApertura.Instancia.EstaCajaAbierta();
            if (estado == false)
            {
                new Mensaje().Show("Movimiento", "La caja no esta abierta, por favor abra la caja para continuar", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return;
            }
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e)
        {

        }


       


        public void cargarComboBox()
        {
            string[] tipomov = { "Ingreso", "Egreso" };
            string[] formapago = { "Efectivo", "Debito", "Transferencia" };

            foreach (var tipo in tipomov)
            {
                hopeComboBox_TipoMovimiento.Items.Add(tipo);
            }

            foreach (var forma in formapago)
            {
                hopeComboBox_Medio.Items.Add(forma);
            }
        }

        public void limpiarcampos()
        {
            hopeComboBox_Medio.SelectedIndex = -1;
            hopeComboBox_TipoMovimiento.SelectedIndex = -1;
            hopeRichTextBox_Motivo.Clear();
            hopeTextBox_Monto.Clear();
        }

        


        public void CargarDataGrid()
        {
            MostrarUltimosMovimientos(poisonDataGridView_HistorialMovimientos);
        }

        public static void MostrarUltimosMovimientos(DataGridView dgv)
        {
            dgv.Rows.Clear();
            int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
            var Movimiento = LogicaMovimientosCaja.Instancia.MostrarMovimientosCaja(id);
            foreach (var dato in Movimiento)
            {
                dgv.Rows.Add(dato.MovimientosCajaID, dato.Motivo, dato.Tipo, dato.Monto, dato.Metodo);
            }
        }

        
        public bool ValidarCampos()
        {
            bool respuesta = false;
            if (string.IsNullOrEmpty(hopeRichTextBox_Motivo.Text.ToString()))
            {
                new Mensaje().Show("Movimiento", "Debe completar el campo correspondiente al MOTIVO del movimiento.", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                hopeRichTextBox_Motivo.Focus();
                return respuesta;
            }

            if (!double.TryParse(hopeTextBox_Monto.Text, out double monto))
            {
                new Mensaje().Show("Movimiento", "Ingrese un monto valido.", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                hopeTextBox_Monto.Focus();
                return respuesta;
            }

            if (hopeComboBox_TipoMovimiento.SelectedIndex == -1)
            {
                new Mensaje().Show("Movimiento", "Debe seleccionar el tipo de movimiento.", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                hopeComboBox_TipoMovimiento.Focus();
                return respuesta;
            }

            if (hopeComboBox_Medio.SelectedIndex == -1)
            {
                new Mensaje().Show("Movimiento", "Debe seleccionar el medio de pago a utilizar.", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                hopeComboBox_Medio.Focus();
                return respuesta;
            }

            return true;
        }



        private void parrotButton_CargarMovimiento_Click(object sender, EventArgs e)
        {
            ValidarEstadocaja();
            ValidarCampos();
            if (!ValidarCampos())
            {
                return;
            }

            var movimiento = new MovimientoCaja
            {
                Monto = Convert.ToDouble(hopeTextBox_Monto.Text),
                AperturaID = LogicaApertura.Instancia.ObtenerUltimaAperturaId(),
                Tipo = hopeComboBox_TipoMovimiento.Text,
                Motivo = hopeRichTextBox_Motivo.Text,
                Metodo = hopeComboBox_Medio.Text
            };
            bool estado = LogicaMovimientosCaja.Instancia.CargarMovimientoCaja(movimiento);

            if (estado)
            {
                new Mensaje().Show("Movimiento", "Movimiento cargado con éxito", Color.Yellow, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);

            }
            else
            {
                new Mensaje().Show("Movimiento", "Error al cargar el movimiento", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return;
            }

            _formCaja.Actualizar();
            CargarDataGrid();
            limpiarcampos();


        }

        private void Movimientos_Load(object sender, EventArgs e)
        {

            cargarComboBox();
            CargarDataGrid();
        }
    }
}
