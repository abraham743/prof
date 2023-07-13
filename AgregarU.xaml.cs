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
    public partial class AgregarU : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = rtaller;Convert Zero Datetime=True;";

        private Mantenimiento datoMantenimiento;

        public AgregarU()
        {
            InitializeComponent();
            datoMantenimiento = new Mantenimiento();

            MySqlConnection insercion = new MySqlConnection(datosServidor);
            try
            {
                insercion.Open();
                MySqlCommand seleccionar = new MySqlCommand("SELECT * FROM MANTENIMIENTO;", insercion);
                MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                datagrid_mantenimiento.DataContext = ds;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                insercion.Close();
            }
        }

        private void cargardatosMantenimiento()
        {
            datoMantenimiento.NoMantenimiento = int.Parse(txtNoMantenimiento.Text);
            datoMantenimiento.descripcion = txtDescripcion.Text.Trim();
            datoMantenimiento.costo = decimal.Parse(txtCosto.Text);
            datoMantenimiento.CLIENTE_ID_cliente = int.Parse(txtIDCliente.Text);
        }

        private void datagrid_mantenimiento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView datos = datagrid_mantenimiento.SelectedItem as DataRowView;
            if (datagrid_mantenimiento.SelectedItem != null)
            {
                txtNoMantenimiento.Text = datos[0].ToString();
                txtDescripcion.Text = datos[2].ToString();
                txtCosto.Text = datos[3].ToString();
                txtIDCliente.Text = datos[4].ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void BAgregar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection insertar = new MySqlConnection(datosServidor);
            try
            {
                insertar.Open();
                cargardatosMantenimiento();
                MySqlCommand inset = new MySqlCommand("INSERT INTO MANTENIMIENTO(NoMantenimiento, descripcion, costo, CLIENTE_ID_cliente) VALUES (" + datoMantenimiento.NoMantenimiento + ",'"  + datoMantenimiento.descripcion + "'," + datoMantenimiento.costo + "," + datoMantenimiento.CLIENTE_ID_cliente + ");", insertar);
                inset.ExecuteNonQuery();

                MySqlCommand seleccionar = new MySqlCommand("SELECT * FROM MANTENIMIENTO;", insertar);
                MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                datagrid_mantenimiento.DataContext = ds;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                insertar.Close();
            }
        }

        private void BEditar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection editar = new MySqlConnection(datosServidor);
            try
            {
                editar.Open();
                cargardatosMantenimiento();

                DataRowView datos = datagrid_mantenimiento.SelectedItem as DataRowView;
                if (datagrid_mantenimiento.SelectedItem != null)
                {
                    MySqlCommand edit = new MySqlCommand("UPDATE MANTENIMIENTO SET descripcion = '" + datoMantenimiento.descripcion + "', costo = " + datoMantenimiento.costo + ", CLIENTE_ID_cliente = " + datoMantenimiento.CLIENTE_ID_cliente + " WHERE NoMantenimiento = " + Convert.ToInt32(txtNoMantenimiento.Text) + ";", editar);
                    edit.ExecuteNonQuery();

                    MySqlCommand seleccionar = new MySqlCommand("SELECT * FROM MANTENIMIENTO;", editar);
                    MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "LoadDataBinding");
                    datagrid_mantenimiento.DataContext = ds;
                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                editar.Close();
            }
        }

        private void BEliminar_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection eliminar = new MySqlConnection(datosServidor);
            try
            {
                DataRowView datos = datagrid_mantenimiento.SelectedItem as DataRowView;
                if (datagrid_mantenimiento.SelectedItem != null)
                {
                    eliminar.Open();
                    MySqlCommand del = new MySqlCommand("DELETE FROM MANTENIMIENTO WHERE NoMantenimiento = " + Convert.ToInt32(txtNoMantenimiento.Text) + ";", eliminar);
                    del.ExecuteNonQuery();

                    MySqlCommand seleccionar = new MySqlCommand("SELECT * FROM MANTENIMIENTO;", eliminar);
                    MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "LoadDataBinding");
                    datagrid_mantenimiento.DataContext = ds;
                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                eliminar.Close();
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
