using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doge.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        [Display(Name = "Photo Url")]
        public string Url { get; set; }
    }
}