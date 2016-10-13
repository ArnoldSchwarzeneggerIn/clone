using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class InstanciaDetalleController : ApiController
    {
        InstanciaDetalle insd = new InstanciaDetalle();
        public IHttpActionResult getInstanciaDetalle()
        {
            //return Json(insd.);
            return null;
        }

        [HttpPost]
        public IHttpActionResult ConsultarCargosInstancia(InstanciaDetalle obj)
        {

            return Json(insd.ConsultarCargosInstancia(obj));
                    
        }


        [HttpPost]
        public IHttpActionResult InsertarInstanciaDetalle(InstanciaDetalle obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (insd.InsertarInstanciaDetalle(obj))
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

        [HttpPut]
        public IHttpActionResult ModificarInstanciaDetalle(InstanciaDetalle obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (insd.ModificarInstanciaDetalle(obj))
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
