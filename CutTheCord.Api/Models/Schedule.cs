using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }
        public string time { get; set; }
        public List<object> days { get; set; }

        public virtual Show show { get; set; }
    }
}