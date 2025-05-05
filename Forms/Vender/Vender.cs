using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.Vender {
    public partial class Vender : Form {
        public Vender() {
            InitializeComponent();
        }

        private void panel_Senializador_Click(object sender, EventArgs e) {
            Console.WriteLine("Panel clicked");
        }

        private void Vender_Load(object sender, EventArgs e) {

        }
    }
}
