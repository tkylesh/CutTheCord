using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchSchedule
    {
        public string time { get; set; }
        public List<object> days { get; set; }
    }
}