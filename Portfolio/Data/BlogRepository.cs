using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public Blog getBlogById(int Id)
        {
            return _BlogContext.Blogs.Find(Id);
        }

        /// <summary>
        /// Adding a blog to database.
        /// </summary>
        /// <param name="blog">a blog from controller</param>
        /// <returns>return true if successfully added, else return false</returns>
        public bool AddBlog(Blog blog)
        {
            try
            {
                _BlogContext.Blogs.Add(blog);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Save any changes to the blog.
        /// </summary>
        /// <returns>true if save successfuly</returns>
        public bool Save()
        {
            try
            {
                return _BlogContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Delete a single blog from database.
        /// </summary>
        /// <returns>return true if successfully deleted.</returns>
        public bool Delete(Blog blog)
        {
            try
            {
                _BlogContext.Blogs.Remove(blog);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Edit a blog
        /// </summary>
        /// <param name="blog"></param>
        /// <returns>return true if successfully edited</returns>
        public bool Edit(Blog blog)
        {
            try
            {
                _BlogContext.Entry(blog).State = EntityState.Modified;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

    }
}