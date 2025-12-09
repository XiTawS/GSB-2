// GSB_2/Models/Prescription.cs
namespace GSB_2.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }
        public int IdUser { get; set; }
        public int IdPatient { get; set; }
        public DateTime Validity { get; set; }

        // Propriétés d’affichage (remplies par le DAO)
        public string Patient { get; set; } = "";
        public string Médecin { get; set; } = "";
        public string Médicaments { get; set; } = "";

        // Constructeur pour lire depuis la BDD (4 paramètres)
        public Prescription(int idPrescription, int idUser, int idPatient, DateTime validity)
        {
            IdPrescription = idPrescription;
            IdUser = idUser;
            IdPatient = idPatient;
            Validity = validity;
        }

        // Constructeur pour créer une nouvelle ordonnance (3 paramètres) ← C’EST CELUI QUI MANQUAIT !
        public Prescription(int idUser, int idPatient, DateTime validity)
        {
            IdUser = idUser;
            IdPatient = idPatient;
            Validity = validity;
        }

        public override string ToString()
        {
            return $"N°{IdPrescription} - {Patient} - {Validity:dd/MM/yyyy}";
        }
    }
}