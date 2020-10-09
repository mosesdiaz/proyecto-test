using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_test
{
    public partial class FormGestNomina : Form
    {
        private nomina nomina { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormGestNomina()
        {
            InitializeComponent();
        }

        private void FormGestNomina_Load(object sender, EventArgs e)
        {
            consultarNomina();
        }

        private void consultarNomina()
        {
            dgNomina.DataSource = entities.nomina.ToList();
            //esconde la navigational property de salario que sirve de clave foranea para la clase salario
            dgNomina.Columns["empleado"].Visible = false;
        }

        private void consultarPorCriterio()
        {
            var nominas = from em in entities.nomina
                              where (em.id_nomina.ToString().StartsWith(txtInput.Text) ||
                              em.tipo.StartsWith(txtInput.Text) 
                              )
                              select em;
            dgNomina.DataSource = nominas.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdNomina nuevaNomina = new FormEdNomina();
            nuevaNomina.Show();
        }

        private void dgNomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgNomina.SelectedRows[0];
                nomina nomina = new nomina();
                nomina.id_nomina = Int32.Parse(fila.Cells[0].Value.ToString());
                nomina.tipo = fila.Cells[1].Value.ToString();
                FormEdNomina formEd = new FormEdNomina();
                formEd.nomina = nomina;
                formEd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }

        private void FormGestNomina_Activated(object sender, EventArgs e)
        {
            consultarNomina();
        }
    }
}
