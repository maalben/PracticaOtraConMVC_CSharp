using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.Paises;

namespace Olimpiadas2020_VISTA_
{
    public partial class Paises : Form
    {
        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        DataTable Dtt = null;

        public Paises()
        {
            InitializeComponent();
            Listar();
            btnguardar.Enabled = false;
        }

        public void Listar() {
            paisesDTO = new PaisesDTO();
            paisesDTO.opcion = 0;
            paisesDAO = new PaisesDAO(paisesDTO);

            Dtt = new DataTable();
            Dtt = paisesDAO.ListarPaises();
            if (Dtt.Rows.Count > 0)
            {
                dtpaises.DataSource = Dtt;
            }
            else {
                MessageBox.Show("No hay registros de Paises");
            }
        }

        private void GuardarPais() {
            paisesDTO = new PaisesDTO();
            paisesDTO.opcion = 1;
            paisesDTO.nombrepais = txtnombre.Text;
            paisesDAO = new PaisesDAO(paisesDTO);

            paisesDAO.GuardarPais();
            MessageBox.Show("Guardado exitoso","Guardar");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarPais();
            Listar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim().Equals(""))
            {
                btnguardar.Enabled = false;
            }
            else {
                btnguardar.Enabled = true;
            }
        }

        private void Paises_Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
