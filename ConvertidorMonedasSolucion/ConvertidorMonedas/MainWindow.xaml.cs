using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace ConvertidorMonedas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarCombos();
            BuscarJsonAsync(cboTiposDeMonedas.SelectedItem.ToString().ToLower());
        }

        private void btnConvertir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResultado.Text = multiplicar(double.Parse(txtMoneda.Text), double.Parse(txtCantidad.Text)).ToString();
            }
            catch (Exception)
            {

            }    
        }

        private async void BuscarJsonAsync(string moneda)
        {
            var client = new HttpClient();
            Uri uri = new Uri(string.Format("https://mindicador.cl/api/{0}", moneda));
            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var monedaBuscada = JsonConvert.DeserializeObject<Monedas>(content);

                if (monedaBuscada != null)
                {
                    txtMoneda.Text = monedaBuscada.serie[0].valor.ToString();
                }
                else
                {
                    txtResultado.Text = "Error al encontrar moneda!!";
                }
            }
            else
            {
                txtResultado.Text = "Bad request!!";
            }
        }

        public double multiplicar(double precio, double cantidad)
        {
            double total = 0;
            try
            {
                total = precio * cantidad;
            }
            catch (Exception)
            {

            }

            return total;
        }

        public void CargarCombos()
        {
            try
            {
                cboTiposDeMonedas.ItemsSource = Enum.GetValues(typeof(TiposMonedas));
                cboTiposDeMonedas.SelectedValue = TiposMonedas.UF;
            }
            catch (Exception)
            {

            }
        }

        private void cboTiposDeMonedas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                BuscarJsonAsync(cboTiposDeMonedas.SelectedItem.ToString().ToLower());
            }
            catch (Exception)
            {
                
            }
        }
    }
}
