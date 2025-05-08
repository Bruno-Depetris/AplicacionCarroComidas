using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionCarroComidas.Private.DataBase.Model;
namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaCaja {
        private static LogicaCaja _instancia;
        public static LogicaCaja Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new LogicaCaja();
                }
                return _instancia;
            }
        }

        public bool CargarCaja(Caja caja) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();
                string query = @"INSERT INTO Cajas 
                        (AperturaID, CierreID, SaldoEfectivo, SaldoDebito, SaldoTransferencia) 
                         VALUES (@apertura, @cierre, @efectivo, @debito, @transferencia)";
                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@apertura", caja.AperturaID);
                    cmd.Parameters.AddWithValue("@cierre", caja.CierreID);
                    cmd.Parameters.AddWithValue("@efectivo", caja.SaldoEfectivo);
                    cmd.Parameters.AddWithValue("@debito", caja.SaldoDebito);
                    cmd.Parameters.AddWithValue("@transferencia", caja.SaldoTransferencia);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            } finally {
                cn?.Close();
            }
        }
        public (double efectivo, double debito, double transferencia) ObtenerSaldosCaja(int aperturaID) {
            SQLiteConnection cn = null;
            try {
                cn = Conectar.ObtenerConexion();

                string query = @"SELECT SaldoEfectivo, SaldoDebito, SaldoTransferencia 
                         FROM Cajas 
                         WHERE AperturaID = @aperturaID";

                using (var cmd = new SQLiteCommand(query, cn)) {
                    cmd.Parameters.AddWithValue("@aperturaID", aperturaID);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            double efectivo = reader.GetDouble(0);
                            double debito = reader.GetDouble(1);
                            double transferencia = reader.GetDouble(2);
                            return (efectivo, debito, transferencia);
                        }
                    }
                }

                return (0, 0, 0); // Si no encuentra la caja, devuelve ceros
            } catch {
                return (0, 0, 0);
            } finally {
                cn?.Close();
            }
        }


    }

}
