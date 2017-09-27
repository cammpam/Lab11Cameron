using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11Cameron.Controllers
{
    [Route("Error")]
    public class ErrorController
    {
        [Route("Help")]
        public string Index()
        {
            return "Sorry, but there's been an error.";
        }
    }
}
