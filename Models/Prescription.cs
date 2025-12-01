using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.Models
{
    internal class Prescription
    {
        public int IdPrescription { get; set; }
        public int IdUser { get; set; }
        public DateTime Validity { get; set; }
        public string Medicines { get; set; }
        public int idPatient { get; set; }

        public Prescription() { }

        public Prescription(int id_prescription, int id_user, DateTime validity,string medicines, int id_patient) 
        {
            this.IdPrescription = id_prescription;
            this.IdUser = id_user;
            this.Validity = validity;
            this.Medicines = medicines;
            this.idPatient = id_patient;
        }


    }
}
