using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADOR.Marcaciones
{
    public class MarcacionesDAO
    {

        ClsDatos clsDatos = null;
        MarcacionesDTO marcacionesDTO = null;
        DataTable listaDatos = null;

        public MarcacionesDAO(MarcacionesDTO marcacionesDTO) {
            this.marcacionesDTO = marcacionesDTO;
        }

        public void GuardarMarcacion()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[3];
 
                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idmodalidad";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = marcacionesDTO.getModalidad();

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@idpais";
                parametros[1].SqlDbType = SqlDbType.Int;
                parametros[1].SqlValue = marcacionesDTO.getPais();

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@idposicion";
                parametros[2].SqlDbType = SqlDbType.Int;
                parametros[2].SqlValue = marcacionesDTO.getPosicion();

                clsDatos.EjecutarSP(parametros, "spGuardarMarcacion");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        #region LISTA DE MARCACIONES EN MEMORIA
        public DataTable ListarMarcaciones()
        {
            listaDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = null;

                //if (this.marcacionesDTO == null)
                //{
                //    parametros = new SqlParameter[3];

                //    parametros[0] = new SqlParameter();
                //    parametros[0].ParameterName = "@idpais";
                //    parametros[0].SqlDbType = SqlDbType.Int;
                //    parametros[0].SqlValue = marcacionesDTO.getModalidad();
                //}
                //else
                //{
                    parametros = null;
                //}
                listaDatos = clsDatos.RetornaTabla(parametros, "spConsultaMarcaciones");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return listaDatos;

        }
        #endregion

    }
}
