using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private List<ProductosCaja> listCaja = new List<ProductosCaja>();

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
            ConfigurarData();
        }

        private void ConfigurarData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        public void AgregarArticulo(string digito, float precio)
        {
            ProductosCaja caja = new ProductosCaja();
            caja.Producto = digito;
            caja.Pago = precio.ToString();

            listCaja.Add(caja);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listCaja;

        }

        public void EliminarArticulo()
        {
            int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;
            listCaja.RemoveAt(indiceSeleccionado);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listCaja;

        }

        public void ActualizarListaVentasCaja()
        {
            var nuevasVentas = listCaja.Select(caja => new Sale
            {
                Producto = caja.Producto,
                Pago = caja.Pago,
            }).ToList();

            //combinar las ventas existentes con las nuevas
            Sale.AddRange(nuevasVentas);

            string fileJson = @"C:\Users\valer\source\repos\Scoop\Sale.json";
            string json = JsonConvert.SerializeObject(Sale, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);

            listCaja.Clear();
        }

        private void Actualizarproductos()
        {
            productos = new Productos[12];

            string fileJson = @"C:\Users\valer\source\repos\Scoop\Productos.json";

            string json = System.IO.File.ReadAllText(fileJson);

            productos = JsonConvert.DeserializeObject<Productos[]>(json);

            Lab_digLimon.Text = productos[0].Code;
            Lab_PrecioLimon.Text = productos[0].Precio.ToString();

            Lab_digChoc.Text = productos[1].Code;
            Lab_PrecioChoc.Text = productos[1].Precio.ToString();

            Lab_digVainilla.Text = productos[2].Code;
            Lab_PrecioVainilla.Text = productos[2].Precio.ToString();

            Lab_digFresa.Text = productos[3].Code;
            Lab_PrecioFresa.Text = productos[3].Precio.ToString();

            Lab_digTaro.Text = productos[4].Code;
            Lab_PrecioTaro.Text = productos[4].Precio.ToString();

            Lab_digDulceLeche.Text = productos[5].Code;
            Lab_PrecioDulceLeche.Text = productos[5].Precio.ToString();

            Lab_digPistache.Text = productos[6].Code;
            Lab_PrecioPistache.Text = productos[6].Precio.ToString();

            Lab_digVinoTinto.Text = productos[7].Code;
            Lab_PrecioVinoTinto.Text = productos[7].Precio.ToString();

            Lab_digCaramel.Text = productos[8].Code;
            Lab_PrecioCaramelo.Text = productos[8].Precio.ToString();

            Lab_digCoco.Text = productos[9].Code;
            Lab_PrecioCoco.Text = productos[9].Precio.ToString();

            Lab_digGalleta.Text = productos[10].Code;
            Lab_PrecioGalleta.Text = productos[10].Precio.ToString();

            Lab_digCookiesCream.Text = productos[11].Code;
            Lab_PrecioCookiesCream.Text = productos[11].Precio.ToString();


        }

        public void DatosPagos(float total, bool digitosPanel, string metodopago)
        {
            Lab_DineroIngresado.Text = total.ToString();
            //panel_digitos.Enabled = digitosPanel;
           // Lab_TipoPago.Text = metodopago;

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
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "2";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "3";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "4";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "A";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "B";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "C";
            //Lab_SelecProducto.Text = Digito_Maquina;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Productos producto in productos)
            {
                if (producto.Code == Lab_SelecProducto.Text && float.Parse(Lab_DineroIngresado.Text) >= producto.Precio)
                {
                    producto.Cant--;
                    ActualizarProductosJson();
                    Actualizarproductos();

                    if (Lab_TipoPago.Text != "Tarjeta")
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
                                MessageBox.Show("Pagado");
                                ///
                                DescargarListaVentas();
                                ActualizarListaVentasCaja();

                                //ActualizarListaVentas(producto.Producto, producto.Precio);
                                ///
                                LimpiarMaquina();

                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pagado");
                        DescargarListaVentas();
                        ActualizarListaVentasCaja();
                        break;
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
            Sale = JsonConvert.DeserializeObject<List<Sale>>(json);
        }

        public void ActualizarProductosJson()
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

        private void Lab_CantLimon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Limon";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digLimon.Text;
            float precioProducto = float.Parse(Lab_PrecioLimon.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            EliminarArticulo();
        }

        private void button_ElegirChoc_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Chocolate";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digChoc.Text;
            float precioProducto = float.Parse(Lab_PrecioChoc.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirVainilla_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Vainilla";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digVainilla.Text;
            float PrecioProducto = float.Parse(Lab_PrecioVainilla.Text);

            AgregarArticulo(digitoProducto, PrecioProducto);
        }

        private void button_ElegirFresa_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Fresa";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digFresa.Text;
            float precioProducto = float.Parse(Lab_PrecioFresa.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirTaro_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Taro";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digTaro.Text;
            float precioProducto = float.Parse(Lab_PrecioTaro.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }



        private void button_ElegirDulceLeche_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Dulce de Leche";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digDulceLeche.Text;
            float precioProducto = float.Parse(Lab_PrecioDulceLeche.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirPistache_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Pistache";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digPistache.Text;
            float precioProducto = float.Parse(Lab_PrecioPistache.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirVinoTinto_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Vino Tinto";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digVinoTinto.Text;
            float precioProducto = float.Parse(Lab_PrecioVinoTinto.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirCaramelo_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Caramelo";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digCaramel.Text;
            float precioProducto = float.Parse(Lab_PrecioCaramelo.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirCoco_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el texto no esté vacío
                if (string.IsNullOrWhiteSpace(Lab_PrecioCoco.Text) || string.IsNullOrWhiteSpace(Lab_digCoco.Text))
                {
                    MessageBox.Show("Por favor, asegúrate de ingresar tanto el código como el precio del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el precio sea un número válido
                if (!float.TryParse(Lab_PrecioCoco.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float precioProducto))
                {
                    MessageBox.Show("El precio del producto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string codigoProducto = Lab_digCoco.Text;

                // Llamar al método para agregar el artículo
                AgregarArticulo(codigoProducto, precioProducto);

                // Confirmar que el producto fue agregado
                MessageBox.Show("El producto fue agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error inesperado
                MessageBox.Show($"Ocurrió un error al procesar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ElegirGalleta_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Galleta";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digGalleta.Text;
            float precioProducto = float.Parse(Lab_PrecioGalleta.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void button_ElegirCookiesCream_Click(object sender, EventArgs e)
        {
            Digito_Maquina = Digito_Maquina + "Cookies and Cream";
            Lab_SelecProducto.Text = Digito_Maquina;
            string digitoProducto = Lab_digCookiesCream.Text;
            float precioProducto = float.Parse(Lab_PrecioCookiesCream.Text);

            AgregarArticulo(digitoProducto, precioProducto);
        }

        private void lab_TotalPagar_Click(object sender, EventArgs e)
        {

        }

        private void Lab_TipoPago_Click(object sender, EventArgs e)
        {

        }

        private void Lab_DineroIngresado_Click(object sender, EventArgs e)
        {

        }
    }

    public partial class Productos
    {
        public string Code;
        public string Producto;
        public float Precio;
        public int Cant;
    }

    public class ProductosCaja
    {
        //private object dataGridView1;

        public System.Windows.Forms.DataGridView dataGridView1; //arregla el error de la línea 522 [  foreach (DataGridViewRow fila in dataGridView1.Rows)]


        public System.Windows.Forms.Label lab_TotalPagar; // arregla el error de la línea 535 [ lab_TotalPagar.Text = $"Total a Pagar: {total:C2}"; // Formato de moneda]
        public string Producto { get; set; }

        public string Pago { get; set; }


        private void CalcularTotal()
        {
            float total = 0;
            // Iterar por cada fila del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Asegurarse de que la fila no sea nueva o esté vacía
                if (fila.IsNewRow) continue;

                // Verificar que las celdas requeridas no sean nulas
                if (fila.Cells["Precio"]?.Value != null &&
                    float.TryParse(fila.Cells["Precio"].Value.ToString(), out float precio))
                {
                    total += precio; // Sumar el precio al total
                }
            }
            // Mostrar el total en el Label
                lab_TotalPagar.Text = $"Total a Pagar: {total:C2}"; // Formato de moneda

            CalcularTotal();
        }

    }
    
}
