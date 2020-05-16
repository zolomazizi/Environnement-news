using EnveronementNaws.Data;
using EnveronementNaws.Models;
using EnveronementNews.Data;
using EnveronementNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace EnveronementNews.Controllers
{
    [RoutePrefix("api/Article")]
    public class ArticlesController : ApiController
    {
        //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [Route("Article")]
        public IHttpActionResult GetArticle()
        {
            var articles = new List<ViewArticleJournalist>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();
                var status = "posted";
                var article = context.Article.Where(f => f.Status == status).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalist vm = new ViewArticleJournalist();
                    vm.ID = n.ID;
                    
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    vm.JournalisteImg = n.Journalistes.Image;
                    vm.JournalistesID = n.Journalistes.ID;
                    vm.Description = n.Description;
                    articles.Add(vm);
                }

            }
            return Ok(articles);
        }
        [Route("ToutArticles")]
        public IHttpActionResult GetArticles(string status = "")
        {

            var articles = new List<ViewArticleJournalist>();


            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();

                var article = context.Article.Where(f => f.Status == status).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalist vm = new ViewArticleJournalist();
                    vm.ID = n.ID; 
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    vm.JournalistesID = n.Journalistes.ID;
                    articles.Add(vm);
                }
            }
            return Ok(articles);
        }
        [Route("Articleslide")]
        public IHttpActionResult GetSlideArticle()
        {

            var articles = new List<ViewArticleJournalist>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();
                var status = "posted";
                var article = context.Article.Where(f => f.Status == status).OrderBy(a => a.Date).Take(4).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalist vm = new ViewArticleJournalist();
                    vm.ID = n.ID;
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    //vm.Journaliste = n.Journalistes.Nom;
                    //vm.JournalistesID = n.Journalistes.ID;
                    articles.Add(vm);
                }

            }
            return Ok(articles);
        }
        [Route("DetaileArticle/{id}")]
        public IHttpActionResult GetArticle(int id)
        {
            ViewArticleJournalist article;
            using (var context = new NEWSEntities())
            {
                var A = context.Article.Where(f => f.ID == id).FirstOrDefault();
                if (A == null)
                {
                    return NotFound();
                }
                article = new ViewArticleJournalist();
                article.ID = id;
                article.Titre = A.Titre;
                article.Body = A.Body;
                article.Img = A.Img;
                article.Video = A.video;
                article.Date = A.Date;
                article.Journaliste = A.Journalistes.Nom;
                article.JournalistesID = A.Journalistes.ID;
                article.Categorie = A.Categorie.ID;
                
            }
            return Ok(article);
        }
        [Route("commentEnPost")]
        [ResponseType(typeof(Commentaire))]
        public IHttpActionResult PostArticle(Commentaire commentaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new NEWSEntities())
            {
                context.Commentaire.Add(commentaire);
                context.SaveChanges();

            }


            return Ok();
            //return CreatedAtRoute("DefaultApi", new { id = commentaire.ID }, commentaire);
        }


        [Route("comment/{id}")]
        public IHttpActionResult GetCommentaire(int id)
        {
            CommentaireModel commentair;
            using (var context = new NEWSEntities())
            {
                var A = context.Commentaire.Where(f => f.ArticleID == id).FirstOrDefault();
                if (A == null)
                {
                    return NotFound();
                }
                commentair = new CommentaireModel();
                commentair.ArticleID = id;
                commentair.Contenu = A.Contenu;
                commentair.User_mail = A.User_mail;
                commentair.User_name = A.User_name;
                commentair.CommentaireDate = A.CommentaireDate;

            }
            return Ok(commentair);
        }

        [Route("DaysArticle")]
        public IHttpActionResult GetArticleByDate()
        {

            FooterArticle Footer = new FooterArticle();
            FooterArticleModel fa1, fa2, fa3;
            using (var context = new NEWSEntities())
            {
                var today = DateTime.Now;
                List<ArticleModel> x = new List<ArticleModel>();
                fa1 = new FooterArticleModel();
                var yesterday1 = today.AddDays(-1);
                List<Article> articles = context.Article.Where(f => f.Date.Value.Day == yesterday1.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles)
                {
                    var article = new ArticleModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();

                    x.Add(article);

                }
                fa1.listes = x;
                fa1.Img = context.Article.FirstOrDefault().Img;
                Footer.fam1 = fa1;

                fa2 = new FooterArticleModel();
                List<ArticleModel> y = new List<ArticleModel>();
                var yesterday2 = today.AddDays(-2);
                List<Article> articles1 = context.Article.Where(f => f.Date.Value.Day == yesterday2.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles1)
                {
                    var article = new ArticleModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();
                    y.Add(article);

                    //fa2.listes.Add(article);
                }
                fa2.listes = y;
                fa2.Img = context.Article.FirstOrDefault().Img;
                Footer.fam2 = fa2;

                fa3 = new FooterArticleModel();
                List<ArticleModel> z = new List<ArticleModel>();
                var yesterday3 = today.AddDays(-3);
                List<Article> articles2 = context.Article.Where(f => f.Date.Value.Day == yesterday3.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles2)
                {
                    var article = new ArticleModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();
                    z.Add(article);
                    //fa3.listes.Add(article);
                }
                fa3.listes = z;
                fa3.Img = context.Article.FirstOrDefault().Img;
                Footer.fam3 = fa3;





            }

            return Ok(Footer);
        }
       
        [Route("ArticleEnPost")]
        [HttpPost]
        [ResponseType(typeof(Article))]

        public IHttpActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new NEWSEntities())
            {
                context.Article.Add(article);
                context.SaveChanges();

            }


            return Ok();
            //return CreatedAtRoute("DefaultApi", new { id = article.ID }, article);
        }
        private NEWSEntities db = new NEWSEntities();
        [Route("ArticleEnPut/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArticle(int id, Article article)

        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != article.ID)
            {
                return BadRequest();
            }

            db.Entry(article).State = EntityState.Modified;
            db.SaveChanges();


            //return StatusCode(HttpStatusCode.NoContent);
            return Ok();
        }








    }
}
