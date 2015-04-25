using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Data
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [AllowHtml]
        [Required]
        [DisplayName("Content")]
        public string Body { get; set; }

        [DisplayName("Created on")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Created { get; set; }

    }
}