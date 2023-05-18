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

namespace ControlesInformacionUsuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Editando...");
        }

        void cur_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cortando...");
        }

        private void btnOpenPopUp_Click(object sender, RoutedEventArgs e)
        {
            MyPopUp.IsOpen = true;
        }
    }
}
