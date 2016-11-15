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
        [HttpPost]
        public IHttpActionResult ConsultarCargosPorConvocatoria(Convocatoria obj)
        {
            return Json(conv.ConsultarCargosPorConvocatoria(obj));
        }

        [HttpGet]
        public IHttpActionResult ConsultarConvocatoria()
        {
            return Json(conv.ConsultarConvocatoria());
        }
        public IHttpActionResult ConsultaConvocaotoriaPorFecha(Convocatoria obj)
        {
            return Json(conv.ConsultaConvocaotoriaPorFecha());
        }
        public IHttpActionResult ConsultarConvocatoriaPorNumero(Convocatoria obj)
        {
            return Json(conv.ConsultarConvocatoriaPorNumero(obj));
        }

        public IHttpActionResult InsertarConvocatoria(Convocatoria obj)
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
    