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
    public partial class FormEdDeducciones : Form
    {
        public tipo_deduccion deduccion { get; set; }
        private SistemaNominaEntities entities = new SistemaNominaEntities();

        public FormEdDeducciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (deduccion == null)
                {
                    entities.tipo_deduccion.Add(
                    new tipo_deduccion
                        {
                            nombre = txtInputNombre.Text,
                            estado = Convert.ToBoolean(cbEstado.Text)
                        }
                    );
                    entities.SaveChanges();
                }
                else
                {
                    tipo_deduccion deduccion = entities.tipo_deduccion.Find(Int32.Parse(txtId.Text));

                    deduccion.nombre = txtInputNombre.Text;
                    deduccion.estado = Convert.ToBoolean(cbEstado.Text);
                    entities.SaveChanges();
                    entities.Entry(deduccion).State = System.Data.Entity.EntityState.Modified;

                    
                    entities.Entry<tipo_deduccion>(deduccion).Reload(); //para forzar la busqueda
                }

                MessageBox.Show("Guardado de manera exitosa");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar de manera exitosa "+ex.Message);
            }  
            
        }

        private void FormEdDeducciones_Load(object sender, EventArgs e)
        {
            try
            {
                if (deduccion != null)
                {
                    txtId.Text = deduccion.id_deduccion.ToString();
                    txtInputNombre.Text = deduccion.nombre.ToString();
                    cbEstado.SelectedText = deduccion.estado.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tipo_deduccion deduccion = entities.tipo_deduccion.Find(Int32.Parse(txtId.Text));
                if (deduccion != null)
                {
                    entities.tipo_deduccion.Remove(deduccion);
                    entities.SaveChanges();
                    MessageBox.Show("Eliminado de manera correcta");
                    this.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar "+ex.Message);
            }
        }
    }
}
