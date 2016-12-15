using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class RequisitoController : ApiController
    {
        Requisito req = new Requisito();

        [HttpPost]
        public IHttpActionResult ConsultarPorInsd(Requisito obj)
        {
            return Json(req.ConsultarPorInstanciaDetalle());
        }

    }
}
