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

namespace ButtomWindows
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

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Red;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Red;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Purple;
            btn2.Background = Brushes.GreenYellow;
        }

        void Increase(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtValue.Text);
            txtValue.Text = ((num + 1).ToString());
        }

        void Decrease(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtValue.Text);
            txtValue.Text = ((num - 1).ToString());
        }
    }
}
