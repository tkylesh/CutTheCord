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
        public int Id { get; set; }

        public string Title { get; set; }
        public string PremierDate { get; set; }

        public string Status { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}