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
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
        }

        private void gestionDeDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestDeducciones frm = new FormGestDeducciones();
            frm.Show();
        }

        private void gestionDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestIngresos frm = new FormGestIngresos();
            frm.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDePuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestPuestos frm = new FormGestPuestos();
            frm.Show();
        }

        private void gestionDeTiposDeNominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestNomina frm = new FormGestNomina();
            frm.Show();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestEmpleados frm = new FormGestEmpleados();
            frm.Show();
        }
    }
}
