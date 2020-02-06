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
using System.Web.Http.Description;

namespace EnveronementNews.Controllers
{
    [RoutePrefix("api/RedactionEnchef")]
    [Authorize(Roles = "ChefRedaction")]
    public class ChefRedactionController : ApiController
    {
        [Route("RedactionEnChefs")]
        public IHttpActionResult GetChefRedactions()
        {

            var redacteurs = new List<ChefRedactionModel>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();

                var redacteur = context.RedacteurEnChef.ToList();
                if (redacteur == null)
                {
                    return NotFound();
                }

                foreach (var n in redacteur)
                {
                    ChefRedactionModel vm = new ChefRedactionModel();
                    vm.Nom = n.Nom;
                    vm.Prenom = n.Prenom;
                    vm.Image = n.Image;
                    vm.Email = n.Email;
                    vm.Statu = n.Statu;
                    vm.NombrArticle = context.Article.Count();
                    vm.ID = n.ID;

                    redacteurs.Add(vm);
                }

            }
            return Ok(redacteurs);
        }
        [Route("RedactionEnChef")]
        public IHttpActionResult GetJChefRedactions(int id = 0)
        {

            RedacteurEnChefModel vm;
            using (var context = new NEWSEntities())
            {
                var j = context.RedacteurEnChef.Where(jl => jl.ID == id).FirstOrDefault();
                if (j == null)
                {
                    return NotFound();
                }
                vm = new RedacteurEnChefModel();
                vm.ID = id;
                vm.Nom = j.Nom;
                vm.Prenom = j.Prenom;
                vm.Image = j.Image;
                vm.Statu = j.Statu;
                vm.NombrArticle = j.Article.Count();
                vm.Email = j.Email;

                var al = new List<Article>();
                foreach (var a in j.Article)
                {
                    Article am = new Article();
                    am.ID = a.ID;
                    am.Titre = a.Titre;
                    am.Body = a.Body;
                    am.Img = a.Img;
                    am.Date = a.Date;
                    am.video = a.video;

                    al.Add(am);
                }
                vm.articles = al;

            }
            return Ok(vm);
        }
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
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    articles.Add(vm);
                }
            }
            return Ok(articles);
        }
        private NEWSEntities db = new NEWSEntities();
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChefRedaction(int id, RedacteurEnChef redacteurEnChef)

        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != redacteurEnChef.ID)
            {
                return BadRequest();
            }

            db.Entry(redacteurEnChef).State = EntityState.Modified;
            db.SaveChanges();


            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
