using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnydeWebService.Request
{
    public class RegisterToGameRequest
    {
        public string Name { get; set; }

        public Guid PersonId { get; set; }

        public Guid GameId { get; set; }
    }
}