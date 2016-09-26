using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class InstanciaConformacionController : ApiController
    {
        InstanciaConformacion insc = new InstanciaConformacion();
        public IHttpActionResult getInstanciaConformacion()
        {
            //return Json();
            return null;
        }
    }
}
