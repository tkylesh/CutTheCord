using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchImage
    {
        [JsonProperty("medium")]
        public string imageUrl { get; set; }

        public string original { get; set; }
    }
}