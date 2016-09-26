using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class InstanciaDetalleController : ApiController
    {
        InstanciaDetalle insd = new InstanciaDetalle();
        public IHttpActionResult getInstanciaDetalle()
        {
            //return Json(insd.);
            return null;
        }
    }
}
