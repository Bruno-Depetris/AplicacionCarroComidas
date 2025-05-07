using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaComida {
        private static LogicaComida _instancia;
        public static LogicaComida Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaComida();
                }
                return _instancia;
            }
        }

        public List<Comida> MostrarComida() {
            List<Comida> listaComidas = new List<Comida>();
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                var query = "SELECT * FROM Comidas";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            var comida = new Comida {
                                ComidaID = Convert.ToInt32(reader["ComidaID"]),
                                NombreComida = reader["NombreComida"].ToString(),
                                Precio = reader["Precio"] != DBNull.Value ? Convert.ToDecimal(reader["Precio"]) : 0
                            };
                            listaComidas.Add(comida);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al mostrar comida: " + ex.Message);
            } finally {
                cn?.Close();
            }
            return listaComidas;
        }



        public bool EditarComida(Comida comida) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = "UPDATE Comidas SET NombreComida = @nombre, Precio = @precio WHERE ComidaID = @id";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@nombre", comida.NombreComida);
                    cmd.Parameters.AddWithValue("@precio", comida.Precio);
                    cmd.Parameters.AddWithValue("@id", comida.ComidaID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }
    }


}
