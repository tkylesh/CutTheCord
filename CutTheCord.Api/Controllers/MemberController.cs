using CutTheCord.Api.DAL;
using CutTheCord.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CutTheCord.Api.Controllers
{
    public class MemberController : ApiController
    {
        readonly memberRepository _memberRepo;
        
        public MemberController()
        {
            _memberRepo = new memberRepository();
        }

        [Route("api/member")]
        [HttpPost]
        public bool Add(Member member)
        {
            return _memberRepo.addMember(member);
        }

        [Route("api/member")]
        [HttpGet]
        public Member Get(string email)
        {
            return _memberRepo.getMember(email);
        }
    }
}
