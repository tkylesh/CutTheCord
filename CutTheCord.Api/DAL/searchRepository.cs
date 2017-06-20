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
        public IEnumerable<SearchShow> searchShows()
        {
            var client = new RestClient("http://api.tvmaze.com/search/shows?q=girls");
            var request = new RestRequest(Method.GET);

            var restResponse = client.Execute<List<SearchReturn>>(request);

            if (restResponse.StatusCode != HttpStatusCode.OK) yield return null;


            foreach (var item in restResponse.Data)
            {
                var s = new Show
                {
                    url = item.show.url,
                    name = item.show.name,
                    type = item.show.type,
                    status = item.show.status,
                    premiered = item.show.premiered,
                    officialSite = item.show.officialSite,
                    image = item.show.image != null ? item.show.image.imageUrl : "",
                    summary = item.show.summary,
                };

                yield return s;
            }
        }
    }
}