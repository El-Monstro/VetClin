using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClin
{
    public class PatientManager
    {
        private List<Patient> patients;

        private string filePath = "patients.json";

        public PatientManager()
        {
            patients = LoadPatients();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            SavePatients();
        }

        public void RemovePatient(string name)
        {
            patients.RemoveAll(p => p.Name == name);
            SavePatients();
        }

        public void EditPatient(string name, Patient updatedPatient)
        {
            var patientToUpdate = patients.Find(p => p.Name == name);
            if (patientToUpdate != null)
            {
                patientToUpdate.Name = updatedPatient.Name;
                patientToUpdate.Species = updatedPatient.Species;
                patientToUpdate.Breed = updatedPatient.Breed;
                patientToUpdate.OwnerName = updatedPatient.OwnerName;
                patientToUpdate.OwnerContact = updatedPatient.OwnerContact;
                SavePatients();
            }
        }

        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        private List<Patient> LoadPatients()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Patient>>(json);
            }
            else
            {
                return new List<Patient>();
            }
        }

        private void SavePatients()
        {
            string json = JsonConvert.SerializeObject(patients);
            File.WriteAllText(filePath, json);
        }
    }
}

