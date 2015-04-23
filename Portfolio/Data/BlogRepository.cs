using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Data
{
    public class BlogRepository : IBlogRepository
    {

        private ApplicationDbContext _BlogContext;

        public BlogRepository(ApplicationDbContext BlogContext)
        {
            _BlogContext = BlogContext;
        }

        public IQueryable<Blog> getBlogs()
        {
            return _BlogContext.Blogs;
        }

        public void Save()
        {
            _BlogContext.SaveChanges();
        }
    }
}