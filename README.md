# Environnement-news
P2 Environnement_news
Le projet Environnement News partie ASP.NET
Les packages installés : 
•	Microsoft.AspNet.WebApi.Cors.
•	Microsoft.AspNet.Identity.Core
•	EntityFramework
•	Miscrosoft.Owin.Cors

Conception de Code : 
Projet ASP.NET utilisant identité et entité Framework
Pour réalise nous projet en a divise la solution a 3 partie 
•	Partie RESTAPI tourisme qui contient des contrôleurs et des models.
•	Partie DATA sous forme d’une bibliothèque de classe qui contient un ADO lié avec notre base de données 
•	Partie LOGIQUE qui contient des traitements hors métiers.

Les API à consommer :
 
 
AUTHENTIFICATION :

Api/logup
•	Pour consommer API de registrement (journaliste ,redaction en chef , gestiooner ) il faut utiliser le lien Api/account/logup a Authorize Gestionner , ainsi qu’envoyer les informations au body, Nom(String), Prenom(String), Email(String),Tele(int), Statu(Bool),Role(‘journalistes’ ou ‘Gestionner’), Password(String), ConfirmPassword(String).

Api/token
•	Pour s’identifier il faut utiliser /token et envoyer au body :(Post)
	"username=" + Le nom d’utilisateur + "& password d’utilisateur=" + password + "&grant_type=password” ;
•	Et envoyer au header une autorisation (Post)
	var reqHeader = new HttpHeaders({ 'Content-Type': 'application/x-www-urlencoded', 'No-Auth': 'True' }); { headers: reqHeader }


HOME:
api/ Article /Article
•	Pour avoir liste des 10 Article dans body de  page Home  il faut utiliser le lien (get) : 
api/ Article /Article
Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste 
 

api/ Article /Articleslide
•	Et pour avoir  3 article dans le slide odre par date il faut utiliser le lien (get) : Api/article/Articleslide
•	Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste 


api/ Article /DaysArticle
Pour avoir liste des les Article order par 4 jours dans footer de  page Home  il faut utiliser le lien (get) : api/ Article /DaysArticle
Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste
 
api/ Article /DetaileArticle/id
Pour avoir detaile d’Article il faut utiliser le lien (get)  avec id: api/ Article /DetaileArticle/id
Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste
 


api/ Article / ToutArticles/id
pour avoir tous les articles a touts les status(‘posted’ , ‘onposte’,’noposted’,’archiver’) 
utiliser le lien get avec id (‘posted’ , ‘onposte’,’noposted’,’archiver’) :
api/articles/toutArticles




api/ Article /ArticleEnPost
Pour avoir detaile d’Article il faut utiliser le lien (post)  : api/ Article /ArticleEnPost
                
api/ Article / ArticleEnPut
pour editer article utiliser le lien (put) : api/article/articleEnPut

api/ Article / commentEnPost
pour poster un commentair utiliser li lien (post) : api/article/commentEnPost
 
api/ Article / comment
pour geter un monnemtair utiliser le lien (get) : api/article/comment/id

api/ journalist / journalistSelect/id
Pour avoir detaile de journaliste et les article ecrite il faut utiliser le lien (get)  avec id:

api/ journalist /DetaileArticle/id
Int ID , string nom , string prenom ,string email , string tele, int nombrearticle , string img
 

api/ journalist / listJournalist
Pour avoir detaile de journaliste et les article ecrite il faut utiliser le lien (get)  avec id:

api/ journalist /listJournalist
Int ID , string nom , string prenom ,string email , string tele, int nombrearticle , 

api/ journalist / journalisteEdite
pour editer le statu de journaliste ou redaction en chef utiliser le lien(put) : 

api/journalist/ journalisteEdite
api/ RedactionEnChef / RedactionEnChef
Pour avoir detaile de redaction en chef  il faut utiliser le lien (get)  avec id:

api/ RedactionEnChef/ RedactionEnChef
Int ID , string nom , string prenom ,string email , string tele, int nombrearticle , 

api/ RedactionEnChef / RedactionEnChefs
Pour avoir liste des redaction en chef evec les article ecrit utiliser le lien (get) :


api/ RedactionEnChef / journalisteEdite
pour editer le statu de journaliste ou redaction en chef utiliser le lien(put) : 
api/journalist/ journalisteEdite


















