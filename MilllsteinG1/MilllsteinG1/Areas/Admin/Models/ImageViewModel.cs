using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilllsteinG1.Areas.Admin.Models
{
    public class ImageViewModel
    {
        [Required]
        public string Title { get; set; }

        public string AltText { get; set; }

        [DataType(DataType.Html)]
        public string Caption { get; set; }
        [Required]
        [DataType(DataType.Upload)]
       public HttpPostedFileBase ImageUpload { get; set; }
    }
}