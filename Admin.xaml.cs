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

namespace PRecu
{
    /// <summary>
    /// Lógica de interacción para Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BAccederP_Click(object sender, RoutedEventArgs e)
        {
            AgregarU agreagarp = new AgregarU();
            this.Close();
            agreagarp.Show();
        }

        private void BAccederD_Click(object sender, RoutedEventArgs e)
        {
            AgregarD agregard = new AgregarD();
            this.Close();
            agregard.Show();
        }

        private void BAccederC_Click(object sender, RoutedEventArgs e)
        {
            AgregarC agregarc = new AgregarC();
            this.Close();
            agregarc.Show();
        }

        private void BSalir_Click(object sender, RoutedEventArgs e)
        {
            Loging loging = new Loging();
            this.Close();
            loging.Show();
        }
    }
}
