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

        Requisito requ = new Requisito();
        public IHttpActionResult ConsultarPorInstanciaDetalle(Requisito obj)
        {
          return  Json(requ.ConsultarPorInstanciaDetalle(obj));
        }
    }
}
