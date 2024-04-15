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

namespace VetClin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PatientManagement patientManagementWindow;
        private List<Patient> acceptedPatients;
        private List<Appointment> appointments;

        public MainWindow()
        {
            InitializeComponent();
            patientManagementWindow = new PatientManagement();
            acceptedPatients = new List<Patient>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();

            loginWindow.Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            PatientManagement patientManagementWindow = new PatientManagement();
            patientManagementWindow.ShowDialog();

            if (patientManagementWindow.DialogResult == true)
            {
                Patient newPatient = patientManagementWindow.Patient;

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Service> services = new List<Service>
            {
                    new Service("Проверка здоровья", 200, "Общая проверка здоровья животного", "Обследование"),
                    new Service("Прививка от бешенства", 700, "Профилактическая прививка от бешенства", "Прививки"),
                    new Service("Лечение зубов", 800, "Очистка зубов и удаление зубного камня", "Стоматология"),
                    new Service("Стрижка и уход за шерстью", 4000, "Стрижка шерсти и подравнивание когтей", "Уход"),
                    new Service("Ультразвуковое исследование", 10000, "Ультразвуковая диагностика внутренних органов", "Диагностика")

            };

            ServicesListWindow servicesListWindow = new ServicesListWindow(services);
            servicesListWindow.Show();
            this.Close();
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DailyReportWindow dailyReportWindow = new DailyReportWindow(appointments);
            dailyReportWindow.Show();
            this.Hide();
        }
    }
}
