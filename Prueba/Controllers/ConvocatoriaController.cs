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

        [HttpGet]
        public IHttpActionResult ConsultarConvocatoria()
        {
            return Json(conv.ConsultarConvocatoria());
        }

        [HttpGet]
        public IHttpActionResult ConsultarConvocatoriaNumero()
        {
            return Json(conv.ConsultarConvocatoriaNumero());
        }

        [HttpPost]
        public IHttpActionResult ConsultarConvocatoriaPorFecha(Convocatoria obj)
        {
            return Json(conv.ConsultarConvocatoriaPorFecha(obj));
        }

        [HttpPost]
        public IHttpActionResult ConsultarConvocatoriaPorNumero(Convocatoria obj)
        {
            return Json(conv.ConsultarConvocatoriaPorNumero(obj));
        }

        [HttpPost]
        public IHttpActionResult InsertarConvocatoria(Convocatoria obj)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (conv.InsertarConvocatoria(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }

            }
        }

        [HttpPost]
        public IHttpActionResult ModificarConvocatoria(Convocatoria obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (conv.ModificarConvocatoria(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }

            }
        }
    }
}
    