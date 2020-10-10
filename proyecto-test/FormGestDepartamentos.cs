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
    public partial class FormGestDepartamentos : Form
    {
        private departamento departamento { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();


        //se crea esta clase para almacenar los datos que se buscan de los departamentos
        private class departamentosSql
        {
            public int id_departamento { get; set; }
            public string nombre { get; set; }
            public string ubicacion_fisica { get; set; }
            public string responsable_area { get; set; }
        }

        public FormGestDepartamentos()
        {
            InitializeComponent();
        }

        private void FormGestDepartamentos_Load(object sender, EventArgs e)
        {
            consultarDepartamentos();
        }

        private IQueryable<departamentosSql> sqlQueryDepartamentos()
        {
            var consulta = from d in entities.departamento
                           join e in entities.empleado on d.responsable_area equals e.id_empleado
                           select new departamentosSql
                           {
                               id_departamento = d.id_departamento,
                               nombre = d.nombre,
                               ubicacion_fisica = d.ubicacion_fisica,
                               responsable_area = e.nombre

                           };
            return consulta;
        }

        private void consultarDepartamentos()
        {
            dgDepartamentos.DataSource = sqlQueryDepartamentos().ToList();
        }

        private void consultarPorCriterio()
        {
            var departamentos = from em in sqlQueryDepartamentos()
                            where (em.id_departamento.ToString().StartsWith(txtInput.Text) ||
                            em.nombre.StartsWith(txtInput.Text) ||
                            em.ubicacion_fisica.StartsWith(txtInput.Text) ||
                            em.responsable_area.StartsWith(txtInput.Text) 
                            )
                            select em;
            dgDepartamentos.DataSource = departamentos.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdDepartamentos nuevoDepartamento = new FormEdDepartamentos();
            nuevoDepartamento.Show();
        }

        private void FormGestDepartamentos_Activated(object sender, EventArgs e)
        {
            consultarDepartamentos();
        }

        private void dgDepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow fila = this.dgDepartamentos.SelectedRows[0];
                departamento departamento = new departamento();

                departamento.id_departamento = Int32.Parse(fila.Cells[0].Value.ToString());
                departamento.nombre = fila.Cells[1].Value.ToString();
                departamento.ubicacion_fisica = fila.Cells[2].Value.ToString();


                //obtiene el id del responsable
                string nombreResponsable = fila.Cells[3].Value.ToString();
                var idResponsable = from em in entities.empleado where em.nombre == nombreResponsable select em.id_empleado;
                departamento.responsable_area = idResponsable.First();


                FormEdDepartamentos formEd = new FormEdDepartamentos();
                formEd.departamento = departamento;
                formEd.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);
            }
        }
    }
}
