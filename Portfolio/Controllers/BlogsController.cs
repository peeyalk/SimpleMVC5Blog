using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [Authorize(Roles="Admin")]
    public class BlogsController : Controller
    {

        private IBlogRepository _db;

        public BlogsController(IBlogRepository db)
        {
            _db = db;
        }

        // GET: Blogs
        [AllowAnonymous]
        public ActionResult Index()
        {
            var blogs = _db.getBlogs();

            return View(blogs);
        }

        // GET: Blogs/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = _db.getBlogById((int)id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Body,Created")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (_db.AddBlog(blog) && _db.Save())
                {
                    return RedirectToAction("Index");
                }
            }
            return View(blog);
        }

        // GET: Blogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = _db.getBlogById((int)id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Title,Body,Created")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (_db.Edit(blog) && _db.Save())
                {
                    return RedirectToAction("Index");
                }
            }
            return View(blog);
        }

        // GET: Blogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = _db.getBlogById((int)id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = _db.getBlogById(id);
            if (_db.Delete(blog) && _db.Save())
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
