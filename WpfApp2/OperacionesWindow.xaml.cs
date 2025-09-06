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
    /// Interaction logic for OperacionesWindow.xaml
    /// </summary>
    public partial class OperacionesWindow : Window
    {
        public OperacionesWindow()
        {
            InitializeComponent();
        }

        private void btnIngresos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Ingresos en desarrollo", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {
            SalidaWindow salidaWindow = new SalidaWindow();
            salidaWindow.Show();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}