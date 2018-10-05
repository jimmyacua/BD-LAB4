using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Lab4_BD
{
 
    public partial class AgregarEstudiante : MetroForm
    {
        public Estudiante estudiante;

        public AgregarEstudiante()
        {
            InitializeComponent();
            estudiante = new Estudiante();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            ListaEstudiante lista = new ListaEstudiante();
            lista.Show();
            Hide();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            EliminarEstudiante eliminar = new EliminarEstudiante();
            eliminar.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
