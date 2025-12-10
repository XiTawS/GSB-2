# 🗄️ Documentation DAO (Objets d'Accès aux Données)

Cette section détaille les Objets d'Accès aux Données (DAO) utilisés pour interagir avec la base de données MySQL. Ces classes gèrent toutes les opérations CRUD (Créer, Lire, Mettre à jour, Supprimer).

---

## 🔑 UserDAO

Gère les opérations liées à l'entité `User` (Connexion, Gestion).

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `Login(string email, string password)` | `User?` | Authentifie un utilisateur. Retourne `null` en cas d'échec. |
| `GetAll()` | `List<User>` | Récupère tous les utilisateurs de la base de données. |
| `CreateUser(string name, string firstname, string email, string password, bool role)` | `bool` | Crée un nouvel utilisateur avec un mot de passe haché. |
| `GetById(int idUser)` | `User?` | Récupère un utilisateur spécifique par son ID. |
| `Update(int idUser, string name, string firstname, string email, string plainPassword, bool role)` | `bool` | Met à jour les détails de l'utilisateur. Ne met à jour le mot de passe que si un nouveau est fourni. |
| `Delete(int idUser)` | `bool` | Supprime un utilisateur. Retourne `false` si l'utilisateur est lié à d'autres entités (contrainte de clé étrangère). |

---

## 💊 MedicineDAO

Gère les opérations liées à `Medicine`.

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `GetAll()` | `List<Medicine>` | Récupère tous les médicaments, triés par nom. |
| `CreateMedicine(int id_user, string name, string molecule, string dosage, string description)` | `bool` | Ajoute un nouveau médicament à l'inventaire. |
| `GetById(int idMedicine)` | `Medicine?` | Récupère un médicament spécifique par ID. |
| `Update(Medicine med)` | `bool` | Met à jour les détails du médicament. |
| `Delete(int idMedicine)` | `bool` | Supprime un médicament. Protégé contre les contraintes de clé étrangère (FK). |

---

## 🏥 PatientDAO

Gère les opérations liées à `Patient`.

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `GetAll()` | `List<Patient>` | Récupère tous les patients. |
| `GetById(int idPatient)` | `Patient?` | Récupère un patient spécifique par ID. |
| `CreatePatient(int id_user, string name, string firstname, int age, string gender)` | `bool` | Enregistre un nouveau patient. |
| `Update(Patient patient)` | `bool` | Met à jour les informations du patient. |
| `Delete(int idPatient)` | `bool` | Supprime un patient. |

---

## 📄 PrescriptionDAO

Gère les opérations liées à `Prescription`. Ce DAO est plus complexe car il gère la relation entre les Ordonnances et les Médicaments via une transaction.

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `GetAll()` | `List<Prescription>` | Récupère toutes les ordonnances avec les données jointes (Nom du patient, Nom du médecin, Liste des médicaments). |
| `Create(Prescription prescription, Dictionary<int, int> medicines)` | `bool` | Crée une ordonnance et lie les médicaments en une **seule transaction**. |
| `UpdatePrescription(int idPrescription, int idPatient, DateTime validity, Dictionary<int, int> newMedicines)` | `bool` | Met à jour une ordonnance. Supprime les anciennes associations de médicaments et ajoute les nouvelles. |
| `DeletePrescription(int idPrescription)` | `bool` | Supprime une ordonnance (La suppression en cascade devrait gérer les associations). |

---

## 🔗 AppartientDAO

Gère la relation plusieurs-à-plusieurs entre `Prescription` et `Medicine`.

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `GetByPrescriptionId(int idPrescription)` | `List<Appartient>` | Récupère la liste des médicaments (et quantités) pour une ordonnance donnée. |
| `AddMedicineToPrescription(int id_prescription, int id_medicine, int quantity)` | `bool` | Lie directement un médicament à une ordonnance. |
