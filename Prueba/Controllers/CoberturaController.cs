using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CoberturaController : ApiController
    {
        Cobertura cobe = new Cobertura();
        public IHttpActionResult getCobertura()
        {
            return Json(cobe.Consultar());
        }
    }
}
