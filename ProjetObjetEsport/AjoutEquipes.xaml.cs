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

namespace ProjetObjetEsport
{
    /// <summary>
    /// Logique d'interaction pour AjoutEquipes.xaml
    /// </summary>
    public partial class AjoutEquipes : Window
    {
        public AjoutEquipes()
        {
            InitializeComponent();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MainWindow sW = new MainWindow();
            sW.Show();
            this.Close();
        }
    }
}
