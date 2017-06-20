using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft;
using CutTheCord.Api.Models;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchReturn
    {
        public double score { get; set; }
        public SearchShow show { get; set; }

    }
}