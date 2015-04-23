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

        /// <summary>
        /// return all the blogs.
        /// </summary>
        /// <returns>a list of bog that is queryable</returns>
        public IQueryable<Blog> getBlogs()
        {
            return _BlogContext.Blogs;
        }

        /// <summary>
        /// return a blog based on the blog id.
        /// </summary>
        /// <param name="blogId">blog id</param>
        /// <returns>return a single blog</returns>
        public Blog getBlogById(int blogId)
        {
            return _BlogContext.Blogs.Find(blogId);
        }

        /// <summary>
        /// Save any changes to the blog.
        /// </summary>
        /// <returns></returns>
        bool IBlogRepository.Save()
        {
            return _BlogContext.SaveChanges() > 0;
        }
    }
}