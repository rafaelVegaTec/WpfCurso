﻿using System;
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

namespace CheckBoxWindows
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

        private void chbMyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtMyTextBlock1.Text = "The checkBox is checked";
        }

        private void chbMyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txtMyTextBlock1.Text = "The CheckBox is unchecked";
        }

        private void chbMyCheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            txtMyTextBlock1.Text = "The checkBox is in the indeterminate state.";
        }

        private void lsbMyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TxbMyTextBlock2.Text = $"You selected {(lsbMyListBox.SelectedItem as ListBoxItem).Content.ToString()}.";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            if (radioButton is not null)
            {
                txbMyTextBlock3.Text = $"Selecionaste: {radioButton.Content.ToString()}.";
            }
        }
    }
}
