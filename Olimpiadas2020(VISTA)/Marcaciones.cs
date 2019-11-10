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
using CONTROLADOR.Paises;
using CONTROLADOR.Marcaciones;

namespace Olimpiadas2020_VISTA_
{
    public partial class Marcaciones : Form
    {
        ModalidadesDTO modalidadesDTO = null;
        ModalidadesDAO modalidadesDAO = null;
        PaisesDTO paisesDTO = null;
        PaisesDAO paisesDAO = null;
        MarcacionesDTO marcacionesDTO = null;
        MarcacionesDAO marcacionesDAO = null;
        DataTable Dtt = null;
        DataTable DttPais = null;
        DataTable DttMarcaciones = null;

        public Marcaciones()
        {
            InitializeComponent();
        }

        private void ListarModalidades()
        {
            modalidadesDTO = new ModalidadesDTO();
            modalidadesDTO.opcion = 0;
            modalidadesDAO = new ModalidadesDAO(modalidadesDTO);

            Dtt = new DataTable();
            Dtt = modalidadesDAO.Listar();
            if (Dtt.Rows.Count > 0)
            {
                cmbmodalidades.DataSource = Dtt;

                DataRow dataRow = Dtt.NewRow();
                dataRow["nombre"] = "Seleccione";
                Dtt.Rows.InsertAt(dataRow, 0);

                cmbmodalidades.DisplayMember = "nombre";
                cmbmodalidades.ValueMember = "id";
            }
        }


        private void ListarPaises()
        {
            paisesDTO = new PaisesDTO();
            paisesDTO.opcion = 0;
            paisesDAO = new PaisesDAO(paisesDTO);

            DttPais = new DataTable();
            DttPais = paisesDAO.ListarPaises();
            if (DttPais.Rows.Count > 0)
            {
                cmbpais.DataSource = DttPais;

                DataRow dataRow = DttPais.NewRow();
                dataRow["Nombre"] = "Seleccione";
                DttPais.Rows.InsertAt(dataRow, 0);

                cmbpais.DisplayMember = "Nombre";
                cmbpais.ValueMember = "Código";
            }
        }

        private void ListarMarcaciones()
        {
            marcacionesDTO = new MarcacionesDTO();
            marcacionesDAO = new MarcacionesDAO(marcacionesDTO);

            DttMarcaciones = new DataTable();
            DttMarcaciones = marcacionesDAO.ListarMarcaciones();
            if (DttMarcaciones.Rows.Count > 0)
            {
                dtmarcaciones.DataSource = DttMarcaciones;
            }
            else
            {
                MessageBox.Show("No hay registros de Marcaciones");
            }
        }

        private void GuardarMarcacion()
        {
            marcacionesDTO = new MarcacionesDTO();
            marcacionesDTO.setModalidad(cmbmodalidades.SelectedValue.ToString());
            marcacionesDTO.setPais(cmbpais.SelectedValue.ToString());
            marcacionesDTO.setPosicion(cmdposicion.SelectedIndex.ToString());
            marcacionesDAO = new MarcacionesDAO(marcacionesDTO);

            marcacionesDAO.GuardarMarcacion();
            MessageBox.Show("Guardado exitoso", "Guardar");
            ListarMarcaciones();
        }

        private void Marcaciones_Load(object sender, EventArgs e)
        {
            ListarModalidades();
            ListarPaises();
            ListarMarcaciones();
            cmbmodalidades.SelectedIndex = 0;
            cmbpais.SelectedIndex = 0;
            cmdposicion.SelectedIndex = 0;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cmbmodalidades.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Selecciona una modalidad.");
            }
            else
            {
                if (cmbpais.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Selecciona un país.");
                }
                else
                {
                    if (cmdposicion.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("Selecciona una posición.");
                    }
                    else
                    {
                        GuardarMarcacion();
                    }
                }
            }
        }

        private void dtmarcaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Valor " + dtmarcaciones.Rows[dtmarcaciones.CurrentRow.Index].Cells[0].Value);

            //cmbmodalidades.SelectedText = dtmarcaciones.Rows[dtmarcaciones.CurrentRow.Index].Cells[0].Value.ToString();
            //            txtcodigo.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[0].Value.ToString();
            //            txtnombrepais.Text = dtpaises.Rows[dtpaises.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
