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
    /// Interaction logic for SalidaWindow.xaml
    /// </summary>
    public partial class SalidaWindow : Window
    {
        public SalidaWindow()
        {
            InitializeComponent();
            dpFechaHora.SelectedDate = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtNombreTransportista.Text) ||
                cmbTipoDocumento.SelectedIndex == -1 ||
                cmbTipoAuto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", 
                               "Campos Requeridos", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                return;
            }

            // Validar que los pesos sean números válidos
            if (!double.TryParse(txtPeso.Text, out double peso) ||
                !double.TryParse(txtPesoIngreso.Text, out double pesoIngreso) ||
                !double.TryParse(txtPesoSalida.Text, out double pesoSalida))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los pesos.", 
                               "Error de Validación", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Registro de salida guardado exitosamente.", 
                           "Éxito", 
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
            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtPeso.Clear();
            cmbTipoAuto.SelectedIndex = -1;
            txtNombreTransportista.Clear();
            dpFechaHora.SelectedDate = DateTime.Now;
            txtPesoIngreso.Clear();
            txtPesoSalida.Clear();
        }
    }
}