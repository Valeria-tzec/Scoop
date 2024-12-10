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
    public partial class Empleados : Form
    {
        private List<User> users = new List<User>();
        string Role;
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            ConfiguarData();
            DescargarListaUsuarios();

        }

        private void Manager_CheckedChanged(object sender, EventArgs e)
        {
            Role = "Manager";
        }

        private void Employee_CheckedChanged(object sender, EventArgs e)
        {
            Role = "Employee";
        }
        
        private void ConfiguarData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void DescargarListaUsuarios()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Nombre.json";
            string json = System.IO.File.ReadAllText(fileJson);

            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

            users = JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textB_empleados.Text;
            string pass = textB_Pass.Text;
            string role = Role;

            AgregarUsuarios(nombre, pass, role);
        }

        public void AgregarUsuarios(string username, string password, string rol)
        {
            User newUsuario = new User();
            newUsuario.Nombre = username;
            newUsuario.Clave = password;
            newUsuario.Role = rol;

            users.Add(newUsuario);

            string fileJson = @"C:\Users\valer\source\repos\Scoop\Nombre.json";
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);

            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

        }

        public void EliminarUsuario()
        {
            int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;

            users.RemoveAt(indiceSeleccionado);
            GuardarUsuario();
            DescargarListaUsuarios();
               
        }

        public void GuardarUsuario()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Nombre.json";
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Admin admin = new Admin(); // Crea una nueva instancia de Admin
            admin.Show(); // Muestra Admin
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
