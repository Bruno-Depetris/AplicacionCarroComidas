
using AplicacionCarroComidas.Forms.FormCaja;
using AplicacionCarroComidas.Forms.FormHistorial;
using AplicacionCarroComidas.Forms.FormMovimientos;
using AplicacionCarroComidas.Forms.Vender;
using AplicacionCarroComidas.Funcion.FormPrincipal;
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

namespace Repas {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            
            InitializeComponent();
            panel_Senializador.Visible = false;
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Caja(this));
        }

        public void ComprobarCaja(bool estado) {
            if (estado == false) {
                parrotButton_Ventas.Enabled = false;
                parrotButton_Caja.Enabled = true;
                parrotButton_Movimiento.Enabled = false;
                parrotButton_Historial.Enabled = false;
                MessageBox.Show("La caja no esta abierta, por favor abra la caja para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                parrotButton_Ventas.Enabled = true;
                parrotButton_Caja.Enabled = true;
                parrotButton_Movimiento.Enabled = true;
                parrotButton_Historial.Enabled = true;
            }
        }
        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.MoverPanel(parrotButton_Ventas, panel_Senializador);
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Vender());
        }

        private void parrotButton_Caja_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Caja(this));
            FuncionFormPrincipal.MoverPanel(parrotButton_Caja, panel_Senializador);
        }

        private void parrotButton_Movimiento_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Movimientos());
            FuncionFormPrincipal.MoverPanel(parrotButton_Movimiento, panel_Senializador);
        }

        private void parrotButton_Historial_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Historial());
            FuncionFormPrincipal.MoverPanel(parrotButton_Historial , panel_Senializador);
        }

        private void parrotPictureBox_Logo_Click(object sender, EventArgs e) {
            panel_Senializador.Visible = false;
        }
    }
}
