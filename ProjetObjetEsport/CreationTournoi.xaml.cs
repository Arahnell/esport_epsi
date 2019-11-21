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
    /// Logique d'interaction pour CreationTournoi.xaml
    /// </summary>
    public partial class CreationTournoi : Window
    {
        public CreationTournoi()
        {
            InitializeComponent();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            AjoutEquipes sW = new AjoutEquipes();
            sW.Show();
            this.Close();
        }
    }
}
