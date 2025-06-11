# App_produit – Gestion de produits (Test technique Canadel)

Ce projet est une API RESTful développée avec **ASP.NET Core Web API** permettant la gestion d’un catalogue de produits. Il a été réalisé dans le cadre d'un test technique pour un poste de developeur fullstack.

## Fonctionnalités

Ici, je me suis contenter aux fonctions de base correspondant au Crud.
- Lister les produits
- Ajouter un nouveau produit
-  Modifier un produit
-  Supprimer un produit

---

## Technologies utilisées

- **Langage :** C#, .NET 8
- **Framework :** ASP.NET Core Web API
- **Base de données :** SQL Server (via SQL Server Management Studio)
- **ORM :** Entity Framework Core
- **IDE :** Visual Studio Code

---

## Structure du projet

- `Produit.cs` : modèle de données avec les champs `Id`, `Name`, `Description`, `Price`, `CreatedAt` correspondant a la description données dans le cahier de charge.
- `ProduitController.cs` : contrôleur exposant les endpoints CRUD via des routes HTTP
- `DbContext` configuré pour interagir avec SQL Server
- Configuration de la base dans `appsettings.json`
- Swagger activé pour tester facilement l’API localement

---

## Exécution du projet en local

### Prérequis
- [.NET SDK 8](https://dotnet.microsoft.com/en-us/download)
- (Facultatif) SQL Server et SQL Server Management Studio (SSMS)

### Étapes

1. **Cloner le dépôt**
   ```bash
   git clone https://github.com/romaric111/App_produit.git
   cd App_produit
2. **Configurer la base de données**
   Si vous avez SQL Server localement, allez dans le fichier appsettings.json et modifier le  avec votre chaîne de connexion personnalisée aux niveau de connectionstring :
json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=App_produit;Trusted_Connection=True;TrustServerCertificate=True;"
}
Sinon, commentez la base réelle et basculez vers une InMemoryDatabase pour juste tester les endpoints sans database (version à intégrer si souhaitée).
3. **Appliquer les migrations**
   Aller dns tools puis aller sur Nuget package controler et cliquer sur package manager console puis runner les commandes: **migration-database** puis **database update** et ca va creer  les differentes tables.
   4. **Lancer L'app**
      tester le via swagger avec votre adress localhost qui sera surement: Https://localhost:5001/swagger.


     # Test:
   En ce qui concerne les tests j'ai opté par concrainte de livrable pour rester avec la solution testable manuellement via swagger ou postman au lieu de rajouter un xUnit pour les tests. 
