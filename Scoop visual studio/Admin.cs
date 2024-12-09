using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas formVentas = new Ventas();
            formVentas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rellenar formRellenar = new Rellenar();
            formRellenar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados formEmpleados = new Empleados();
            formEmpleados.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crea una nueva instancia de Form1
            form1.Show(); // Muestra Form1
            this.Hide(); // Oculta el formulario actual 

            form1.FormClosed += (s, args) =>
            {
                this.Close();
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Products formProducts = new Products();
            formProducts.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Products formProducts = new Products();
            formProducts.Show();
        }
    }
}
