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
    public partial class FormGestDeducciones : Form
    {
        private tipo_deduccion deduccion { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormGestDeducciones()
        {
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgDeducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestDeducciones_Load(object sender, EventArgs e)
        {
            consultarDeducciones();
        }

        private void consultarDeducciones()
        {
            dgDeducciones.DataSource = entities.tipo_deduccion.ToList();
            //esconde la navigational property de salario que sirve de clave foranea para la clase salario
            dgDeducciones.Columns["empleado_deduccion"].Visible = false;
        }

        private void consultarPorCriterio()
        {
            var deducciones = from em in entities.tipo_deduccion
                            where (em.id_deduccion.ToString().StartsWith(txtInput.Text) ||
                            em.nombre.StartsWith(txtInput.Text) ||
                            em.estado.ToString().StartsWith(txtInput.Text)
                            )
                            select em;
            dgDeducciones.DataSource = deducciones.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdDeducciones nuevaDeduccion = new FormEdDeducciones();
            nuevaDeduccion.ShowDialog();
           
        }

        private void FormGestDeducciones_Activated(object sender, EventArgs e)
        {
            consultarDeducciones();
        }

        private void dgDeducciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgDeducciones.SelectedRows[0];
                tipo_deduccion deduccion = new tipo_deduccion();
                deduccion.id_deduccion = Int32.Parse(fila.Cells[0].Value.ToString());
                deduccion.nombre = fila.Cells[1].Value.ToString();
                deduccion.estado = Convert.ToBoolean(fila.Cells[2].Value);
                FormEdDeducciones formEd = new FormEdDeducciones();
                formEd.deduccion = deduccion;
                formEd.ShowDialog();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar deduccion "+ex.Message);
            }
        }

        private void button1(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
