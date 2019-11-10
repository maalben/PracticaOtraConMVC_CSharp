using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR.Marcaciones
{
    public class MarcacionesDTO
    {

        private string modalidad;
        private string pais;
        private string posicion;

        public void setModalidad(string valor) {
            this.modalidad = valor;
        }

        public string getModalidad() {
            return this.modalidad;
        }

        public void setPais(string valor) {
            this.pais = valor;
        }

        public string getPais() {
            return this.pais;
        }

        public void setPosicion(string valor) {
            this.posicion = valor;
        }

        public string getPosicion() {
            return this.posicion;
        }

    }
}
