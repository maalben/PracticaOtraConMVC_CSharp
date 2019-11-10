using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODELO;

namespace CONTROLADOR.Paises
{
    public class PaisesDAO
    {
        ClsDatos clsDatos = null;
        PaisesDTO paisesDTO = null;
        DataTable listaDatos = null;

        public PaisesDAO(PaisesDTO paisesDTO) {
            this.paisesDTO = paisesDTO;
        }

        public DataTable ListarPaises() {
            listaDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter();

                parametros[0].ParameterName = "@opcion";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = paisesDTO.opcion;

                listaDatos = clsDatos.RetornaTabla(parametros, "spConsultaPaises");

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return listaDatos;
        }


        public void GuardarPais() {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[2];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@opcion";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = paisesDTO.opcion;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombrepais";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].SqlValue = paisesDTO.nombrepais;

                clsDatos.EjecutarSP(parametros, "spAccionesPaises");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
