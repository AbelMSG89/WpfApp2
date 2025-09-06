using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            // Validación de credenciales
            if (usuario == "admin" && password == "123456")
            {
                // Credenciales correctas - abrir menú
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else
            {
                // Credenciales incorrectas - mostrar mensaje de error
                MessageBox.Show("Usuario y/o contraseña incorrectos. Por favor, intente nuevamente.", 
                               "Error de Autenticación", 
                               MessageBoxButton.OK, 
                               MessageBoxImage.Warning);
                
                // Limpiar campos
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }
    }
}