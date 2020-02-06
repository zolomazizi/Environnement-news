

<br />
<p align="center">
  <a href="https://github.com/zolomazizi/Environnement-news">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Project P2</h3>

  <p align="center">
   Environnement news site web
    <br />
    <a href="https://github.com/zolomazizi/"><strong>view profile »</strong></a>
    <br />
    <br />
    <a href="https://github.com/zolomazizi/Environnement-news">View Demo</a>
    ·
    <a href="https://github.com/zolomazizi/AngularP2">Front end projecte</a>
    ·
    <a href="https://github.com/zolomazizi/DashboardAngular">front end dashboard</a>
  </p>
</p>


* [PRÉSENTATION DU PROJET ](#PRÉSENTATION_DU_PROJET )
  * [Identification de besoin ](#Identification_de_besoin )
* [Description de l'existant ](#Description_de_l'existant )
  * [Definition du projet](#Definition_du_projet)
  * [OBJECTIFS](#OBJECTIFS)
  * [CARACTÉRISTIQUES](#CARACTÉRISTIQUES)
* [Diagrame](#diagrame)
  * [Diagramme de Use Case ](#Diagramme_de_Use_Case )
  * [Diagramme de séquence ](#Diagramme_de_séquence )
  * [Diagramme de classe ](#Diagramme_de_classe )
* [Les packages installés ](#Les_packages_installés )
* [Conception de Code ](#Conception_de_Code )
* [Les API à consommer ](#Les_API_à_consommer )
* [Contact](#contact)

## PRÉSENTATION DU PROJET

Youcode est une école de programmation qui ouvre les chances à tout le monde. C'est le rêve de tout débutant en codage et développement web, nouvellement créée à Youssoufia avec la collaboration du Groupe OCP et du leader français de l'éducation numérique (Simplon).

### Identification de besoin

Après la réunion avec M. Jaafar DAHBI (personnel de IT6 à Rabat), organisée dans le cadre de l'identification des problèmes confrontés par les gens intéressés par les nouveautés de la technologie et de l’informatique. À ce stade on a pu identifier les difficultés au niveau du nombre énorme des sites informatiques, et la nécessité d’une plateforme qui facilite l'accès aux nouveautés proposés par ces sites . 

## Description de l'existant

Si on prend par exemple le site web yahoo créé en 1999 constitué de plusieurs catégories et parmi ses catégories on trouve l'actualité informatique, la façon dont le site web est composé perturbe la bonne expérience de l’utilisateur par le nombre de rubriques et de pages proposés par le site et la façon de présentation des articles.


_parmi les site web qui existe est attaque le même marcher en site ci-dessous quelque exemple:_

1. https://www.unenvironment.org/

2. https://news.mongabay.com/

3. https://www.thegef.org/

4. https://www.wri.org/

### Definition du projet

Dans le cadre du projet on est appelés à réaliser un projet pour la validation des compétences. 
La presse spécialisée regroupe l’ensemble des publications par opposition à la presse généraliste abordent un domaine particulier ou traite d’un thème précis. Comme techniques, sportifs, musicaux, littéraires ou scientifiques.

Dans notre cas en vas réaliser un projet de la presse thématique (Environnement news) 




### OBJECTIFS
 
1.	Création du Platform web d’actualités Environnement.
 
2.	Création d’une interface Admin (Dashboard) :

    a – La gestion des profils journaliste et rédacteur chef  et droit utilisateur.
    
    b – fonctionnalité CRUD (Modification, Supression,Consultation,Ajout).
    
    c - L’automatisation du système de notification .
    
 3. consommation des flux externe (rss , rest api ).
 
 
 ### CARACTÉRISTIQUES
 
- Un espace de blog ou d’actualités.
 
-	Un espace admin (Dashboard).

-	Un espace journaliste.

-	Un espace de rédacteur chef 

-	Consommer des API ou flux d’actualités.

-	Un Formulaire de contact.

-	Partage des liens vers les réseaux sociaux.

-	Fonctionnalité de CRUD (Ajouter, Modifier, Supprimer, Consultation).

-	Espace Twitter #Relative avec l’environnement.

-	Les notifications par mail.

-	La météo.

-	Les publicités.

## Diagrame

- Conception de bases de données relationnelles avec UML. 

### Diagramme de Use Case 

### Diagramme de séquence

### Diagramme de classe



## Les packages installés

•	Microsoft.AspNet.WebApi.Cors

•	Microsoft.AspNet.Identity.Core

•	EntityFramework

•	Miscrosoft.Owin.Cors


## Conception de Code

Projet ASP.NET utilisant identité et entité Framework

Pour réalise nous projet en a divise la solution a 3 partie 

•	Partie RESTAPI tourisme qui contient des contrôleurs et des models.

•	Partie DATA sous forme d’une bibliothèque de classe qui contient un ADO lié avec notre base de données 

•	Partie LOGIQUE qui contient des traitements hors métiers.


## Les API à consommer


AUTHENTIFICATION :

### Api/account/logup

Pour consommer API de registrement (journaliste ,redaction en chef , gestiooner ) il faut utiliser le lien:
```sh
Api/account/logup a Authorize Gestionner 
```
ainsi qu’envoyer les informations au body

Nom(String), Prenom(String), Email(String),Tele(int), Statu(Bool),Role(‘journalistes’ ou ‘Gestionner’), Password(String), ConfirmPassword(String).

### Api/Token

•	Pour s’identifier il faut utiliser /token et envoyer au body :(Post)

	"username=" + Le nom d’utilisateur + "& password d’utilisateur=" + password + "&grant_type=password” ;
  
•	Et envoyer au header une autorisation (Post)

	var reqHeader = new HttpHeaders({ 'Content-Type': 

