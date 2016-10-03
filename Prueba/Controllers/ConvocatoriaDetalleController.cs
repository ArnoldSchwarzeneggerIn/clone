using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class ConvocatoriaDetalleController : ApiController
    {
        ConvocatoriaDetalle cond = new ConvocatoriaDetalle();
        [HttpGet]
        //public IHttpActionResult ConsultarDetalleConvocatoria()
        //{
        //    return cond.ConsultarConvocatoriaDetalle();
        //}

        [HttpPost]
        public IHttpActionResult InsertarDetalleConvocatoria()
        {
            return null;
        }
    }
}
