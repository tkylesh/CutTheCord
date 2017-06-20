using CutTheCord.Api.DAL;
using CutTheCord.Api.DAL.Models;
using CutTheCord.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CutTheCord.Api.Controllers
{
    public class SearchController : ApiController
    {
        readonly searchRepository _searchRepository;

        public SearchController()
        {
            _searchRepository = new searchRepository();
        }

        [Route("api/search/{query}")]
        [HttpGet]
        public IEnumerable<SearchShow> search(string query)
        {
             return _searchRepository.searchShows(query).ToList();
        }
    }
}

