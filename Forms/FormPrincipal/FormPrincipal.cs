using AplicacionCarroComidas.Forms;
using AplicacionCarroComidas.Forms.FormCaja;
using AplicacionCarroComidas.Forms.FormHistorial;
using AplicacionCarroComidas.Forms.FormMovimientos;
using AplicacionCarroComidas.Forms.Vender;
using AplicacionCarroComidas.Funcion.FormPrincipal;
using AplicacionCarroComidas.Private.DataBase.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Repas {
    public partial class FormPrincipal : Form {
        private ReaLTaiizor.Controls.ParrotButton botonActivo = null;

        public FormPrincipal() {
            InitializeComponent();
            ConfigurarEstilosIniciales();

            // Abrir la caja por defecto
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Caja(this));
            ActivarBoton(parrotButton_Caja);
        }

        private void ConfigurarEstilosIniciales() {
            // Configurar el señalizador
            panel_Senializador.Visible = true;
            panel_Senializador.Width = 4;

            // Hacer el logo y nombre clickeable para ir al dashboard
            parrotPictureBox_Logo.Cursor = Cursors.Hand;
            lblNombreApp.Cursor = Cursors.Hand;
        }

        public void ComprobarCaja(bool estado) {
            if (estado == false) {
                parrotButton_Ventas.Enabled = false;
                parrotButton_Caja.Enabled = true;
                parrotButton_Movimiento.Enabled = false;
                parrotButton_Historial.Enabled = false;
                parrotButton_Dashboard.Enabled = false;

                MessageBox.Show("La caja no está abierta. Por favor, abra la caja para continuar.",
                    "Caja Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                parrotButton_Ventas.Enabled = true;
                parrotButton_Caja.Enabled = true;
                parrotButton_Movimiento.Enabled = true;
                parrotButton_Historial.Enabled = true;
                parrotButton_Dashboard.Enabled = true;
            }
        }

        private void ActivarBoton(ReaLTaiizor.Controls.ParrotButton boton) {
            // Desactivar el botón anterior
            if (botonActivo != null) {
                botonActivo.TextColor = Color.FromArgb(200, 200, 200);
                botonActivo.BackgroundColor = Color.FromArgb(25, 25, 25);
            }

            // Activar el nuevo botón
            botonActivo = boton;
            boton.TextColor = Color.FromArgb(251, 111, 26);
            boton.BackgroundColor = Color.FromArgb(35, 35, 35);

            // Mover el panel señalizador
            FuncionFormPrincipal.MoverPanel(boton, panel_Senializador);
        }

        private void parrotButton_Dashboard_Click(object sender, EventArgs e) {
            try {
                int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
                FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new dashboard(id));
                ActivarBoton(parrotButton_Dashboard);
            } catch (Exception ex) {
                MessageBox.Show($"Error al abrir el dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Vender());
            ActivarBoton(parrotButton_Ventas);
        }

        private void parrotButton_Caja_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Caja(this));
            ActivarBoton(parrotButton_Caja);
        }

        private void parrotButton_Movimiento_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Movimientos());
            ActivarBoton(parrotButton_Movimiento);
        }

        private void parrotButton_Historial_Click(object sender, EventArgs e) {
            FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new Historial());
            ActivarBoton(parrotButton_Historial);
        }

        private void parrotPictureBox_Logo_Click(object sender, EventArgs e) {
            // Al hacer click en el logo o nombre, ir al dashboard
            try {
                int id = LogicaApertura.Instancia.ObtenerUltimaAperturaId();
                FuncionFormPrincipal.AbrirFormNuevo(panel_ContenedorFormularios, new dashboard(id));
                ActivarBoton(parrotButton_Dashboard);
            } catch (Exception ex) {
                MessageBox.Show($"Error al abrir el dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Agregar efecto hover a los botones (opcional)
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            // Agregar efectos hover personalizados si lo deseas
            AgregarEfectosHover();
        }

        private void AgregarEfectosHover() {
            // Puedes agregar efectos adicionales aquí si lo necesitas
            // Por ahora los botones ParrotButton ya tienen hover integrado
        }
    }
}