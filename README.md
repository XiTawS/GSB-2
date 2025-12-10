# 💊 GSB-2 - Gestion des Prescriptions Médicales

Bienvenue dans la documentation du projet **GSB-2**. Cette application C# WinForms est conçue pour gérer des données médicales, incluant les patients, les médicaments et les ordonnances.

---

## 📚 Contenu de la Documentation
La documentation est divisée en trois sections principales pour une meilleure lisibilité :

### 🖥️ Interface Utilisateur
Détaille les Formulaires et la logique d'interaction (Connexion, Tableau de bord Médecin, Tableau de bord Labo).
[Documentation des Formulaires](Documentation/Forms.md)

### 🗄️ Accès aux Données
Détails techniques sur la communication de l'app avec la base de données MySQL (Pattern DAO).
[Documentation DAO](Documentation/DAO.md) | [Connexion BDD](Documentation/Database.md)

### 📄 Modèles de Données
Définitions des entités principales (User, Patient, Medicine, etc.).
[Documentation des Modèles](Documentation/Models.md)

---

## 🚀 Démarrage Rapide

1. **Cloner le dépôt**.
2. **Lancer la Base de Données** (Facile) :
   ```bash
   docker-compose -f Documentation/utils/compose.yml up -d
   ```
   > Cela lance MySQL et phpMyAdmin (http://localhost:8080).

3. **Importer les Données** :
   - Connectez-vous à phpMyAdmin (`root` / `root`)
   - Importez le fichier `Documentation/utils/mydatabase.sql`.

4. **Configurer & Lancer** : Ouvrez `GSB-2.sln` dans Visual Studio et lancez le projet.

---

## 🛠️ Fonctionnalités Clés

- **Contrôle d'Accès basé sur les Rôles** : Interfaces séparées pour les Médecins et les Techniciens de Labo.
- **Authentification Sécurisée** : Hachage de mot de passe (SHA256) pour la sécurité des utilisateurs.
- **Recherche Dynamique** : Filtrage en temps réel sur toutes les listes de données.
- **Gestion des Ordonnances** : Flux complet pour créer et gérer des ordonnances avec plusieurs médicaments.

---

## 👤 Comptes de Test

Utilisez ces comptes pour vous connecter à l'application :

| Rôle | Email | Mot de passe |
| :--- | :--- | :--- |
| **Technicien Labo** | `labo@gsb.com` | `password` |
| **Médecin** | `doc@gsb.com` | `password` |