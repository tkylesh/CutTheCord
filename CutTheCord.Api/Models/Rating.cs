using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.Models
{
    public class Rating
    {
        [Key]
        public int id { get; set; }
        public double? average { get; set; }

        public virtual Show show { get; set; }
    }
}