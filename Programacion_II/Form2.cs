using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II
{
    public partial class Form2 : Form
    {
        int cursor;

        Personas ListaPersonas { get; set; } = new Personas();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();


            per.Agregar(txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtDni.Text), fecha_nac.Value
                );

            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ingreso ningun nombre");

                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("No ingreso ningun apellido");
                return;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ingreso ningun Dni");
                return;
            }

            ListaPersonas.InsertaPersona(per);
            dataGridView1.DataSource = ListaPersonas.ListaDT;
            Limpiar();

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";




        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewAutoSizeModeEventArgs e)
        {
            cursor = dataGridView1.CurrentRow.Index;
        }

        public void fecha_nac_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha_nacimiento = fecha_nac.Value;

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(cursor);

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Persona per = new Persona();


            per.Agregar(txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtDni.Text), fecha_nac.Value
                );

            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ingreso ningun nombre");

                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("No ingreso ningun apellido");
                return;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("No ingreso ningun Dni");
                return;
            }

            ListaPersonas.InsertaPersona(per);
            dataGridView1.DataSource = ListaPersonas.ListaDT;
            Limpiar();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
