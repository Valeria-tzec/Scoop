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
    public partial class Products : Form
    {
        private List<Products> products = new List<Products>();
        string Nombre;

        public Products()
        {
            InitializeComponent();
        }


        public void EliminarProducto()
        {
            int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;

            products.RemoveAt(indiceSeleccionado);
            GuardarProducto();
            DescargarListaProductos();

        }

        private void ConfiguarData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void DescargarListaProductos()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = System.IO.File.ReadAllText(fileJson);

            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

            products = JsonConvert.DeserializeObject<List<Products>>(json);
        }

        public void GuardarProducto()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Admin admin = new Admin(); // Crea una nueva instancia de Admin
            admin.Show(); // Muestra Admin
        }
        private void Products_Load(object sender, EventArgs e)
        {
            ConfiguarData();
            DescargarListaProductos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Admin admin = new Admin(); // Crea una nueva instancia de Admin
            admin.Show(); // Muestra Admin
        }
    }
}
