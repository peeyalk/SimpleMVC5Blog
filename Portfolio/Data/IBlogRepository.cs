using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public interface IBlogRepository
    {

        // get all the blogs
        IQueryable<Blog> getBlogs();

        // get blog by blog id
        Blog getBlogById(int Id);

        // add a blog
        bool AddBlog(Blog blog);

        // Save changes
        bool Save();

        // Edit changes
        bool Edit(Blog blog);

        // Delete a blog
        bool Delete(Blog blog); 

    }
}
