using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.Models
{
    public class Show
    {
        [Key]
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<string> genres { get; set; }
        public string status { get; set; }
        public int? runtime { get; set; }
        public string premiered { get; set; }
        public string officialSite { get; set; }
        public Schedule schedule { get; set; }
        public Rating rating { get; set; }
        public Network network { get; set; }
        public WebChannel webChannel { get; set; }
        public string image { get; set; }
        public string summary { get; set; }
        public int updated { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}