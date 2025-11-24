using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.Models
{
    internal class Medicine
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int Dosage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Molecule { get; set; }


        public Medicine() { }

        public Medicine(int Id, int IdUser, int Dosage, string Name, string Description, string Molecule)
        {
            this.Id = Id;
            this.IdUser = IdUser;
            this.Dosage = Dosage;
            this.Name = Name;
            this.Description = Description;
            this.Molecule = Molecule;
        }
    }
}
