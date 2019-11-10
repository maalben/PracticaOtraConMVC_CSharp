using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.Modalidades;

namespace Olimpiadas2020_VISTA_
{
    public partial class Modalidades : Form
    {
        ModalidadesDTO modalidadesDTO = null;
        ModalidadesDAO modalidadesDAO = null;
        DataTable Dtt = null;

        public Modalidades()
        {
            InitializeComponent();
        }

        private void Listar() {
            modalidadesDTO = new ModalidadesDTO();
            modalidadesDTO.opcion = 0;
            modalidadesDAO = new ModalidadesDAO(modalidadesDTO);

            Dtt = new DataTable();
            Dtt = modalidadesDAO.Listar();
            if (Dtt.Rows.Count > 0) {
                dtmodalidades.DataSource = Dtt;
            }
        }

        private void Guardar() {
            modalidadesDTO = new ModalidadesDTO();
            modalidadesDTO.nombre = txtnombre.Text;
            modalidadesDAO = new ModalidadesDAO(modalidadesDTO);

            modalidadesDAO.GuardarModalidad();
            MessageBox.Show("Modalidad guardada correctamente", "Mensaje");
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void Modalidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
            this.Listar();
        }
    }
}
