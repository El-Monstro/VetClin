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
    /// Логика взаимодействия для DailyReportWindow.xaml
    /// </summary>
    public partial class DailyReportWindow : Window
    {
        private List<Appointment> appointments;


        public DailyReportWindow(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
            GenerateReport();
        }

        private void GenerateReport()
        {

            DateTime currentDate = DateTime.Today;

            var appointmentsToday = appointments.Where(appointment => appointment.AppointmentDate.Date == currentDate);

            int totalAppointments = appointmentsToday.Count();

            decimal totalServicesCost = appointmentsToday.Sum(appointment => appointment.Service.Price);

            TotalAppointmentsTextBlock.Text = $"Общее количество приемов за день: {totalAppointments}";
            TotalServicesCostTextBlock.Text = $"Суммарная стоимость услуг за день: {totalServicesCost} руб.";
        }
    }
}
