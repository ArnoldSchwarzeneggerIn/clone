using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CausaRetiroController : ApiController
    {
        CausaRetiro caur = new CausaRetiro();
        public IHttpActionResult getCausaRetiro()
        {
            return Json(caur.Consultar());
        }
    }
}
