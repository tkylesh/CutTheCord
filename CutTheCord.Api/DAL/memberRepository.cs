using CutTheCord.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL
{
    public class memberRepository
    {
        readonly ApplicationDbContext _context;

        public memberRepository()
        {
            _context = new ApplicationDbContext();
        }

        public bool addMember(Member member)
        {

            var AddMember = new Member
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Email = member.Email,
                ApplicationUser = _context.Users.Where(u => u.Email == member.Email).FirstOrDefault()
            };

            try
            {
                _context.Members.Add(AddMember);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}