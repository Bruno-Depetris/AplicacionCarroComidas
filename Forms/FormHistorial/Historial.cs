using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.FormHistorial {
    public partial class Historial : Form {
        public Historial() {
            InitializeComponent();
            poisonDateTime_Hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            poisonDateTime_Desde.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void poisonDateTime2_ValueChanged(object sender, EventArgs e) {

        }
    }
}
