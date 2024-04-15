using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClin
{
    public class PatientManager
    {
        private List<Patient> patients;

        public PatientManager()
        {
            patients = new List<Patient>();
        }


        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }


        public void RemovePatient(string name)
        {
            patients.RemoveAll(p => p.Name == name);
        }


        public void EditPatient(string name, Patient updatedPatient)
        {
            var patientToUpdate = patients.FirstOrDefault(p => p.Name == name);
            if (patientToUpdate != null)
            {
                patientToUpdate.Name = updatedPatient.Name;
                patientToUpdate.Species = updatedPatient.Species;
                patientToUpdate.Breed = updatedPatient.Breed;
                patientToUpdate.OwnerName = updatedPatient.OwnerName;
                patientToUpdate.OwnerContact = updatedPatient.OwnerContact;
            }
        }

        public List<Patient> GetAllPatients()
        {
            return patients;
        }
    }
}
