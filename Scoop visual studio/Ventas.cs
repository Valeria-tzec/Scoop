using Newtonsoft.Json;
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
    public partial class Ventas : Form
    {

        private List<Sale> sale = new List<Sale>();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ConfigurarData();
            DescargarListaVentas();
        }

        private void ConfigurarData()
        {
            dataGridView1.AutoGenerateColumns = true; 
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void DescargarListaVentas()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Sale.json";
            string json = System.IO.File.ReadAllText(fileJson); 
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Admin admin = new Admin(); // Crea una nueva instancia de Admin
            admin.Show(); // Muestra Admin
        }
    }

    public class Sale
    {
        public string Producto;
        public string Pago;
    }
}
