using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClin
{
    public class Patient
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string OwnerName { get; set; }
        public string OwnerContact { get; set; }


        public Patient(string name, string species, string breed, string ownerName, string ownerContact)
        {
            Name = name;
            Species = species;
            Breed = breed;
            OwnerName = ownerName;
            OwnerContact = ownerContact;
        }
    }
}
