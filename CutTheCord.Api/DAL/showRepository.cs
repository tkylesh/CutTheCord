using CutTheCord.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL
{
    public class showRepository
    {
        readonly ApplicationDbContext _context;

        public showRepository()
        {
            _context = new ApplicationDbContext();
        }

        public bool addShow(Show show)
        {
            try
            {
                _context.Shows.Add(show);
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