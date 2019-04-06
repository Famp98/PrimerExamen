using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrimerParcialAbril;
using PrimerParcialAbril.Models;

namespace PrimerParcialAbril.Controllers
{
    public class FabioMurguiaFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: FabioMurguiaFriends
        public ActionResult Index()
        {
            return View(db.FabioMurguiaFriends.ToList());
        }

        // GET: FabioMurguiaFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            if (fabioMurguiaFriend == null)
            {
                return HttpNotFound();
            }
            return View(fabioMurguiaFriend);
        }

        // GET: FabioMurguiaFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FabioMurguiaFriends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,Name,Type,Nickname,BirthDdate")] FabioMurguiaFriend fabioMurguiaFriend)
        {
            if (ModelState.IsValid)
            {
                db.FabioMurguiaFriends.Add(fabioMurguiaFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fabioMurguiaFriend);
        }

        // GET: FabioMurguiaFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            if (fabioMurguiaFriend == null)
            {
                return HttpNotFound();
            }
            return View(fabioMurguiaFriend);
        }

        // POST: FabioMurguiaFriends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,Name,Type,Nickname,BirthDdate")] FabioMurguiaFriend fabioMurguiaFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fabioMurguiaFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fabioMurguiaFriend);
        }

        // GET: FabioMurguiaFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            if (fabioMurguiaFriend == null)
            {
                return HttpNotFound();
            }
            return View(fabioMurguiaFriend);
        }

        // POST: FabioMurguiaFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FabioMurguiaFriend fabioMurguiaFriend = db.FabioMurguiaFriends.Find(id);
            db.FabioMurguiaFriends.Remove(fabioMurguiaFriend);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
