using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClin
{
    public class PatientEventArgs : EventArgs
    {
        public Patient Patient { get; }

        public PatientEventArgs(Patient patient)
        {
            Patient = patient;
        }
    }
}
