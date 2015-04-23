using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _repo;

        public BlogController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {

            var blogs = _repo.getBlogs();
            return View(blogs);
        }
    }
}