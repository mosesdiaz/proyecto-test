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
    public partial class FormEdPuestos : Form
    {
        public puesto puesto { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormEdPuestos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormEdPuestos_Load(object sender, EventArgs e)
        {
            try
            {
                if (puesto != null)
                {
                    txtId.Text = puesto.id_puesto.ToString();
                    txtInputNombre.Text = puesto.nombre.ToString();
                    txtInputRiesgo.Text = puesto.nive_riesgo_salario.ToString();
                    txtInputSalarioMinimo.Text = puesto.nivel_minimo_salario.ToString();
                    txtInputSalarioMaximo.Text = puesto.nivel_maximo_salario.ToString();
                    
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
                if (puesto == null)
                {
                    entities.puesto.Add(
                    new puesto
                    {
                        nombre = txtInputNombre.Text,
                        nive_riesgo_salario = txtInputRiesgo.Text,
                        nivel_minimo_salario = decimal.Parse(txtInputSalarioMinimo.Text),
                        nivel_maximo_salario = decimal.Parse(txtInputSalarioMaximo.Text)

                    }
                    );
                    entities.SaveChanges();
                }
                else
                {
                    puesto puesto = entities.puesto.Find(Int32.Parse(txtId.Text));

                    puesto.nombre = txtInputNombre.Text;
                    puesto.nive_riesgo_salario = txtInputRiesgo.Text;
                    puesto.nivel_minimo_salario = decimal.Parse(txtInputSalarioMinimo.Text);
                    puesto.nivel_maximo_salario = decimal.Parse(txtInputSalarioMaximo.Text);
                    entities.SaveChanges();
                    entities.Entry(puesto).State = System.Data.Entity.EntityState.Modified;


                    entities.Entry<puesto>(puesto).Reload(); //para forzar la busqueda
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
                puesto puesto = entities.puesto.Find(Int32.Parse(txtId.Text));
                if (puesto != null)
                {
                    entities.puesto.Remove(puesto);
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

        private void FormEdPuestos_Activated(object sender, EventArgs e)
        {

        }
    }
}
