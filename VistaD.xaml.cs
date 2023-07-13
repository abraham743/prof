using MySql.Data.MySqlClient;
using PRecu.Repositorio;
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
    /// Lógica de interacción para VistaD.xaml
    /// </summary>
    public partial class VistaD : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = bdconsultori; Convert Zero Datetime=True;";
        DatosRepos Repo = DatosRepos.getInstance();
        public VistaD()
        {

            InitializeComponent();

                MySqlConnection inserccion = new MySqlConnection(datosServidor);
                try
                {
                    inserccion.Open();
                    MySqlCommand seleccionar = new MySqlCommand("select c.pkCita , p.NombreU, d.NombreD, d.EspecialidadD, c.FechaCita FROM cita as c INNER JOIN paciente as p on c.fkPaciente = p.pkPaciente INNER JOIN doctor as d on c.fkDoctor = d.pkDoctor WHERE d.pkDoctor = " + Repo.GetUsuario().Id + ";", inserccion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "LoadDataBinding");
                    datagrid_vistaD.DataContext = ds;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    inserccion.Close();
                }
            
        }

        private void BRegresar_Click(object sender, RoutedEventArgs e)
        {
            Loging loging = new Loging();
            this.Close();
            loging.Show();
        }
    }
}
