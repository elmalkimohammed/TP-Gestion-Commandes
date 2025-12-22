# Fait le mappage (CategorieVM -> Categorie)
	- Création d'une modèle Catgorie
	- Fait le dans une classe séparer (SOLID), va étre static
# Supprimer le code du traitement du MySql (CategoriesController -> /Repository/CategorieRepository.cs)
	- Créer une classe CategorieRepository qui contient le code de traitement de la BDD
	- Créer une interface ICategorieRepository (Contre le couplage fort)
	- Implémenter l'interface dans CategorieRepository
	- Déplacer le code de traitement de la BDD dans CategorieRepository
# appsettings.json
	- Ajouter la chaine de connexion
	## Utilisation de la chaine de connexion
		- Injecter IConfiguration dans le constructeur de CategorieRepository
# NOTE BIEN :
	- Pour injecter dans un seul fonction : [FromServices] 
