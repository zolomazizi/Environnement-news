using EnveronementNaws.Data;
using EnveronementNaws.Models;
using EnveronementNews.Data;
using EnveronementNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EnveronementNews.Controllers
{
    [RoutePrefix("api/Journalist")]
    public class JournalistController : ApiController
    {
        [Route("listJournalist")]
        public IHttpActionResult GetJournalists()
        {

            var journalistes = new List<JournalistesModel>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();

                var journaliste = context.Journalistes.ToList();
                if (journaliste == null)
                {
                    return NotFound();
                }

                foreach (var n in journaliste)
                {
                    JournalistesModel vm = new JournalistesModel();
                    vm.Nom = n.Nom;
                    vm.Prenom = n.Prenom;
                    vm.Image = n.Image;
                    vm.Email = n.Email;
                    vm.Statu = n.Statu;
                    vm.NombrArticle = context.Article.Count();
                    vm.ID = n.ID;

                    journalistes.Add(vm);
                }

            }
            return Ok(journalistes);
        }
        //public IHttpActionResult GetJournaliste(int id)
        //{
        //    JournalistesModel journaliste;
        //    using (var context = new NEWSEntities())
        //    {
        //        var A = context.Journalistes.Where(f => f.ID == id).FirstOrDefault();
        //        if (A == null)
        //        {
        //            return NotFound();
        //        }
        //        journaliste = new JournalistesModel();
        //        journaliste.ID = id;
        //        journaliste.Nom = A.Nom;
        //        journaliste.Prenom = A.Prenom;
        //        journaliste.Image = A.Image;

        //    }
        //    return Ok(journaliste);
        //}
        [Route("journalistSelect/{id}")]
        public IHttpActionResult GetJournalist(int id = 0)
        {

            JournalistViewModel vm;
            using (var context = new NEWSEntities())
            {
                var j = context.Journalistes.Where(jl => jl.ID == id).FirstOrDefault();
                if (j == null)
                {
                    return NotFound();
                }
                vm = new JournalistViewModel();
                vm.ID = id;
                vm.Nom = j.Nom;
                vm.Prenom = j.Prenom;
                vm.Image = j.Image;
                vm.Statu = j.Statu;
                vm.NombrArticle = j.Article.Count();
                vm.Email = j.Email;
                //vm.articles = j.Article.ToList();
                

                var al = new List<Article>();
                //var jn = context.Article.Where(jl => jl.ID == j.).ToList();
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

        private NEWSEntities db = new NEWSEntities();
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJournaliste(int id, Journalistes journalistes)

        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != journalistes.ID)
            {
                return BadRequest();
            }

            db.Entry(journalistes).State = EntityState.Modified;
            db.SaveChanges();
          

            return StatusCode(HttpStatusCode.NoContent);
        }

        //var al = new List<JournalistViewModel>();


        //using (var context = new NEWSEntities())
        //{
        //    var j = context.Journalistes.ToList();
        //    if (j == null)
        //    {
        //        return NotFound();
        //    }
        //   // vm = new JournalistViewModel();



        //    foreach (var a in j )
        //    {
        //        JournalistViewModel am = new JournalistViewModel();
        //        am.ID = a.ID;
        //        am.Nom = a.Nom;
        //        am.Prenom = a.Prenom;
        //        am.Image = a.Image;
        //        am.NombrArticle = a.Article.Count();



        //        List<Article> art = new List<Article>();
        //        foreach(var c in a.Article)
        //        {
        //            Article artc = new Article();
        //            artc.ID = c.ID;
        //            artc.Titre = c.Titre;
        //            artc.Body = c.Body;
        //            artc.Img = c.Img;
        //            artc.video = c.video;
        //            art.Add(artc);


        //        }
        //        am.articles = art;
        //        al.Add(am);
        //    }


        //}
        //return Ok(al);
    }


}
