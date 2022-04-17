using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ourfitnessplan.Models;

namespace ourfitnessplan.Areas.Admin.Controllers
{
    public class BlogpostController : Controller
    {
        private usersContext db = new usersContext();

        // GET: Admin/Blogpost
        //public ActionResult Index()
        //{
        //    return View(db.tbl_Posts.ToList());
        //}

        public ActionResult Index(int page = 1, string sort = "FirstName", string sortdir = "asc", string search = "")
        {
            int pageSize = 10;
            int totalRecord = 0;
            if (page < 1) page = 1;
            int skip = (page * pageSize) - pageSize;
            var data = GetPosts(search, sort, sortdir, skip, pageSize, out totalRecord);
            ViewBag.TotalRows = totalRecord;
            ViewBag.search = search;
            return View(data);
        }


        public List<tbl_posts> GetPosts(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecord)
        {
           
             
                var v = db.tbl_Posts.Where(
                                    a => a.aurthor.Contains(search) ||
                                  a.title.Contains(search) ||
                                  a.content.Contains(search) ||
                                  a.category.Contains(search)

                );
                totalRecord = v.Count();
            v.OrderBy(a => a.aurthor);
              //  v = v.OrderBy(sort);
             //   v = v.OrderBy(sort + " " + sortdir);
            

                if (pageSize > 0)
                {
                v = v.OrderBy(a => a.aurthor).Skip(skip).Take(pageSize);
                  //  v = v.Skip(skip).Take(pageSize);
                }
                return v.ToList();
            
        }





        // GET: Admin/Blogpost/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_posts tbl_posts = db.tbl_Posts.Find(id);
            if (tbl_posts == null)
            {
                return HttpNotFound();
            }
            return View(tbl_posts);
        }

        // GET: Admin/Blogpost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Blogpost/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,blogid,title,content,tags,aurthor,CreatedOn,lastUpdated,deleteStatus")] tbl_posts tbl_posts, FormCollection content)
        {
            if (ModelState.IsValid)
            {
                tbl_posts.CreatedOn = DateTime.Now;
                tbl_posts.lastUpdated = DateTime.Now;
                db.tbl_Posts.Add(tbl_posts);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_posts);
        }

        // GET: Admin/Blogpost/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_posts tbl_posts = db.tbl_Posts.Find(id);
            if (tbl_posts == null)
            {
                return HttpNotFound();
            }
            return View(tbl_posts);
        }

        // POST: Admin/Blogpost/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,blogid,title,content,tags,aurthor,CreatedOn,lastUpdated,deleteStatus")] tbl_posts tbl_posts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_posts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_posts);
        }

        // GET: Admin/Blogpost/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_posts tbl_posts = db.tbl_Posts.Find(id);
            if (tbl_posts == null)
            {
                return HttpNotFound();
            }
            return View(tbl_posts);
        }

        // POST: Admin/Blogpost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_posts tbl_posts = db.tbl_Posts.Find(id);
            db.tbl_Posts.Remove(tbl_posts);
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
