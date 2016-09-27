using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CoberturaController : ApiController
    {
        Cobertura cobe = new Cobertura();
        [HttpGet]
        public IHttpActionResult ConsultarCobertura()
        {
            return Json(cobe.ConsultarCobertura());
        }

        [HttpPost]
        public IHttpActionResult InsertarCobertura(Cobertura obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (cobe.InsertarCobertura(obj))
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
        public IHttpActionResult ModificarCobertura(Cobertura obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (cobe.ModificarCobertura(obj))
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
