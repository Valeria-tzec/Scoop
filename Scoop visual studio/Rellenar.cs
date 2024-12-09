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

    public partial class Rellenar : Form
    {

        List<Productos> productos;

        public Rellenar()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ModificarProductos();
            ActualizarJson();
            this.Hide();
        }

        public void DescargarJson()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = System.IO.File.ReadAllText(fileJson);
            productos = JsonConvert.DeserializeObject<List<Productos>>(json);
        }

        public void ActualizarJson()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = JsonConvert.SerializeObject(productos, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);

        }

        private void Rellenar_Load(object sender, EventArgs e)
        {
           
        }

        public void LlenarPrecios()
        {
            txtB_pLimon.Text = productos.Find(Item => Item.Producto == "Limon").Precio.ToString();
            txtB_pChocolate.Text = productos.Find(Item => Item.Producto == "Chocolate").Precio.ToString();
            txtB_pVainilla.Text = productos.Find(Item => Item.Producto == "Vainilla").Precio.ToString();
            txtB_pFresa.Text = productos.Find(Item => Item.Producto == "Fresa").Precio.ToString();
            txtB_pTaro.Text = productos.Find(Item => Item.Producto == "Taro").Precio.ToString();
            txtB_pDulceLeche.Text = productos.Find(Item => Item.Producto == "Dulce de leche").Precio.ToString();
            txtB_pPistache.Text = productos.Find(Item => Item.Producto == "Pistache").Precio.ToString();
            txtB_pVinoTinto.Text = productos.Find(Item => Item.Producto == "Vino tinto").Precio.ToString();
            txtB_pCaramelo.Text = productos.Find(Item => Item.Producto == "Caramelo").Precio.ToString();
            txtB_pCoco.Text = productos.Find(Item => Item.Producto == "Coco").Precio.ToString();
            txtB_pLotus.Text = productos.Find(Item => Item.Producto == "Lotus").Precio.ToString();
            txtB_pCookiesCream.Text = productos.Find(Item => Item.Producto == "CookiesCream").Precio.ToString();

        }

        public void LlenarCantidad()
        {
            txtB_cLimon.Text = productos.Find(Item => Item.Producto == "Limon").Cant.ToString();
            txtB_cChocolate.Text = productos.Find(Item => Item.Producto == "Chocolate").Cant.ToString();
            txtB_cVainilla.Text = productos.Find(Item => Item.Producto == "Vainilla").Cant.ToString();
            txtB_cFresa.Text = productos.Find(Item => Item.Producto == "Fresa").Cant.ToString();
            txtB_cTaro.Text = productos.Find(Item => Item.Producto == "Taro").Cant.ToString();
            txtB_cDulceLeche.Text = productos.Find(Item => Item.Producto == "Dulce de leche").Cant.ToString();
            txtB_cPistache.Text = productos.Find(Item => Item.Producto == "Pistache").Cant.ToString();
            txtB_cVinoTinto.Text = productos.Find(Item => Item.Producto == "Vino tinto").Cant.ToString();
            txtB_cCaramelo.Text = productos.Find(Item => Item.Producto == "Caramelo").Cant.ToString();
            txtB_cCoco.Text = productos.Find(Item => Item.Producto == "Coco").Cant.ToString();
            txtB_cLotus.Text = productos.Find(Item => Item.Producto == "Lotus").Cant.ToString();
            txtB_cCookiesCream.Text = productos.Find(Item => Item.Producto == "CookiesCream").Cant.ToString();

        }
        public void ModificarProductos()
        {
            productos.Find(Item => Item.Producto == "Limon").Precio = float.Parse(txtB_pLimon.Text);
            productos.Find(Item => Item.Producto == "Chocolate").Precio = float.Parse(txtB_pChocolate.Text);
            productos.Find(Item => Item.Producto == "Vainilla").Precio = float.Parse(txtB_pVainilla.Text);
            productos.Find(Item => Item.Producto == "Fresa").Precio = float.Parse(txtB_pFresa.Text);
            productos.Find(Item => Item.Producto == "Taro").Precio = float.Parse(txtB_pTaro.Text);
            productos.Find(Item => Item.Producto == "Dulce de leche").Precio = float.Parse(txtB_pDulceLeche.Text);
            productos.Find(Item => Item.Producto == "Pistache").Precio = float.Parse(txtB_pPistache.Text);
            productos.Find(Item => Item.Producto == "Vino tinto").Precio = float.Parse(txtB_pVinoTinto.Text);
            productos.Find(Item => Item.Producto == "Caramelo").Precio = float.Parse(txtB_pCaramelo.Text);
            productos.Find(Item => Item.Producto == "Coco").Precio = float.Parse(txtB_pCoco.Text);
            productos.Find(Item => Item.Producto == "Lotus").Precio = float.Parse(txtB_pLotus.Text);
            productos.Find(Item => Item.Producto == "CookiesCream").Precio = float.Parse(txtB_pCookiesCream.Text);

            productos.Find(Item => Item.Producto == "Limon").Cant = int.Parse(txtB_cLimon.Text);
            productos.Find(Item => Item.Producto == "Chocolate").Cant = int.Parse(txtB_cChocolate.Text);
            productos.Find(Item => Item.Producto == "Vainilla").Cant = int.Parse(txtB_cVainilla.Text);
            productos.Find(Item => Item.Producto == "Fresa").Cant = int.Parse(txtB_cFresa.Text);
            productos.Find(Item => Item.Producto == "Taro").Cant = int.Parse(txtB_cTaro.Text);
            productos.Find(Item => Item.Producto == "Dulce de leche").Cant = int.Parse(txtB_cDulceLeche.Text);
            productos.Find(Item => Item.Producto == "Pistache").Cant = int.Parse(txtB_cPistache.Text);
            productos.Find(Item => Item.Producto == "Vino tinto").Cant = int.Parse(txtB_cVinoTinto.Text);
            productos.Find(Item => Item.Producto == "Caramelo").Cant = int.Parse(txtB_cCaramelo.Text);
            productos.Find(Item => Item.Producto == "Coco").Cant = int.Parse(txtB_cCoco.Text);
            productos.Find(Item => Item.Producto == "Lotus").Cant = int.Parse(txtB_cLotus.Text);
            productos.Find(Item => Item.Producto == "CookiesCream").Cant = int.Parse(txtB_cCookiesCream.Text);


        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void Rellenar_Load_1(object sender, EventArgs e)
        {
            DescargarJson();
            LlenarPrecios();
            LlenarCantidad();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual 
            Admin admin = new Admin(); // Crea una nueva instancia de Admin
            admin.Show(); // Muestra Admin
        }
    }
}
