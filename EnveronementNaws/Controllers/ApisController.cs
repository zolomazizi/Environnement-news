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
    public class ApisController : ApiController
    {
        private NEWSEntities db = new NEWSEntities();

        // GET: api/Apis
        public IQueryable<Api> GetApi()
        {
            return db.Api;
        }

        // GET: api/Apis/5
        [ResponseType(typeof(Api))]
        public IHttpActionResult GetApi(int id)
        {
            Api api = db.Api.Find(id);
            if (api == null)
            {
                return NotFound();
            }

            return Ok(api);
        }

        // PUT: api/Apis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApi(int id, Api api)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != api.ID)
            {
                return BadRequest();
            }

            db.Entry(api).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApiExists(id))
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

        // POST: api/Apis
        [ResponseType(typeof(Api))]
        public IHttpActionResult PostApi(Api api)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Api.Add(api);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = api.ID }, api);
        }

        // DELETE: api/Apis/5
        [ResponseType(typeof(Api))]
        public IHttpActionResult DeleteApi(int id)
        {
            Api api = db.Api.Find(id);
            if (api == null)
            {
                return NotFound();
            }

            db.Api.Remove(api);
            db.SaveChanges();

            return Ok(api);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ApiExists(int id)
        {
            return db.Api.Count(e => e.ID == id) > 0;
        }
    }
}