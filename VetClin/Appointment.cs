using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClin
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string AnimalType { get; set; }
        public string Diagnosis { get; set; }
        public decimal ServiceCost { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Service Service { get; set; } // Ссылка на объект услуги

        public Appointment(string patientName, string animalType, string diagnosis, decimal serviceCost, DateTime appointmentDate, Service service)
        {
            PatientName = patientName;
            AnimalType = animalType;
            Diagnosis = diagnosis;
            ServiceCost = serviceCost;
            AppointmentDate = appointmentDate;
            Service = service;
        }
    }
}