using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ConductoresWindow.xaml
    /// </summary>
    public partial class ConductoresWindow : Window
    {
        private ObservableCollection<Conductor> conductores;

        public ConductoresWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Datos de ejemplo
            conductores = new ObservableCollection<Conductor>
            {
                new Conductor { Id = 1, Nombre = "Juan", Apellido = "Pérez", DNI = "12345678", Licencia = "A2B", Telefono = "987654321" },
                new Conductor { Id = 2, Nombre = "María", Apellido = "García", DNI = "87654321", Licencia = "A3C", Telefono = "987654322" },
                new Conductor { Id = 3, Nombre = "Carlos", Apellido = "López", DNI = "11223344", Licencia = "A2B", Telefono = "987654323" },
                new Conductor { Id = 4, Nombre = "Ana", Apellido = "Martínez", DNI = "44332211", Licencia = "A3C", Telefono = "987654324" },
                new Conductor { Id = 5, Nombre = "Luis", Apellido = "Rodríguez", DNI = "55667788", Licencia = "A2B", Telefono = "987654325" }
            };

            dgConductores.ItemsSource = conductores;
            ActualizarContador();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string termino = txtBuscar.Text.ToLower();
            
            if (string.IsNullOrWhiteSpace(termino))
            {
                dgConductores.ItemsSource = conductores;
            }
            else
            {
                var resultados = conductores.Where(c => 
                    c.Nombre.ToLower().Contains(termino) ||
                    c.Apellido.ToLower().Contains(termino) ||
                    c.DNI.Contains(termino) ||
                    c.Licencia.ToLower().Contains(termino)).ToList();
                
                dgConductores.ItemsSource = resultados;
            }
            
            ActualizarContador();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de Nuevo Conductor en desarrollo", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dgConductores.SelectedItem is Conductor conductor)
            {
                MessageBox.Show($"Editando conductor: {conductor.Nombre} {conductor.Apellido}", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgConductores.SelectedItem is Conductor conductor)
            {
                MessageBoxResult result = MessageBox.Show($"¿Está seguro de eliminar al conductor {conductor.Nombre} {conductor.Apellido}?", 
                                                         "Confirmar Eliminación", 
                                                         MessageBoxButton.YesNo, 
                                                         MessageBoxImage.Question);
                
                if (result == MessageBoxResult.Yes)
                {
                    conductores.Remove(conductor);
                    ActualizarContador();
                    MessageBox.Show("Conductor eliminado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ActualizarContador()
        {
            int total = dgConductores.ItemsSource?.Cast<object>().Count() ?? 0;
            lblTotal.Text = $"Total: {total} registros";
        }
    }

    // Clase modelo para Conductor
    public class Conductor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
    }
}