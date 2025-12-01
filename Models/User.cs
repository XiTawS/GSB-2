using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_2.Models
{
    internal class User
    {
        //Ceci est une propriété. 
        //Elle permet d'acceder en lecture et en ecriture à notre attribut via les méthodes get et set.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        public static User Connected { get; set; } = null!;


        //Ceci est un constructeur par défaut.
        //Il permet de créer une instance de la classe qui nous permettra d'acceder aux méthodes et propriétés de celle ci. 
        public User() { }

        //Ceci est une surcharge du constructeur elle permettra la création d'objet User.
        //Elle sera instancié avec les valeurs passées en paramètres.
        public User(int id, string name, string firstname, bool role)
        {
            this.Id = id;
            this.Name = name;
            this.Firstname = firstname;
            this.Role = role;
        }
    }
}
