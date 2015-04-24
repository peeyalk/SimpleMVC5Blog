using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Data
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Content")]
        public string Body { get; set; }

        [DisplayName("Created on")]
        public DateTime Created { get; set; }

    }
}