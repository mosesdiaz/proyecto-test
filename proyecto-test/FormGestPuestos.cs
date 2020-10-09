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
    public partial class FormGestPuestos : Form
    {
        private puesto puesto { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormGestPuestos()
        {
            InitializeComponent();
        }

        private void FormGestPuestos_Load(object sender, EventArgs e)
        {
            consultarPuestos();
        }

        private void consultarPuestos()
        {
            dgPuestos.DataSource = entities.puesto.ToList();
            //esconde la navigational property de salario que sirve de clave foranea para la clase salario
            dgPuestos.Columns["empleado"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void consultarPorCriterio()
        {
            var puestos = from em in entities.puesto
                              where (em.id_puesto.ToString().StartsWith(txtInput.Text) ||
                              em.nombre.StartsWith(txtInput.Text) ||
                              em.nive_riesgo_salario.ToString().StartsWith(txtInput.Text) ||
                              em.nivel_minimo_salario.ToString().StartsWith(txtInput.Text) ||
                              em.nivel_maximo_salario.ToString().StartsWith(txtInput.Text)
                              )
                              select em;
            dgPuestos.DataSource = puestos.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdPuestos nuevoPuesto = new FormEdPuestos();
            nuevoPuesto.Show();
        }

        private void FormGestPuestos_Activated(object sender, EventArgs e)
        {
            consultarPuestos();
        }

        private void dgPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgPuestos.SelectedRows[0];
                puesto puesto = new puesto();
                puesto.id_puesto = Int32.Parse(fila.Cells[0].Value.ToString());

                puesto.nombre = fila.Cells[1].Value.ToString();
                puesto.nive_riesgo_salario = fila.Cells[2].Value.ToString();
                puesto.nivel_minimo_salario = decimal.Parse(fila.Cells[3].Value.ToString());
                puesto.nivel_maximo_salario = decimal.Parse(fila.Cells[4].Value.ToString());

                FormEdPuestos formEd = new FormEdPuestos();
                formEd.puesto = puesto;
                formEd.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar deduccion " + ex.Message);
            }
        }
    }
}
