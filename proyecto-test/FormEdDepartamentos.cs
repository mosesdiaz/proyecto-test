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
    public partial class FormEdDepartamentos : Form
    {
        public departamento departamento { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        

        public FormEdDepartamentos()
        {
            InitializeComponent();

            //cargamos los datos al combobox
            cbResponsable.DataSource = entities.empleado.ToList();
            cbResponsable.ValueMember = "id_empleado";
            cbResponsable.DisplayMember = "nombre";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FormEdDepartamentos_Load(object sender, EventArgs e)
        {
            try
            {
                if (departamento != null)
                {
                    textId.Text = departamento.id_departamento.ToString();
                    txtInputNombre.Text = departamento.nombre.ToString();
                    txtInputUbicacion.Text = departamento.ubicacion_fisica.ToString();
                    cbResponsable.SelectedValue = departamento.responsable_area;
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
                if (departamento == null)
                {
                    entities.departamento.Add(
                        new departamento
                        {
                            nombre = txtInputNombre.Text,
                            ubicacion_fisica = txtInputUbicacion.Text,
                            responsable_area = Int32.Parse(cbResponsable.SelectedValue.ToString())
                        }
                        );
                    entities.SaveChanges();
                }
                else
                {
                    departamento departamento = entities.departamento.Find(Int32.Parse(textId.Text));

                    departamento.nombre = txtInputNombre.Text;
                    departamento.ubicacion_fisica = txtInputUbicacion.Text;
                    departamento.responsable_area = Int32.Parse(cbResponsable.SelectedValue.ToString());

                    entities.SaveChanges();
                    entities.Entry(departamento).State = System.Data.Entity.EntityState.Modified;


                    entities.Entry<departamento>(departamento).Reload(); //para forzar la busqueda
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
            try
            {
                departamento departamento = entities.departamento.Find(Int32.Parse(textId.Text));
                if (departamento != null)
                {
                    entities.departamento.Remove(departamento);
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
