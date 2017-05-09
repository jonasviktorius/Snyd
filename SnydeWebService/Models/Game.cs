using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace SnydeWebService.Controllers
{
    public class Game
    {
        public Guid GameId { get; set; }

        public List<Person> Participants { get; set; }

        public int RoundNumber { get; set; }

        public Person RoundLoser { get; set; }
    }
}