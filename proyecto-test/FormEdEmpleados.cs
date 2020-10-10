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
    public partial class FormEdEmpleados : Form
    {
        public empleado empleado { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormEdEmpleados()
        {
            InitializeComponent();

            //cargamos los datos a los comboBox
            cbDepartamento.DataSource = entities.departamento.ToList();
            cbDepartamento.ValueMember = "id_departamento";
            cbDepartamento.DisplayMember = "nombre";

            cbPuesto.DataSource = entities.puesto.ToList();
            cbPuesto.ValueMember = "id_puesto";
            cbPuesto.DisplayMember = "nombre";

            cbNomina.DataSource = entities.nomina.ToList();
            cbNomina.ValueMember = "id_nomina";
            cbNomina.DisplayMember = "tipo";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEdEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                if (empleado != null)
                {
                    textId.Text = empleado.id_empleado.ToString();
                    txtInputCedula.Text = empleado.cedula.ToString();
                    txtInputNom.Text = empleado.nombre.ToString();
                    cbDepartamento.SelectedValue = empleado.departamento;
                    cbPuesto.SelectedValue = empleado.puesto;
                    cbNomina.SelectedValue = empleado.nomina;
                    txtInputSalario.Text = empleado.salario.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleado == null)
                {
                    entities.empleado.Add(
                        new empleado
                        {
                            cedula = txtInputCedula.Text,
                            nombre = txtInputNom.Text,
                            departamento = Int32.Parse(cbDepartamento.SelectedValue.ToString()),
                            puesto = Int32.Parse(cbPuesto.SelectedValue.ToString()),
                            nomina = Int32.Parse(cbNomina.SelectedValue.ToString()),
                            salario = decimal.Parse(txtInputSalario.Text)
                        }
                        );
                    entities.SaveChanges();
                }
                else
                {
                    empleado empleado = entities.empleado.Find(Int32.Parse(textId.Text));

                    empleado.cedula = txtInputCedula.Text;
                    empleado.nombre = txtInputNom.Text;
                    empleado.departamento = Int32.Parse(cbDepartamento.SelectedValue.ToString());
                    empleado.puesto = Int32.Parse(cbPuesto.SelectedValue.ToString());
                    empleado.nomina = Int32.Parse(cbNomina.SelectedValue.ToString());
                    empleado.salario = decimal.Parse(txtInputSalario.Text);

                    entities.SaveChanges();
                    entities.Entry(empleado).State = System.Data.Entity.EntityState.Modified;


                    entities.Entry<empleado>(empleado).Reload(); //para forzar la busqueda
                }

                MessageBox.Show("Guardado de manera exitosa");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar de manera exitosa " + ex.Message);
            }
}

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                empleado empleado = entities.empleado.Find(Int32.Parse(textId.Text));
                if (empleado != null)
                {
                    entities.empleado.Remove(empleado);
                    entities.SaveChanges();
                    MessageBox.Show("Eliminado de manera correcta");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar " + ex.Message);
            }
        }
    }
}
