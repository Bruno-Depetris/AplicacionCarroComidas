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
            foreach (var dato in LogicaProducto.Instancia.Mostrar()) {
                int i = 0;
                comboBox.Items.Insert(i, dato.Nombre.ToString());
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
                foreach (var dato in LogicaProducto.Instancia.Mostrar()) {
                    if (combobox.Text == dato.Nombre) {
                        Producto prod = new Producto();
                        prod.IdProducto = dato.IdProducto;
                        prod.Nombre = combobox.Text;
                        prod.Precio = Convert.ToDouble(txtbox.Text);
                        
        
                        LogicaProducto.Instancia.Editar(prod);
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
