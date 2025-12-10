# 🗄️ Documentation Base de Données

Cette section détaille la configuration technique de la connexion à la base de données.

---

## 🔌 Classe Database

La classe `Database` est responsable de l'établissement de la connexion avec le serveur MySQL.

### Configuration

La chaîne de connexion est définie en dur dans la classe (attribut `private readonly`).

| Paramètre | Valeur (Défaut) | Description |
| :--- | :--- | :--- |
| **Server** | `10.28.65.35` | Adresse IP du serveur de base de données. |
| **UID** | `root` | Identifiant utilisateur MySQL. |
| **PWD** | `root` | Mot de passe utilisateur. |
| **Database** | `gsb-2` | Nom de la base de données cible. |

> [!IMPORTANT]
> Assurez-vous que ces paramètres correspondent à votre environnement local ou de production avant de lancer l'application. Vous devrez probablement modifier l'adresse IP si le serveur n'est pas sur le même réseau.

### Méthodes

| Méthode | Type de Retour | Description |
| :--- | :--- | :--- |
| `GetConnection()` | `MySqlConnection` | Instancie et retourne un nouvel objet `MySqlConnection` prêt à être ouvert par les DAO. |

### Exemple d'Utilisation (dans un DAO)

```csharp
using (var connection = db.GetConnection())
{
    connection.Open();
    // Exécution des requêtes...
}
```

---

## 🐋 Installation via Docker

Vous pouvez lancer rapidement une instance MySQL compatible avec l'application en utilisant Docker.

### Configuration Facile

Le projet inclut un fichier de configuration Docker Compose prêt à l'emploi situé dans `Documentation/utils/compose.yml`.

1. **Accédez au dossier** :
   ```bash
   cd Documentation/utils/
   ```

2. **Lancez les services** :
   ```bash
   docker-compose up -d
   ```
   > Cette commande va démarrer un serveur MySQL 8.0 et une interface phpMyAdmin.

3. **Accès** :
   - **MySQL** : Port `3306`
   - **phpMyAdmin** : [http://localhost:8080](http://localhost:8080)

4. **Importation des Données** :
   - Connectez-vous à phpMyAdmin (serveur: `mysql`, utilisateur: `root`, mot de passe: `root`).
   - Sélectionnez la base de données (ex: `sql_sio` ou créer `gsb-2`).
   - Allez dans l'onglet **Importer**.
   - Choisissez le fichier `Documentation/utils/mydatabase.sql`.
   - Cliquez sur **Importer** en bas de page.

> [!WARNING]
> Le fichier `compose.yml` actuel configure une base de données nommée `sql_sio`. Assurez-vous que votre chaîne de connexion dans l'application ou le nom de la base dans le compose correspond à vos besoins (par défaut l'app utilise `gsb-2`).

> [!NOTE]
> Une fois le conteneur lancé, n'oubliez pas d'importer le script SQL initial (si disponible) pour créer les tables et insérer les données de test.

