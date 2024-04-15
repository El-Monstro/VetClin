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
    /// Логика взаимодействия для AddEditPatientWindow.xaml
    /// </summary>
    public partial class AddEditPatientWindow : Window
    {
        public event EventHandler<PatientEventArgs> PatientAdded;

        public Patient Patient { get; set; }


        public AddEditPatientWindow()
        {
            InitializeComponent();
            Patient = new Patient("", "", "", "", ""); 
            DataContext = Patient; 
        }

 
        public AddEditPatientWindow(Patient existingPatient)
        {
            InitializeComponent();
            Patient = existingPatient; 
            DataContext = Patient; 
        }


        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Patient = new Patient(NameTextBox.Text, SpeciesTextBox.Text, BreedTextBox.Text, OwnerNameTextBox.Text, OwnerContactTextBox.Text);
            OnPatientAdded(Patient);
            DialogResult = true;
            Close();
        }



        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; 
            Close(); 
        }

        protected virtual void OnPatientAdded(Patient patient)
        {
            PatientAdded?.Invoke(this, new PatientEventArgs(patient));
        }
    }
}
