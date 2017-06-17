using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using CutTheCord.Api.Models;
using CutTheCord.Api.DAL.Models;
using System.Net;

namespace CutTheCord.Api.DAL
{
    public class searchRepository
    {
        public IEnumerable<Show> searchShows()
        {
            var client = new RestClient("http://api.tvmaze.com/search/shows?q=girls");
            var request = new RestRequest(Method.GET);

            var restResponse = client.Execute<List<SearchReturn>>(request);

            if (restResponse.StatusCode != HttpStatusCode.OK) yield return null;

            foreach (var item in restResponse.Data)
            {
                var s = new Show

                {
                    Title = item.show.name,
                    PremierDate = item.show.premiered,
                    Status = item.show.status
                };

                yield return s;
            }
        }
    }
}