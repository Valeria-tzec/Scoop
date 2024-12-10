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
using Newtonsoft.Json;

namespace Scoop
{
    public partial class Productos : Form
    {
        private List<Productos> productos = new List<Productos>();
        string Nombre;

        public Productos()
        {
            InitializeComponent();
        }

        public void EliminarProducto()
        {
            int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;

            productos.RemoveAt(indiceSeleccionado);
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

            productos = JsonConvert.DeserializeObject<List<Productos>>(json);
        }

        public void GuardarProducto()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = JsonConvert.SerializeObject(productos, Formatting.Indented);
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
    }
}
