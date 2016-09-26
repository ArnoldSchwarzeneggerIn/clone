using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class ConvocatoriaController : ApiController
    {
        Convocatoria conv = new Convocatoria();
        public IHttpActionResult getConvocatoria()
        {
          return Json(conv.Agregar());
        }
        public IHttpActionResult ConsultarInstanciaConvocatoria(Convocatoria convo )
        {
            return Json( conv.ConsultaPorId());
        }


    }
}
