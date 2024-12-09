using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Scoop
{
    public partial class efectivo : Form
    {

        private float total = 0;
        private Maquina formmaquina;


        public efectivo()
        {
            InitializeComponent();
        }

        public efectivo(Maquina mainForm)
        {
            InitializeComponent();
            formmaquina = mainForm; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total += 1;
            lab_total.Text = total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            total += 2;
            lab_total.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total += 5;
            lab_total.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total += 10;
            lab_total.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total += 20;
            lab_total.Text = total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            total += 50;
            lab_total.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            total += 100;
            lab_total.Text = total.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (total>=0){

                formmaquina.DatosPagos(total, true, "Efectivo");
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            total = 0;
            lab_total.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Maquina maquina = new Maquina(); // Crea una nueva instancia de Maquina
            maquina.Show(); // Muestra Maquina
        }
    }
}
