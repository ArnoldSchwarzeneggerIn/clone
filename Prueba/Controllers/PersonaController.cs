using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class PersonaController : ApiController
    {
        Persona per = new Persona();



        [HttpGet]

        public IHttpActionResult Consultarpersona()
        {
            return Json(per.ConsultarPersonaJurado());
        }
    }
}
