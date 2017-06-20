using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchShow
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public List<string> genres { get; set; }
        public string status { get; set; }
        public int? runtime { get; set; }
        public string premiered { get; set; }
        public string officialSite { get; set; }
        public SearchSchedule schedule { get; set; }
        public SearchRating rating { get; set; }
        public int weight { get; set; }
        public SearchNetwork network { get; set; }
        public SearchWebChannel webChannel { get; set; }
        public SearchExternals externals { get; set; }
        public SearchImage image { get; set; }
        public string summary { get; set; }
        public int updated { get; set; }
        public SearchLinks _links { get; set; }

    }
}