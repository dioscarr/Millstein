﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MilllsteinG1.Areas.Admin.Models
{
    public class Image
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string AltText { get; set; }

    [DataType(DataType.Html)]
    public string Caption { get; set; }

    [Required]
    [DataType(DataType.ImageUrl)]
    public string ImageUrl { get; set; }
    [Required]
    private DateTime? createdDate;
    
    [DataType(DataType.DateTime)]
    public DateTime CreatedDate
    {
        get { return createdDate ?? DateTime.UtcNow; }
        set { createdDate = value; }
    }
}


  
}