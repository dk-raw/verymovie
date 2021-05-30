using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doge.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required(ErrorMessage = "a title is required"), MaxLength(20), MinLength(2)]
        [Display(Name = "Genre")]
        public string GTitle { get; set; }
    }
}