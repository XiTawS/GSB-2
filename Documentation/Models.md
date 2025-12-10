# 📚 Documentation des Modèles

Cette section détaille les modèles de données utilisés dans l'application **GSB-2**. Ces classes représentent les entités principales du domaine.

---

## 🧑‍⚕️ User (Utilisateur)

Représente un utilisateur de l'application (Médecin, Technicien de laboratoire, etc.).

| Propriété | Type | Description |
| :--- | :--- | :--- |
| `Id` | `int` | Identifiant unique de l'utilisateur. |
| `Name` | `string` | Nom de famille de l'utilisateur. |
| `Firstname` | `string` | Prénom de l'utilisateur. |
| `Email` | `string` | Adresse email (utilisée pour la connexion). |
| `Password` | `string` | Mot de passe haché. |
| `Role` | `bool` | Identifiant de rôle (ex: `true` pour Médecin, `false` pour Labo). |

### Constructeurs
- `User()`: Constructeur par défaut.
- `User(int id, string name, string firstname, bool role)`: Initialise un utilisateur avec des détails spécifiques.

---

## 💊 Medicine (Médicament)

Représente un médicament disponible dans le système.

| Propriété | Type | Description |
| :--- | :--- | :--- |
| `IdMedicine` | `int` | Identifiant unique du médicament. |
| `IdUser` | `int` | ID de l'utilisateur qui a créé/géré cette entrée. |
| `Name` | `string` | Nom commercial du médicament. |
| `Description` | `string` | Description ou détails sur le médicament. |
| `Molecule` | `string` | Ingrédient actif/molécule. |
| `Dosage` | `string` | Informations sur le dosage recommandé. |

### Constructeurs
- `Medicine()`: Constructeur par défaut.
- `Medicine(int id, int idUser, string dosage, string name, string description, string molecule)`: Initialisation complète.

---

## 🏥 Patient

Représente un patient recevant des soins.

| Propriété | Type | Description |
| :--- | :--- | :--- |
| `IdPatient` | `int` | Identifiant unique du patient. |
| `IdUser` | `int` | ID du médecin associé au patient. |
| `Name` | `string` | Nom de famille du patient. |
| `Firstname` | `string` | Prénom du patient. |
| `Age` | `int` | Âge du patient. |
| `Gender` | `string` | Genre du patient. |

### Constructeurs
- `Patient()`: Constructeur par défaut.
- `Patient(int id, int idUser, string name, int age, string firstname, string gender)`: Initialisation complète.

---

## 📄 Prescription (Ordonnance)

Représente une ordonnance médicale émise par un médecin pour un patient.

| Propriété | Type | Description |
| :--- | :--- | :--- |
| `IdPrescription` | `int` | Identifiant unique de l'ordonnance. |
| `IdUser` | `int` | ID du médecin émettant l'ordonnance. |
| `IdPatient` | `int` | ID du patient recevant l'ordonnance. |
| `Validity` | `DateTime` | Date d'expiration ou de validité de l'ordonnance. |
| `Patient` | `string` | Nom d'affichage du patient (calculé). |
| `Médecin` | `string` | Nom d'affichage du médecin (calculé). |
| `Médicaments` | `string` | Résumé des médicaments prescrits (calculé). |

### Constructeurs
- `Prescription(int idPrescription, int idUser, int idPatient, DateTime validity)`: Pour le chargement depuis la BDD.
- `Prescription(int idUser, int idPatient, DateTime validity)`: Pour la création d'une nouvelle ordonnance.

---

## 🔗 Appartient (Détails de l'ordonnance)

Classe d'association reliant `Prescription` et `Medicine`. Représente une ligne dans une ordonnance.

| Propriété | Type | Description |
| :--- | :--- | :--- |
| `IdMedicine` | `int` | ID du médicament prescrit. |
| `IdPrescription` | `int` | ID de l'ordonnance. |
| `Quantity` | `int` | Quantité de médicament prescrit. |

### Constructeurs
- `Appartient()`: Constructeur par défaut.
- `Appartient(int id_medicine, int id_prescription, int quantity)`: Initialisation complète.
