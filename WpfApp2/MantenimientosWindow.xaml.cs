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
    /// Interaction logic for MantenimientosWindow.xaml
    /// </summary>
    public partial class MantenimientosWindow : Window
    {
        public MantenimientosWindow()
        {
            InitializeComponent();
        }

        private void btnConductores_Click(object sender, RoutedEventArgs e)
        {
            ConductoresWindow conductoresWindow = new ConductoresWindow();
            conductoresWindow.Show();
        }

        private void btnTransportistas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Transportistas en desarrollo", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnCamiones_Click(object sender, RoutedEventArgs e)
        {
            CamionesWindow camionesWindow = new CamionesWindow();
            camionesWindow.Show();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Productos en desarrollo", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}