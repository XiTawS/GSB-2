using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.Models
{
    internal class Appartient
    {
        public int IdMedicine { get; set; }
        public int IdPrescription { get; set; }

        public int Quantity { get; set; }

        public Appartient() { }

        public Appartient(int id_medicine, int id_prescription, int quantity)
        {
            this.IdMedicine = id_medicine;
            this.IdPrescription = id_prescription;
            Quantity = quantity;
        }
    }
}
