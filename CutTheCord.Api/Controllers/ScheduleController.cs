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
    public class ScheduleController : ApiController
    {
        readonly showRepository _showRepo;
        readonly memberRepository _memberRepo;
        readonly ApplicationDbContext _context;

        public ScheduleController()
        {
            _showRepo = new showRepository();
            _memberRepo = new memberRepository();
            _context = new ApplicationDbContext();
        }

        [Route("api/schedule")]
        [HttpPost]
        public bool AddSchedule(AddShowRequest request)
        {
            var member = _context.Members.SingleOrDefault(m => m.Id == request.member.Id);
            var show = _context.Shows.FirstOrDefault(s => s.name == request.show.name);

            if (show != null)
            {
                member.schedules.Add(request.schedule);

                _context.Members.Attach(member);
                _context.Shows.Attach(show);

                _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                _context.Entry(show).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        [Route("api/schedule/{memberId}")]
        [HttpGet]
        public IEnumerable<Schedule> GetByMember(int memberId)
        {
            var member = _context.Members.Find(memberId);

            return member.schedules;
        }
    }
}
