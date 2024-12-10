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
    public partial class tarjeta : Form
    {

        private Maquina formmaquina;
        private string cardSelect;



        public tarjeta()
        {
            InitializeComponent();
        }

        public tarjeta(Maquina mainForm)
        {
            InitializeComponent();
            formmaquina = mainForm;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nip_Click(object sender, EventArgs e)
        {

        }

        private void credito_CheckedChanged(object sender, EventArgs e)
        {
            cardSelect = "Credit";
        }

        private void pagarbutton_Click(object sender, EventArgs e)
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\cards.json";

            string cuenta = numcuentabox.Text;
            string nip = nipbox.Text;

            if (cuenta==""|| nip=="")
            {
                MessageBox.Show("Rellenar los campos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string json = System.IO.File.ReadAllText(fileJson);

                card[] cards = JsonConvert.DeserializeObject<card[]>(json);

                foreach (card card in cards)
                {
                    if (card.Account == int.Parse(cuenta) && card.NIP == int.Parse(nip) && card.Type == cardSelect)
                    {
                        formmaquina.DatosPagos(card.Amount, true, card.Account.ToString());
                        MessageBox.Show("Succes!", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                }

                MessageBox.Show("Datos incorrectos", "Cuenta no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void debito_CheckedChanged(object sender, EventArgs e)
        {
            cardSelect = "Debit";
        }

        private void cuenta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Maquina maquina = new Maquina(); // Crea una nueva instancia de Maquina
            maquina.Show(); // Muestra Maquina
        }
    }


    public class card
    {
        public string Type;
        public int Account;
        public float Amount;
        public int NIP;
    }



}
