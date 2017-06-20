using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.Models
{
    public class WebChannel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        //public SearchCountry2 country { get; set; }
    }
}