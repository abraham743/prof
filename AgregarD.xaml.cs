 using MySql.Data.MySqlClient;
using PRecu.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace PRecu
{
    /// <summary>
    /// Lógica de interacción para AgregarD.xaml
    /// </summary>
    public partial class AgregarD : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = rtaller; Convert Zero Datetime=True";

        Vehiculo datoVehiculo = new Vehiculo();

        public AgregarD()
        {
            InitializeComponent();
            CargarDatosVehiculo();
        }

        private void CargarDatosVehiculo()
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                conexion.Open();
                MySqlCommand seleccionar = new MySqlCommand("SELECT matricula, modelo, marca, CLIENTE_ID_cliente FROM VEHICULO", conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(seleccionar);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                datagrid_vehiculo.ItemsSource = dataTable.DefaultView;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        private void datagrid_vehiculo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagrid_vehiculo.SelectedItem != null)
            {
                DataRowView datos = datagrid_vehiculo.SelectedItem as DataRowView;
                txtMatricula.Text = datos["matricula"].ToString();
                txtModelo.Text = datos["modelo"].ToString();
                txtMarca.Text = datos["marca"].ToString();
                txtClienteID.Text = datos["CLIENTE_ID_cliente"].ToString();
            }
        }

        private void BAgregar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                int matricula = int.Parse(txtMatricula.Text);
                string modelo = txtModelo.Text;
                string marca = txtMarca.Text;
                int clienteID = int.Parse(txtClienteID.Text);

                conexion.Open();
                MySqlCommand insertar = new MySqlCommand($"INSERT INTO VEHICULO (matricula, modelo, marca, CLIENTE_ID_cliente) VALUES ({matricula}, '{modelo}', '{marca}', {clienteID})", conexion);
                insertar.ExecuteNonQuery();

                MessageBox.Show("Vehículo agregado correctamente.");

                CargarDatosVehiculo();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BEditar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                int matricula = int.Parse(txtMatricula.Text);
                string modelo = txtModelo.Text;
                string marca = txtMarca.Text;
                int clienteID = int.Parse(txtClienteID.Text);

                conexion.Open();
                MySqlCommand editar = new MySqlCommand($"UPDATE VEHICULO SET modelo = '{modelo}', marca = '{marca}', CLIENTE_ID_cliente = {clienteID} WHERE matricula = {matricula}", conexion);
                editar.ExecuteNonQuery();

                MessageBox.Show("Vehículo actualizado correctamente.");

                CargarDatosVehiculo();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BEliminar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                int matricula = int.Parse(txtMatricula.Text);

                conexion.Open();
                MySqlCommand eliminar = new MySqlCommand($"DELETE FROM VEHICULO WHERE matricula = {matricula}", conexion);
                eliminar.ExecuteNonQuery();

                MessageBox.Show("Vehículo eliminado correctamente.");

                CargarDatosVehiculo();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BRegresar_Click(object sender, RoutedEventArgs e)
        {
            Admin administrador = new Admin();
            this.Close();
            administrador.Show();
        }
    }
}
