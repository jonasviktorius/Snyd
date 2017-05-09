using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SnydeWebService.Models;

namespace SnydeWebService.Controllers
{
    public class Person
    {
        public Guid PersonId { get; set; }

        public string Name { get; set; }

        public Cup Cup { get; set; }

        public List<Game> PreviousGames { get; set; }
    }
}