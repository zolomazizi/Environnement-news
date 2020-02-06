using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EnveronementNaws.Data;

namespace EnveronementNaws.Controllers
{
    public class PubsController : ApiController
    {
        private NEWSEntities db = new NEWSEntities();

        // GET: api/Pubs
        public IQueryable<Pub> GetPub()
        {
            return db.Pub;
        }

        // GET: api/Pubs/5
        [ResponseType(typeof(Pub))]
        public IHttpActionResult GetPub(int id)
        {
            Pub pub = db.Pub.Find(id);
            if (pub == null)
            {
                return NotFound();
            }

            return Ok(pub);
        }

        // PUT: api/Pubs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPub(int id, Pub pub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pub.ID)
            {
                return BadRequest();
            }

            db.Entry(pub).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PubExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pubs
        [ResponseType(typeof(Pub))]
        public IHttpActionResult PostPub(Pub pub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pub.Add(pub);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pub.ID }, pub);
        }

        // DELETE: api/Pubs/5
        [ResponseType(typeof(Pub))]
        public IHttpActionResult DeletePub(int id)
        {
            Pub pub = db.Pub.Find(id);
            if (pub == null)
            {
                return NotFound();
            }

            db.Pub.Remove(pub);
            db.SaveChanges();

            return Ok(pub);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PubExists(int id)
        {
            return db.Pub.Count(e => e.ID == id) > 0;
        }
    }
}