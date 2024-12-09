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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool AutenticacionManager;
        public bool AutenticacionEmployee;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Nombre.json";

            string nombre = TxtB_Nombre.Text;
            string clave = TxtB_Clave.Text;

            if (nombre == "" || clave == "")
            {
                MessageBox.Show("Por favor rellena los campos", "Inicio de sesión inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string json = System.IO.File.ReadAllText(fileJson);
                User[] users = JsonConvert.DeserializeObject<User[]>(json);

                foreach (User user in users)
                {

                    if (user.Nombre == nombre && user.Clave == clave)
                    {
                        MessageBox.Show("Bienvenido " + user.Nombre, " Success! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (user.Role == "Manager")
                        {
                            //AutenticacionManager = true;
                            OpenAdmin();
                        }
                        else if (user.Role == "Employee")
                        {
                            //AutenticacionEmployee = true;
                            OpenMaquina();
                        }
                        //this.Close();
                        return;
                    }
                }
                MessageBox.Show("Usuario o contraseña incorrecta ", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenAdmin()
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();

            adminForm.FormClosed += (s, args) => this.Show();
            //lamda (abre el admin)
        }

        public void OpenMaquina()
        {
            Maquina maquinaForm = new Maquina();
            maquinaForm.Show();
            this.Hide();

            maquinaForm.FormClosed += (s, args) => this.Show();
        }

    }
    public class User
    {

        public string Nombre;
        public string Clave;
        public string Role;

    }
}

