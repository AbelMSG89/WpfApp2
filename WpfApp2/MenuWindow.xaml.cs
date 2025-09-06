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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            OperacionesWindow operacionesWindow = new OperacionesWindow();
            operacionesWindow.Show();
        }

        private void btnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            MantenimientosWindow mantenimientosWindow = new MantenimientosWindow();
            mantenimientosWindow.Show();
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            ReportesWindow reportesWindow = new ReportesWindow();
            reportesWindow.Show();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", 
                                                     "Cerrar Sesión", 
                                                     MessageBoxButton.YesNo, 
                                                     MessageBoxImage.Question);
            
            if (result == MessageBoxResult.Yes)
            {
                MainWindow loginWindow = new MainWindow();
                loginWindow.Show();
                this.Close();
            }
        }
    }
}