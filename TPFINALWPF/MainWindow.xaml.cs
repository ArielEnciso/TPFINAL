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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TPFINALWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HospitalEntitiesWPF datos;
        public MainWindow()
        {
            InitializeComponent();
            datos = new HospitalEntitiesWPF();
        }

        private void LimpiarCampos()
        {
            txtNumAsegurado.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void CargarDatosGrilla()
        {
            try
            {
                dgPacientes.ItemsSource = datos.Pacientes.ToList();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDatos()
        {
            
        }

        private void ListadoPacientes_Loaded(object sender, RoutedEventArgs e)
        {
            CargarDatosGrilla();
            ActualizarDatos();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Pacientes pacientes = new Pacientes();

            pacientes.AseguradoNº = Convert.ToInt32(txtNumAsegurado.Text);
            pacientes.Nombre = txtNombre.Text;
            pacientes.Apellido = txtApellido.Text;
            pacientes.Ciudad = txtCiudad.Text;
            pacientes.Domicilio = txtDomicilio.Text;
            pacientes.Telefono = txtTelefono.Text;

            pacientes.Sexo = rdbHombre.IsChecked;

            pacientes.Nº_HistorialClinico = txtHistorialClinicoNum.Text;


            datos.Pacientes.Add(pacientes);
            datos.SaveChanges();

            LimpiarCampos();
            CargarDatosGrilla();
            ActualizarDatos();

        }

    }
}
