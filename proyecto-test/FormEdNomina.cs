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
    public partial class FormEdNomina : Form
    {
        public nomina nomina { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormEdNomina()
        {
            InitializeComponent();
        }

        private void FormEdNomina_Load(object sender, EventArgs e)
        {
            try
            {
                if (nomina != null)
                {
                    txtId.Text = nomina.id_nomina.ToString();
                    txtInputNombre.Text = nomina.tipo.ToString();
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
                if (nomina == null)
                {
                    entities.nomina.Add(
                    new nomina
                    {
                        tipo = txtInputNombre.Text
                    }
                    );
                    entities.SaveChanges();
                }
                else
                {
                    nomina nomina = entities.nomina.Find(Int32.Parse(txtId.Text));

                    nomina.tipo = txtInputNombre.Text;
                    entities.SaveChanges();
                    entities.Entry(nomina).State = System.Data.Entity.EntityState.Modified;


                    entities.Entry<nomina>(nomina).Reload(); //para forzar la busqueda
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
                nomina nomina = entities.nomina.Find(Int32.Parse(txtId.Text));
                if (nomina != null)
                {
                    entities.nomina.Remove(nomina);
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
