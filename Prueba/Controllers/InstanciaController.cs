using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class InstanciaController : ApiController
    {
        Instancia inst = new Instancia();

        [HttpGet]
        public IHttpActionResult ConsultarInstancia()
        {
            return Json(inst.Consultar());
        }

        [HttpGet]
        public IHttpActionResult ConsultarInstanciaNombre()
        {
            return Json(inst.ConsultarNombre());
        }

        [HttpPost]
        public IHttpActionResult ConsultarInstanciaPorPalabras(Instancia insta)
        {
            return Json(inst.ConsultarPorPalabras(insta));
        }
        public IHttpActionResult getInstanciaConvocatoria(Convocatoria convo)
        {
            return Json(inst.Consultar());
        }
        public IHttpActionResult getInstancia(Instancia insta)
        {
            return Json(inst.Consultar());
        }
       

    }
}
