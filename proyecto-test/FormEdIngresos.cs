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
    public partial class FormEdIngresos : Form
    {
        public tipo_ingreso ingreso { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormEdIngresos()
        {
            InitializeComponent();
        }

        private void FormEdIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                if (ingreso != null)
                {
                    txtId.Text = ingreso.id_ingreso.ToString();
                    txtInputNombre.Text = ingreso.nombre.ToString();
                    cbEstado.SelectedText = ingreso.estado.ToString();
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


                if (ingreso == null)
                {
                    entities.tipo_ingreso.Add(
                    new tipo_ingreso
                    {
                        nombre = txtInputNombre.Text,
                        estado = Convert.ToBoolean(cbEstado.Text)
                    }
                    );
                    entities.SaveChanges();
                }
                else
                {
                    tipo_ingreso ingreso = entities.tipo_ingreso.Find(Int32.Parse(txtId.Text));

                    ingreso.nombre = txtInputNombre.Text;
                    ingreso.estado = Convert.ToBoolean(cbEstado.Text);
                    entities.SaveChanges();
                    entities.Entry(ingreso).State = System.Data.Entity.EntityState.Modified;


                    entities.Entry<tipo_ingreso>(ingreso).Reload(); //para forzar la busqueda
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
                tipo_ingreso ingreso = entities.tipo_ingreso.Find(Int32.Parse(txtId.Text));
                if (ingreso != null)
                {
                    entities.tipo_ingreso.Remove(ingreso);
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
