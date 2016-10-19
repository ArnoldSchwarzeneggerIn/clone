using Prueba.Conexions;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class FechaController : ApiController
    {

        Conexion conx = new Conexion();
        Fecha fech = new Fecha();

        [HttpGet]
        public IHttpActionResult ConsultarFecha()
        {

            return Json(fech.ConsultarFecha());
        }

    }
}
