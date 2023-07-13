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
    /// Lógica de interacción para AgregarC.xaml
    /// </summary>
    public partial class AgregarC : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = rtaller; Convert Zero Datetime=True";

       CLIENTE datoCita = new CLIENTE();

        public AgregarC()
        {
            InitializeComponent();
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                conexion.Open();
                MySqlCommand seleccionar = new MySqlCommand("SELECT ID_cliente, nombre, telefono, ciudad, direccion FROM CLIENTE", conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(seleccionar);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                datagrid_cliente.ItemsSource = dataTable.DefaultView;
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

        private void datagrid_cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagrid_cliente.SelectedItem != null)
            {
                DataRowView datos = datagrid_cliente.SelectedItem as DataRowView;
                txtIDCliente.Text = datos["ID_cliente"].ToString();
                txtNombre.Text = datos["nombre"].ToString();
                txtTelefono.Text = datos["telefono"].ToString();
                txtCiudad.Text = datos["ciudad"].ToString();
                txtDireccion.Text = datos["direccion"].ToString();
            }
        }

        private void BAgregar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(datosServidor);
            try
            {
                int idCliente = int.Parse(txtIDCliente.Text);
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string ciudad = txtCiudad.Text;
                string direccion = txtDireccion.Text;

                conexion.Open();
                MySqlCommand insertar = new MySqlCommand($"INSERT INTO CLIENTE (ID_cliente, nombre, telefono, ciudad, direccion) VALUES ({idCliente}, '{nombre}', '{telefono}', '{ciudad}', '{direccion}')", conexion);
                insertar.ExecuteNonQuery();

                MessageBox.Show("Cliente agregado correctamente.");

                CargarDatosCliente();
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
                int idCliente = int.Parse(txtIDCliente.Text);
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string ciudad = txtCiudad.Text;
                string direccion = txtDireccion.Text;

                conexion.Open();
                MySqlCommand editar = new MySqlCommand($"UPDATE CLIENTE SET nombre = '{nombre}', telefono = '{telefono}', ciudad = '{ciudad}', direccion = '{direccion}' WHERE ID_cliente = {idCliente}", conexion);
                editar.ExecuteNonQuery();

                MessageBox.Show("Cliente actualizado correctamente.");

                CargarDatosCliente();
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
                int idCliente = int.Parse(txtIDCliente.Text);

                conexion.Open();
                MySqlCommand eliminar = new MySqlCommand($"DELETE FROM CLIENTE WHERE ID_cliente = {idCliente}", conexion);
                eliminar.ExecuteNonQuery();

                MessageBox.Show("Cliente eliminado correctamente.");

                CargarDatosCliente();
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

