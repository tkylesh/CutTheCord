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

        [Route("api/search")]
        [HttpGet]
        public IEnumerable<SearchShow> search()
        {
             return _searchRepository.searchShows().ToList();
        }
    }
}

