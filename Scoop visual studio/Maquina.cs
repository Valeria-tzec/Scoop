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
    public partial class Maquina : Form
    {


        private tarjeta formtarjeta = null;
        private efectivo formefectivo = null;

        private Productos[] productos;
        public float Dinero_Maquina = 0;
        private string Digito_Maquina;

        //Ventas
        private List<Sale> Sale = new List<Sale>();

        public Maquina()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Lab_digVinoTinto_Click(object sender, EventArgs e)
        {

        }

        private void Lab_digCookiesCream_Click(object sender, EventArgs e)
        {

        }

        private void Maquina_Load(object sender, EventArgs e)
        {
            Actualizarproductos();
        }

        private void Actualizarproductos()
        {
            productos = new Productos[12];

            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";

            string json = System.IO.File.ReadAllText(fileJson);

            productos = JsonConvert.DeserializeObject<Productos[]>(json);

            Lab_digLimon.Text = productos[0].Code;
            Lab_PrecioLimon.Text = "Precio: $" + productos[0].Precio.ToString();
            Lab_CantLimon.Text = "Cantidad:" + productos[0].Cant;

            Lab_digChoc.Text = productos[1].Code;
            Lab_PrecioChoc.Text = "Precio: $" + productos[1].Precio.ToString();
            Lab_CantChoc.Text = "Cantidad: " + productos[1].Cant;

            Lab_digVainilla.Text = productos[2].Code;
            Lab_PrecioVainilla.Text = "Precio: $" + productos[2].Precio.ToString();
            Lab_CantVainilla.Text = "Cantidad: " + productos[2].Cant;

            Lab_digFresa.Text = productos[3].Code;
            Lab_PrecioFresa.Text = "Precio: $" + productos[3].Precio.ToString();
            Lab_CantFresa.Text = "Cantidad: " + productos[3].Cant;

            Lab_digTaro.Text = productos[4].Code;
            Lab_PrecioTaro.Text = "Precio: $" + productos[4].Precio.ToString();
            Lab_CantTaro.Text = "Cantidad: " + productos[4].Cant;

            Lab_digDulceLeche.Text = productos[5].Code;
            Lab_PrecioDulceLeche.Text = "Precio: $" + productos[5].Precio.ToString();
            Lab_CantDulceLeche.Text = "Cantidad: " + productos[5].Cant;

            Lab_digPistache.Text = productos[6].Code;
            Lab_PrecioPistache.Text = "Precio: $" + productos[6].Precio.ToString();
            Lab_CantPistache.Text = "Cantidad: " + productos[6].Cant;

            Lab_digVinoTinto.Text = productos[7].Code;
            Lab_PrecioVinoTinto.Text = "Precio: $" + productos[7].Precio.ToString();
            Lab_CantVinoTinto.Text = "Cantidad: " + productos[7].Cant;

            Lab_digCaramelo.Text = productos[8].Code;
            Lab_PrecioCaramelo.Text = "Precio: $" + productos[8].Precio.ToString();
            Lab_CantCaramelo.Text = "Cantidad:  " + productos[8].Cant;

            Lab_digCoco.Text = productos[9].Code;
            Lab_PrecioCoco.Text = "Precio: $" + productos[9].Precio.ToString();
            Lab_CantCoco.Text = "Cantidad: " + productos[9].Cant;

            Lab_digGalleta.Text = productos[10].Code;
            Lab_PrecioGalleta.Text = "Precio: $" + productos[10].Precio.ToString();
            Lab_CantGalleta.Text = "Cantidad: " + productos[10].Cant;

            Lab_digCookiesCream.Text = productos[11].Code;
            Lab_PrecioCookiesCream.Text = "Precio: $" + productos[11].Precio.ToString();
            Lab_CantCookiesCream.Text = "Cantidad: " + productos[11].Cant;


        }

        public void DatosPagos(float total, bool digitosPanel, string metodopago)
        {
            Lab_DineroIngresado.Text = total.ToString();
            panel_digitos.Enabled = digitosPanel;
            Lab_TipoPago.Text = metodopago;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formefectivo = new efectivo(this);
            formefectivo.Show();
        }

       // private void buttom7_Click(object sender, EventArgs e)
            //formtarjeta = new tarjeta(this);
            //formtarjeta.Show();

        private void button1_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "1";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "2";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "3";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "4";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "A";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "B";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "C";
            Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Productos producto in productos)
            {
                if (producto.Code == Lab_SelecProducto.Text && float.Parse(Lab_DineroIngresado.Text) >= producto.Precio)
                {
                    producto.Cant--;
                    ActualizarsProductosJson();
                    Actualizarproductos();

                    if (Lab_TipoPago.Text != "Efectivo")
                    {
                        string fileJson = @"C:\Users\valer\source\repos\Scoop\cards.json";

                        string cuenta = Lab_TipoPago.Text;

                        string json = System.IO.File.ReadAllText(fileJson);
                        card[] cards = JsonConvert.DeserializeObject<card[]>(json);

                        foreach (card card in cards)
                        {
                            if (card.Account == int.Parse(cuenta))
                            {
                                card.Amount -= producto.Precio;

                                string jsonActualizar = JsonConvert.SerializeObject(cards, Formatting.Indented);
                                System.IO.File.WriteAllText(fileJson, jsonActualizar);

                                DescargarListaVentas();
                                ActualizarListaVentas(producto.Producto, producto.Precio);
                                LimpiarMaquina();
                            }
                        }
                    }
                }
            }
        }

        public void LimpiarMaquina()
        {
            Lab_TipoPago.Text = "";
            Lab_SelecProducto.Text = "";
            Digito_Maquina = "";
            Dinero_Maquina = 0;
            Lab_DineroIngresado.Text = "";
        }

        public void ActualizarListaVentas(string producto, float pago)
        {
            Sale newSale = new Sale();
            newSale.Producto = producto;
            newSale.Pago = pago.ToString();

            Sale.Add(newSale);

            string fileJson = @"C:\Users\valer\source\repos\Scoop\Sale.json";
            string json = JsonConvert.SerializeObject(Sale, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);

        }

        private void DescargarListaVentas()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Sale.json";
            string json = System.IO.File.ReadAllText(fileJson);
            Sale= JsonConvert.DeserializeObject<List<Sale>>(json);
        }

        public void ActualizarsProductosJson()
        {
            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";
            string json = JsonConvert.SerializeObject(productos, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formtarjeta = new tarjeta(this);
            formtarjeta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab_PrecioLimon_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1(); // Crea una nueva instancia de Form1
            form1.Show(); // Muestra Form1
            this.Hide(); // Oculta el formulario actual

            form1.FormClosed += (s, args) =>
            {
                this.Close();
            };

        }
    }

    public partial class Productos
    {
        public string Code;
        public string Producto;
        public float Precio;
        public int Cant;
    }
}
