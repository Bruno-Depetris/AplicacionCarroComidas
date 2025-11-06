using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.Vender {
    public partial class AgregarProducto : Form {
        public AgregarProducto() {
            InitializeComponent();
        }

        private void parrotButton_Agregar_Click(object sender, EventArgs e) {
            var nombre = hopeTextBox_Nombre.Text?.Trim();
            var precioText = hopeTextBox_Precio.Text?.Trim();

            if (string.IsNullOrWhiteSpace(nombre)) {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            if (!decimal.TryParse(precioText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal precio)) {
                // también probar con la cultura actual por si el usuario usó coma
                if (!decimal.TryParse(precioText, NumberStyles.Number, CultureInfo.CurrentCulture, out precio)) {
                    MessageBox.Show("Precio inválido. Use formato numérico, por ejemplo 120.50");
                    return;
                }
            }

            // Crear modelo. Asegúrate que la clase Comida tenga estas propiedades.
            var nuevo = new Comida {
                NombreComida = nombre,
                Precio = precio
            };

            try {
                // Intentamos usar la capa de lógica existente. Si tu método tiene otro nombre,
                // cámbialo por el correcto (por ejemplo RegistrarComida, InsertarComida, etc.)
                var creado = LogicaComida.Instancia.AgregarComida(nuevo);
                // si tu método devuelve bool o int, adapta la comprobación:
                // aquí asumimos que devuelve true si fue exitoso o el objeto creado.
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();   
        }
    }
}
