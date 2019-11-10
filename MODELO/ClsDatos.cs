using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MODELO
{
    public class ClsDatos
    {
        #region Declaración de variables
        SqlConnection CnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        string strCadenaConexion = string.Empty;
        #endregion

        #region Constructor de la clase ClsDatos
        public ClsDatos() {
            this.strCadenaConexion = @"Data Source=DESKTOP-S52OE83\SQLEXPRESS;Initial Catalog=bdolimpiadas;Integrated Security=True";
        }
        #endregion

        #region Método para traer los datos en memoria
        public DataTable RetornaTabla(SqlParameter[] parametros, string spConsultaDatos) {
            //Select (Todos los registros de una tabla)
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                CnnConexion = new SqlConnection(this.strCadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = CnnConexion;
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = spConsultaDatos;
                //cmdComando.Parameters.AddRange(parametros);

                daAdaptador = new SqlDataAdapter(cmdComando);
                daAdaptador.Fill(Dtt);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally {
                CnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return Dtt;
        }
        #endregion

        #region Métodos de acción en la base de datos
        public void EjecutarSP(SqlParameter[] parametros, string procedimientoAccion) {
            //Insertar
            //Actualizar
            //Eliminar
            try
            {
                CnnConexion = new SqlConnection(this.strCadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = CnnConexion;
                CnnConexion.Open();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = procedimientoAccion;
                cmdComando.Parameters.AddRange(parametros);
                cmdComando.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion
















    }
}
