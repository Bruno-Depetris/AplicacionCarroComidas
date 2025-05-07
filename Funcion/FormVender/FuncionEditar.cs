using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionCarroComidas.Private.DataBase;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
namespace AplicacionCarroComidas.Funcion.FormVender {
    public class FuncionEditar {

        public void CargarTextBox(ReaLTaiizor.Controls.HopeComboBox comboBox) {

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Insert(0, "Seleccionar");
            comboBox.SelectedIndex = 0;

            foreach (var dato in LogicaComida.Instancia.MostrarComida()) {
                int i = 0;
                comboBox.Items.Insert(i, dato.NombreComida.ToString());
            }
        }

        public bool Validacion(ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Productos, ReaLTaiizor.Controls.HopeTextBox hopeTextBox_NuevoPrecio) {
            if (string.IsNullOrEmpty(hopeComboBox_Productos.Text) || hopeComboBox_Productos.Text == "Seleccionar") {
                MessageBox.Show("Seleccione un producto");
                return false;
            }
            if (string.IsNullOrEmpty(hopeTextBox_NuevoPrecio.Text)) {
                MessageBox.Show("Ingrese un nuevo precio");
                return false;
            }
            return true;
        }

        public bool Editar(ReaLTaiizor.Controls.HopeComboBox combobox, ReaLTaiizor.Controls.HopeTextBox txtbox) {
            try {
                foreach (var dato in LogicaComida.Instancia.MostrarComida()) {
                    if (combobox.Text == dato.NombreComida) {

                        Comida comida = new Comida();
                        comida.ComidaID = dato.ComidaID;
                        comida.NombreComida = combobox.Text;
                        comida.Precio = Convert.ToDecimal(txtbox.Text);


                        LogicaComida.Instancia.EditarComida(comida);
                    }
                }
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}