using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doge.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage ="a title is required"), MaxLength(60), MinLength(2)]
        public string Title { get; set; }

        [Required(ErrorMessage ="a rating is required"),Range(0,10)]
        public double Rating { get; set; }

        [MaxLength(30), MinLength(2)]
        public string Country { get; set; }

        [Required(ErrorMessage = "a production year is required")]
        [Display(Name ="Year")]
        public DateTime ProductionYear { get; set; }

        [Required(ErrorMessage = "a duration is required")]
        [Range(0,1200)]
        public int Duration { get; set; }

        [Display(Name ="Image")]
        public string PhotoUrl { get; set; }

        [Display(Name ="Trailer")]
        public string TrailerUrl { get; set; }

        public double? Price { get; set; } //nullable

        [Required(ErrorMessage = "this is required")]
        [Display(Name ="I've seen it")]
        public bool Viewed { get; set; } //checkbox
    }
}