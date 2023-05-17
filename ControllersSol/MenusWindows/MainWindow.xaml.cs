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

namespace MenusWindows
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

        void Bold_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.FontWeight = FontWeights.Bold;
        }
        
        void Bold_UnderChecked(object sender, RoutedEventArgs e)
        {
            textBox1.FontWeight = FontWeights.Normal;
        }

        void Italic_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.FontStyle = FontStyles.Italic;
        }
        
        void Italic_UnderChecked(object sender, RoutedEventArgs e)
        {
            textBox1.FontStyle = FontStyles.Normal;
        }

        void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.FontSize < 18)
            {
                textBox1.FontSize += 2;
            }
        }

        void DescreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.FontSize > 10)
            {
                textBox1.FontSize -= 2;
            }
        }        
    }
}
