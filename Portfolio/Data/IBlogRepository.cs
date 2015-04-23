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
        Blog getBlogById(int blogId);

        // Save changes
        bool Save();
    }
}
