using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.Models
{
    internal class Patient
    {
        public int IdPatient { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Firstname { get; set; }
        public string Gender {  get; set; }

        public Patient() { }

        public Patient(int id_patient, int id_user, string name, int age, string firstname, string gender)
        {
            IdPatient = id_patient;
            IdUser = id_user;
            Name = name;
            Age = age;
            Firstname = firstname;
            Gender = gender;
        }
    }
}
