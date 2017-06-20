using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchLinks
    {
        public SearchSelf self { get; set; }
        public SearchPreviousEpisode previousepisode { get; set; }
        public SearchNextEpisode nextepisode { get; set; }
    }
}