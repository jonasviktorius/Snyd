using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnydeWebService.Request
{
    public class CreateGameRequest
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
    }
}