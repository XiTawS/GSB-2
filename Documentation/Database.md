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
