# 📦 SwiftStock

**SwiftStock** est une application de bureau (Windows Forms) conçue pour faciliter la gestion de stock dans un magasin ou un entrepôt. Elle permet d’ajouter, modifier, supprimer des produits, suivre les entrées et sorties, générer des alertes et bien plus.

## 🛠️ Fonctionnalités

- 🔐 Gestion des utilisateurs :
  - SuperAdmin : contrôle total (création d’admins et de clients)
  - Admin : création et gestion de clients
- 📦 Gestion des produits :
  - Ajout, modification, suppression
  - Association à des catégories
  - Stock en temps réel
- 📁 Gestion des catégories
- 📊 Suivi des mouvements de stock :
  - Entrées / Sorties
  - Historique de mouvement
- 📉 Alertes pour les stocks faibles ou rupture
- 📈 Tableau de bord :
  - Produits les plus vendus
  - Produits en faible quantité
- 📤 Export / Import des données (CSV)
- 💳 Gestion des commandes et paiements clients

## 🖥️ Technologies utilisées

- .NET 8.0 (Windows Forms)
- Entity Framework Core + MySQL
- Guna UI 2 pour une interface moderne
- CsvHelper pour l’import/export
- GitHub pour le versionnement

## 📷 Aperçu (Screenshots)

*(À insérer plus tard lorsque tu auras les vues)*

## 📦 Installation

1. Cloner le projet :
   ```bash
   git clone https://github.com/mzmantar/SwiftStock.git
   ```

2. Ouvrir le projet avec Visual Studio 2022

3. Restaurer les packages NuGet si nécessaire

4. Appliquer les migrations :
   ```bash
   dotnet ef migrations add AddAllTables --project SwiftStock.csproj
   dotnet ef database update --project SwiftStock.csproj
   ```

5. Lancer l'application

## ✅ Statut du projet

✅ Contrôleurs terminés  
🚧 Développement des vues en cours  

## 👤 Auteur

- **Mehdi Z. — [GitHub](https://github.com/mzmantar)
