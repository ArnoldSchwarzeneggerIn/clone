using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class JuradosController : ApiController
    {
        Jurado jura = new Jurado();
        [HttpPost]
        public IHttpActionResult ConsultarJuradoConvocatoria(Convocatoria obj)
        {
            return Json(jura.ConsultarJurados(obj));
        }
        [HttpPost]
        public IHttpActionResult InsertarJurados(Jurado obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (jura.InsertarJurados(obj))
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
                        data = obj,
                        result = false
                    });
                }
            }
        }

      
    }
}
