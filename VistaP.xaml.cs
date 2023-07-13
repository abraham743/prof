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
    /// Lógica de interacción para VistaP.xaml
    /// </summary>
    public partial class VistaP : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = bdconsultori; Convert Zero Datetime=True;";

        DatosRepos Repo = DatosRepos.getInstance();
        public VistaP()
        {
            InitializeComponent();

            MySqlConnection inserccion = new MySqlConnection(datosServidor);
            try
            {
                inserccion.Open();
                MySqlCommand seleccionar = new MySqlCommand("select t1.pkPaciente , t1.NombreU, t3.NombreD, t3.EspecialidadD, t2.FechaCita  FROM paciente as t1 INNER JOIN cita as t2 on t1.pkPaciente = t2.fkPaciente INNER JOIN doctor as t3 on t2.fkDoctor = t3.pkDoctor WHERE t1.pkPaciente = " + Repo.GetUsuario().Id + ";", inserccion);
                MySqlDataAdapter adp = new MySqlDataAdapter(seleccionar);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                datagrid_vistaP.DataContext = ds;

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
