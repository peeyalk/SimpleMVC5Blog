using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public interface IBlogRepository
    {
        IQueryable<Blog> getBlogs();

        void Save();
    }
}
