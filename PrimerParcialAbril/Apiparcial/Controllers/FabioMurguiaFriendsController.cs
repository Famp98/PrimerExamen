using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Apiparcial.Models;

namespace Apiparcial.Controllers
{
    public class FabioMurguiaFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/FabioMurguiaFriends
        public IQueryable<FabioMurguiaFriend> GetFabioMurguiaFriends()
        {
            return db.FabioMurguiaFriends;
        }

        // GET: api/FabioMurguiaFriends/5
        [ResponseType(typeof(FabioMurguiaFriend))]
        public IHttpActionResult GetFabioMurguiaFriend(int id)
        {
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            if (fabioMurguiaFriend == null)
            {
                return NotFound();
            }

            return Ok(fabioMurguiaFriend);
        }

        // PUT: api/FabioMurguiaFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFabioMurguiaFriend(int id, FabioMurguiaFriend fabioMurguiaFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fabioMurguiaFriend.FriendId)
            {
                return BadRequest();
            }

            db.Entry(fabioMurguiaFriend).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FabioMurguiaFriendExists(id))
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

        // POST: api/FabioMurguiaFriends
        [ResponseType(typeof(FabioMurguiaFriend))]
        public IHttpActionResult PostFabioMurguiaFriend(FabioMurguiaFriend fabioMurguiaFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FabioMurguiaFriends.Add(fabioMurguiaFriend);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fabioMurguiaFriend.FriendId }, fabioMurguiaFriend);
        }

        // DELETE: api/FabioMurguiaFriends/5
        [ResponseType(typeof(FabioMurguiaFriend))]
        public IHttpActionResult DeleteFabioMurguiaFriend(int id)
        {
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            if (fabioMurguiaFriend == null)
            {
                return NotFound();
            }

            db.FabioMurguiaFriends.Remove(fabioMurguiaFriend);
            db.SaveChanges();

            return Ok(fabioMurguiaFriend);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FabioMurguiaFriendExists(int id)
        {
            return db.FabioMurguiaFriends.Count(e => e.FriendId == id) > 0;
        }
    }
}