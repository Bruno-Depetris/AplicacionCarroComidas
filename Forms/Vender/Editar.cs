using AplicacionCarroComidas.Funcion.FormVender;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Windows.Forms;


namespace AplicacionCarroComidas.Forms.Vender {
    public partial class Editar : Form {
        private FuncionEditar funcionEditar;
        private int _comidaId;
        public Comida UpdatedComida { get; private set; }
                
        public Editar(int comidaId) {
            InitializeComponent();
            funcionEditar = new FuncionEditar();
            _comidaId = comidaId;
            funcionEditar.CargarTextBox(hopeComboBox_Productos);
            CargarDatos();
        }

        private void CargarDatos() {
            // Asumo que existe un método para obtener por id; si no, usa MostrarComida y filtra.
            var comida = LogicaComida.Instancia.MostrarComida().Find(c => c.ComidaID == _comidaId);
            if (comida != null) {
                hopeComboBox_Productos.Text = comida.NombreComida;
                hopeTextBox_NuevoPrecio.Text = comida.Precio.ToString("0.00");
            }
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            if (!funcionEditar.Validacion(hopeComboBox_Productos, hopeTextBox_NuevoPrecio)) return;

            // Ejecuta la edición (funcionEditar.Editar debe usar el _comidaId internamente o puedes adaptar)
            var success = funcionEditar.Editar(hopeComboBox_Productos, hopeTextBox_NuevoPrecio);
            if (success) {
                // Refresca el objeto desde BD para devolverlo al caller
                UpdatedComida = LogicaComida.Instancia.MostrarComida().Find(c => c.ComidaID == _comidaId);
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("No se pudo editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
    }

    // Cuando crees la ventana de edición desde la tarjeta:
    // btnEdit.Click += (s, e) => {
    //     var p = (Comida)((Button)s).Tag;
    //     using (var form = new Editar(p.ComidaID)) {
    //         var dr = form.ShowDialog();
    //         if (dr == DialogResult.OK && form.UpdatedComida != null) {
    //             // Opción A: recargar todo
    //             CargarProductos();

    //             // Opción B (más eficiente): actualizar solo la tarjeta correspondiente usando form.UpdatedComida
    //             // ActualizarTarjeta(form.UpdatedComida);
    //         }
    //     }
    // };
}