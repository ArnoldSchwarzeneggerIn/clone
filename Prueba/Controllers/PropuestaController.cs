using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class PropuestaController : ApiController
    {
        Propuesta prop = new Propuesta();
        public IHttpActionResult getPropuesta()
        {
            return null;
        }
    }
}
