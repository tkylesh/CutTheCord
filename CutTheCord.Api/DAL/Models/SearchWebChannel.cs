using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchWebChannel
    {
        public int id { get; set; }
        public string name { get; set; }
        public SearchCountry2 country { get; set; }
    }
}