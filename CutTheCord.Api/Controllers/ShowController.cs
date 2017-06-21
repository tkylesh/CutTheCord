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
    public class ShowController : ApiController
    {
        readonly showRepository _showRepo;
        readonly memberRepository _memberRepo;
        readonly ApplicationDbContext _context;

        public ShowController()
        {
            _showRepo = new showRepository();
            _memberRepo = new memberRepository();
            _context = new ApplicationDbContext();
        }

        [Route("api/show")]
        [HttpPost]
        public bool Add(AddShowRequest request)
        {
            var member = _context.Members.SingleOrDefault(m => m.Id == request.member.Id);

            if (member != null)
            {
                try
                {
                    member.Shows.Add(request.show);                    
                    _context.Members.Attach(member);
                    _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        [Route("api/show/{memberId}")]
        [HttpGet]
        public IEnumerable<Show> GetShowsByMember(int memberId)
        {
            var member = _context.Members.Find(memberId);
            return member.Shows;
        }

    }
}
