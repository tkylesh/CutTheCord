using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class SearchNetwork
    {
        [JsonProperty("id")]
        public int networkId { get; set; }
        [JsonProperty("name")]
        public string networkName { get; set; }
        public SearchCountry country { get; set; }

    }
}