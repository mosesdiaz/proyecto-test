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
    public partial class FormGestEmpleados : Form
    {
        private empleado empleado { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();



        //se crea esta clase para almacenar los datos que se buscan de los empleados (nombre departamento, nombre puesto, etc)
        private class empleadosSql
        {
            public int id_empleado { get; set; }
            public string cedula { get; set; }
            public string nombre { get; set; }
            public string departamento { get; set; }
            public string puesto { get; set; }
            public string nomina { get; set; }
            public Nullable<decimal> salario { get; set; }
            
        }

        public FormGestEmpleados()
        {
            InitializeComponent();
        }

        private void FormGestEmpleados_Load(object sender, EventArgs e)
        {
            consultarEmpleados();
        }

        private IQueryable<empleadosSql> sqlQueryEmpleados()
        {
            var consulta = from e in entities.empleado
                           join d in entities.departamento on e.departamento equals d.id_departamento
                           join p in entities.puesto on e.puesto equals p.id_puesto
                           join n in entities.nomina on e.nomina equals n.id_nomina
                           select new empleadosSql
                           {
                               id_empleado = e.id_empleado,
                               cedula = e.cedula,
                               nombre = e.nombre,
                               departamento = d.nombre,
                               puesto = p.nombre,
                               salario = e.salario,
                               nomina = n.tipo
                           };
            return consulta;
        }

        private void consultarEmpleados()
        {
            dgEmpleados.DataSource = sqlQueryEmpleados().ToList();
          
        }

        private void consultarPorCriterio()
        {


            var empleados = from em in sqlQueryEmpleados()
                          where (em.id_empleado.ToString().StartsWith(txtInput.Text) ||
                          em.cedula.StartsWith(txtInput.Text) ||
                          em.nombre.StartsWith(txtInput.Text) ||
                          em.departamento.StartsWith(txtInput.Text) ||
                          em.puesto.StartsWith(txtInput.Text) ||
                          em.salario.ToString().StartsWith(txtInput.Text) ||
                          em.nomina.StartsWith(txtInput.Text)
                          )
                          select em;
            dgEmpleados.DataSource = empleados.ToList();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormEdEmpleados nuevoEmpleado = new FormEdEmpleados();
            nuevoEmpleado.Show();
        }

        private void FormGestEmpleados_Activated(object sender, EventArgs e)
        {
            consultarEmpleados();
        }

        private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            try
            {
                DataGridViewRow fila = this.dgEmpleados.SelectedRows[0];
                empleado empleado = new empleado();
                empleado.id_empleado = Int32.Parse(fila.Cells[0].Value.ToString());
                empleado.cedula = fila.Cells[1].Value.ToString();
                empleado.nombre = fila.Cells[2].Value.ToString();

                //obtiene el id del departamento del empleado
                string nombreDepartamento = fila.Cells[3].Value.ToString();
                var idDepartamento = from em in entities.departamento where em.nombre == nombreDepartamento select em.id_departamento;
                empleado.departamento = idDepartamento.First();

                //obtiene el id del puesto del empleado
                string nombrePuesto = fila.Cells[4].Value.ToString();
                var idPuesto = from em in entities.puesto where em.nombre == nombrePuesto select em.id_puesto;
                empleado.puesto = idPuesto.First();

                //obtiene el id de la nomina del empleado
                string nombreNomina = fila.Cells[5].Value.ToString();
                var idNomina = from em in entities.nomina where em.tipo == nombreNomina select em.id_nomina;
                empleado.nomina = idNomina.First();
                
                empleado.salario = decimal.Parse(fila.Cells[6].Value.ToString());


                FormEdEmpleados formEd = new FormEdEmpleados();
                formEd.empleado = empleado;
                formEd.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);
            }
            
        }
    }
}
