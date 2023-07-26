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
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using PRecu.Repositorio;

namespace PRecu
{
    /// <summary>
    /// Lógica de interacción para Loging.xaml
    /// </summary>
    public partial class Loging : Window
    {
        static string datosServidor = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = rtaller; Convert Zero Datetime=True";
        public Loging()
        {
            InitializeComponent();
        }

        //inicio de sesion con base de datos utilizando nombre y telefono 
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = "";
            string telefono = "";

            int idD = 0, idP = 0;

            MySqlConnection conexion = new MySqlConnection(datosServidor);
            conexion.Open();

            string consultaD = "SELECT * FROM CLIENTE  Where telefono = '" + PasswordB.Password + "' AND nombre = '" + txtUsuario.Text + "'; ";


            MySqlCommand instruccionD = new MySqlCommand(consultaD, conexion);
            MySqlDataReader myreaderD = instruccionD.ExecuteReader();

            if (myreaderD.HasRows)
            {
                while (myreaderD.Read())
                {
                    nombre = myreaderD.GetString(1);
                    telefono = myreaderD.GetString(2);

                    Admin ad = new Admin();
                    ad.Show();
                }
            }

            else
            {
                MessageBox.Show("Rellena todos los campos");
            }
        }


    }
}
