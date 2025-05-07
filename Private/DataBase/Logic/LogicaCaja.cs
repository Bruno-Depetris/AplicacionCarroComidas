using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase.Logic {
    public class LogicaCaja {
        private static LogicaCaja _LogicaCaja;

        public static LogicaCaja Instancia {
            get {
                if (_LogicaCaja == null) {
                    _LogicaCaja = new LogicaCaja();
                }
                return _LogicaCaja;
            }
        }

        public bool AbrirCaja(Caja caja) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("INSERT INTO Caja(fecha_apertura, cambio_inicial, estado) VALUES(@fecha, @cambio, 'ABIERTA')", con);
                    cmd.Parameters.AddWithValue("@fecha", caja.FechaApertura);
                    cmd.Parameters.AddWithValue("@cambio", caja.CambioInicial);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public bool CerrarCaja(int idCaja, DateTime horaCierre, double cambioFinal) {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("UPDATE Caja SET hora_cierre = @hora, cambio_final = @final, estado = 'CERRADA' WHERE id_caja = @id", con);
                    cmd.Parameters.AddWithValue("@hora", horaCierre);
                    cmd.Parameters.AddWithValue("@final", cambioFinal);
                    cmd.Parameters.AddWithValue("@id", idCaja);
                    return cmd.ExecuteNonQuery() > 0;
                }
            } catch {
                return false;
            }
        }

        public List<Caja> MostrarCajas() {
            var lista = new List<Caja>();
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Caja", con);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        lista.Add(new Caja {
                            IdCaja = Convert.ToInt32(dr["id_caja"]),
                            FechaApertura = Convert.ToDateTime(dr["fecha_apertura"]),
                            HoraCierre = dr["hora_cierre"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["hora_cierre"]),
                            CambioInicial = Convert.ToDouble(dr["cambio_inicial"]),
                            CambioFinal = dr["cambio_final"] == DBNull.Value ? null : (double?)Convert.ToDouble(dr["cambio_final"]),
                            Estado = dr["estado"].ToString()
                        });
                    }
                }
            } catch { }
            return lista;
        }

        public Caja ObtenerCajaAbierta() {
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    var cmd = new SQLiteCommand("SELECT * FROM Caja WHERE estado = 'ABIERTA' ORDER BY id_caja DESC LIMIT 1", con);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        return new Caja {
                            IdCaja = Convert.ToInt32(dr["id_caja"]),
                            FechaApertura = Convert.ToDateTime(dr["fecha_apertura"]),
                            HoraCierre = dr["hora_cierre"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["hora_cierre"]),
                            CambioInicial = Convert.ToDouble(dr["cambio_inicial"]),
                            CambioFinal = dr["cambio_final"] == DBNull.Value ? null : (double?)Convert.ToDouble(dr["cambio_final"]),
                            Estado = dr["estado"].ToString()
                        };
                    }
                }
            } catch { }
            return null;
        }
    }

}
