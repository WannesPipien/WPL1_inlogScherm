﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inlogScherm
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
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Equals("admin") && PasswordTextBox.Text.Equals("admin"))
            {
                InfoTextBlock.Text = "U wordt ingelogd.";
            }
        }
        private void LogOffButton_Click(object sender, RoutedEventArgs e)
        {
            InfoTextBlock.Text = "";

            //gg ez get good
            //4 big guys and they grab on my tighs
        }
    }
}