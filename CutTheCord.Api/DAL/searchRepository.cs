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
                var s = new SearchShow
                {
                    id = item.show.id,
                    url = item.show.url,
                    name = item.show.name,
                    type = item.show.type,
                    language = item.show.language,
                    genres = item.show.genres,
                    status = item.show.status,
                    runtime = item.show.runtime,
                    premiered = item.show.premiered,
                    officialSite = item.show.officialSite,
                    schedule = item.show.schedule,
                    rating = item.show.rating,
                    weight = item.show.weight,
                    network = item.show.network,
                    webChannel = item.show.webChannel,
                    externals = item.show.externals,
                    image = item.show.image,
                    summary = item.show.summary,
                    updated = item.show.updated,
                    _links = item.show._links
                };

                yield return s;
            }
        }
    }
}