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

namespace VetClin
{
    /// <summary>
    /// Логика взаимодействия для ServicesListWindow.xaml
    /// </summary>
    public partial class ServicesListWindow : Window
    {
        private List<Service> services;

        public ServicesListWindow(List<Service> services)
        {
            InitializeComponent();
            this.services = services;
            DataContext = this.services;        
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
