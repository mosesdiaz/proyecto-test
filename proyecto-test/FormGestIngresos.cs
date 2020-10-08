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
    public partial class FormGestIngresos : Form
    {
        private tipo_ingreso ingreso { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormGestIngresos()
        {
            InitializeComponent();
        }

        private void FormGestIngresos_Load(object sender, EventArgs e)
        {
            consultarIngresos();
        }

        private void consultarIngresos()
        {
            dgIngresos.DataSource = entities.tipo_ingreso.ToList();
            //esconde la navigational property de salario que sirve de clave foranea para la clase salario
            dgIngresos.Columns["empleado_ingreso"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void consultarPorCriterio()
        {
            var deducciones = from em in entities.tipo_ingreso
                              where (em.id_ingreso.ToString().StartsWith(txtInput.Text) ||
                              em.nombre.StartsWith(txtInput.Text) ||
                              em.estado.ToString().StartsWith(txtInput.Text)
                              )
                              select em;
            dgIngresos.DataSource = deducciones.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdIngresos formEdIngresos = new FormEdIngresos();
            formEdIngresos.Show();
        }

        private void FormGestIngresos_Activated(object sender, EventArgs e)
        {
            consultarIngresos();
        }

        private void dgIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewRow fila = this.dgIngresos.SelectedRows[0];
                tipo_ingreso ingreso = new tipo_ingreso();
                ingreso.id_ingreso = Int32.Parse(fila.Cells[0].Value.ToString());
                ingreso.nombre = fila.Cells[1].Value.ToString();
                ingreso.estado = Convert.ToBoolean(fila.Cells[2].Value);
                FormEdIngresos formEd = new FormEdIngresos();
                formEd.ingreso = ingreso;
                formEd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }
    }
}
