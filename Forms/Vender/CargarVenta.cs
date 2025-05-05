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
    public partial class CargarVenta : Form {
        public CargarVenta() {
            InitializeComponent();
            hopeComboBox_FormaPago.Items.Insert(0, "Efectivo");
            hopeComboBox_FormaPago.Items.Insert(2, "Debito");
            hopeComboBox_FormaPago.Items.Insert(1, "Transferencia");
            hopeComboBox_FormaPago.SelectedIndex = 0;
            hopeComboBox_FormaPago.DropDownStyle = ComboBoxStyle.DropDownList;

            hopeCheckBox_ImprimirCoimanda.Checked = true;
        }
    }
}
