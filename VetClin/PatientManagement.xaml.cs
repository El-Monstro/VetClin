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
    /// Логика взаимодействия для PatientManagement.xaml
    /// </summary>
    public partial class PatientManagement : Window
    {
        public Patient Patient { get; set; }

        private PatientManager patientManager;

        public PatientManagement()
        {
            InitializeComponent();

            patientManager = new PatientManager();
        }



        public void AddPatient(Patient newPatient)
        {

            patientsDataGrid.Items.Add(newPatient);
        }


        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            AddEditPatientWindow addEditPatientWindow = new AddEditPatientWindow(null);
            addEditPatientWindow.ShowDialog();

            if (addEditPatientWindow.DialogResult == true)
            {
                patientManager.AddPatient(addEditPatientWindow.Patient);
                patientsDataGrid.ItemsSource = null;
                patientsDataGrid.ItemsSource = patientManager.GetAllPatients();
            }
        }

        private void RemovePatient_Click(object sender, RoutedEventArgs e)
        {
            if (patientsDataGrid.SelectedItem != null)
            {
                Patient selectedPatient = (Patient)patientsDataGrid.SelectedItem;
                patientManager.RemovePatient(selectedPatient.Name);
                patientsDataGrid.ItemsSource = null;
                patientsDataGrid.ItemsSource = patientManager.GetAllPatients();
            }
            else
            {
                MessageBox.Show("Выберите пациента для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditPatient_Click(object sender, RoutedEventArgs e)
        {
            if (patientsDataGrid.SelectedItem != null)
            {
                Patient selectedPatient = (Patient)patientsDataGrid.SelectedItem;
                AddEditPatientWindow addEditPatientWindow = new AddEditPatientWindow(selectedPatient);
                addEditPatientWindow.ShowDialog();

                if (addEditPatientWindow.DialogResult == true)
                {
                    patientManager.EditPatient(selectedPatient.Name, addEditPatientWindow.Patient);
                    patientsDataGrid.ItemsSource = null;
                    patientsDataGrid.ItemsSource = patientManager.GetAllPatients();
                }
            }
            else
            {
                MessageBox.Show("Выберите пациента для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void patientsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
