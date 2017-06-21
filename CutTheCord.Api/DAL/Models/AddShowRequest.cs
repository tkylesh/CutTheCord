using CutTheCord.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CutTheCord.Api.DAL.Models
{
    public class AddShowRequest
    {
        public Show show { get; set; }
        public Member member { get; set; }
        public Schedule schedule { get; set; }
    }
}