using AplicacionCarroComidas.Funcion.FormVender;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.Vender {
    public partial class Editar : Form {
        private FuncionEditar funcionEditar; // Declare an instance of FuncionEditar
        private Vender _formVender;
        public Editar(Vender formVender) {
            InitializeComponent();
            funcionEditar = new FuncionEditar(); // Initialize the instance
            funcionEditar.CargarTextBox(hopeComboBox_Productos); // Use the instance to call the method
            _formVender = formVender;
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            if (funcionEditar.Validacion(hopeComboBox_Productos, hopeTextBox_NuevoPrecio)) {
                if (funcionEditar.Editar(hopeComboBox_Productos, hopeTextBox_NuevoPrecio)) {
                    _formVender.CargarLabel(); // <-- Actualiza el que sí está abierto
                    Console.WriteLine("Producto editado");
                }
                this.Close();
            }


        }
    }
}
