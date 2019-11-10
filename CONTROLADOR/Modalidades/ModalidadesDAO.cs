using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADOR.Modalidades
{
    public class ModalidadesDAO
    {

        ClsDatos clsDatos = null;
        ModalidadesDTO modalidadesDTO = null;
        DataTable listaDatos = null;

        public ModalidadesDAO(ModalidadesDTO modalidadesDTO) {
            this.modalidadesDTO = modalidadesDTO;
        }

#region LISTA DE MODADLIDADES EN MEMORIA
        public DataTable Listar() {
            listaDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter();

                parametros[0].ParameterName = "@opcion";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = modalidadesDTO.opcion;                    
                listaDatos = clsDatos.RetornaTabla(parametros, "spConsultaModalidades");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return listaDatos;
        }
#endregion

        public void GuardarModalidad() {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter();

                parametros[0].ParameterName = "@nombre";
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[0].SqlValue = modalidadesDTO.nombre;

                clsDatos.EjecutarSP(parametros, "SPGuardarModalidades");


            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

    }
}
