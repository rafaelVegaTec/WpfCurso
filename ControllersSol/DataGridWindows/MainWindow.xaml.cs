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

namespace DataGridWindows
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerGrid.DataContext = GetCustomerData();
            CustomerGrid2.DataContext = GetCustomerData();
            trvMyTreeView.ItemsSource = GetCustomerData();
            lsvCustomers.ItemsSource = GetCustomerData();
        }

        private List<Customer> GetCustomerData()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Name = "Sergio",
                    Adress = "Mi Direccion",
                    Age = 40,
                    IsMember = true
                },
                new Customer()
                {
                    Name = "Sergio",
                    Adress = "Mi Direccion",
                    Age = 40,
                    IsMember = true
                },
                new Customer()
                {
                    Name = "Rafael",
                    Adress = "Mi Direccion",
                    Age = 28,
                    IsMember = true,
                    Partners = new List<Customer>
                    {
                        new Customer() { Name = "Migel Angel" },
                        new Customer() { Name = "Rafael" },
                        new Customer() { Name = "Donatelo" },
                        new Customer() { Name = "Leonardo" }
                    }
                },
                new Customer()
                {
                    Name = "Marta",
                    Adress = "Mi Direccion",
                    Age = 30,
                    IsMember = true
                },
            };
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public bool IsMember { get; set; }
        public List<Customer> Partners { get; set; }

        public Customer()
        {
            Name = string.Empty;
            Adress = string.Empty;
            Partners = new List<Customer>();
        }
    }
}
