using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for CamionesWindow.xaml
    /// </summary>
    public partial class CamionesWindow : Window
    {
        public CamionesWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtPesoMaximo.Text) ||
                string.IsNullOrWhiteSpace(txtPesoVacio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", 
                               "Campos Requeridos", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                return;
            }

            // Validar que los pesos sean n�meros v�lidos
            if (!double.TryParse(txtPesoMaximo.Text, out double pesoMaximo) ||
                !double.TryParse(txtPesoVacio.Text, out double pesoVacio))
            {
                MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos para los pesos.", 
                               "Error de Validaci�n", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                return;
            }

            // Validar que el peso m�ximo sea mayor al peso vac�o
            if (pesoMaximo <= pesoVacio)
            {
                MessageBox.Show("El peso m�ximo debe ser mayor al peso vac�o.", 
                               "Error de Validaci�n", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Cami�n registrado exitosamente.", 
                           "�xito", 
                           MessageBoxButton.OK, 
                           MessageBoxImage.Information);
            
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LimpiarFormulario()
        {
            txtPesoMaximo.Clear();
            txtPlaca.Clear();
            txtPesoVacio.Clear();
            txtPesoMaximo.Focus();
        }
    }
}