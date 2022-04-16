using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using ourfitnessplan.Models;
using static System.Net.WebRequestMethods;

namespace ourfitnessplan.Areas.Admin.Controllers
{
    public class usersController : Controller
    {
        private usersContext db = new usersContext();

        // GET: Admin/users
        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        // GET: Admin/users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // GET: Admin/users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Email,Password,Confirm_password,User_status,image_path")] users users, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {

                    string dir = "~/Content/usersProfile";
                    //if (!Directory.Exists(dir)) {
                    // //   Directory.SetAccessControl(dir, FileSystemRights.ReadData, AccessControlType.Allow);
                    //    AddDirectorySecurity(dir, @"MYDOMAIN\MyAccount", FileSystemRights.Write, AccessControlType.Allow);

                    //    Directory.CreateDirectory(dir);
                    //}
                    string path = Path.Combine(Server.MapPath(dir), Path.GetFileName(image.FileName));
                    image.SaveAs(path);
                    users.image_path = path;

                }
                else {
                    users.image_path = Server.MapPath("~/Content/usersProfile/dummy.jpg").ToString();
                }
                //   users.image_path = form["image_path"];
               
                db.users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }
      

        // GET: Admin/users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Admin/users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Email,Password,Confirm_password,User_status,image_path")] users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        // GET: Admin/users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Admin/users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            users users = db.users.Find(id);
            db.users.Remove(users);
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
