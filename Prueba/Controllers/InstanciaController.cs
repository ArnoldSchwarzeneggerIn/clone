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
            return Json(inst.ConsultarInstancia());
        }

        [HttpGet]
        public IHttpActionResult ConsultarInstanciaNombre()
        {
            return Json(inst.ConsultarInstanciaNombre());
        }

        [HttpPost]
        public IHttpActionResult ConsultarInstanciaPorPalabras(Instancia obj)
        {
            return Json(inst.ConsultarPorPalabras(obj));
        }

        [HttpPost]
        public IHttpActionResult InsertarInstancia(Instancia obj)
        {
            return Json(inst.InsertarInstancia(obj));
        }

        [HttpPost]
        public IHttpActionResult ModificarInstancia(Instancia obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (inst.ModificarInstancia(obj))
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


        

        //[HttpGet]
        //public IHttpActionResult ConsultarInstanciaConvocatoria(Convocatoria obj)
        //{
        //    return Json(inst.Consultar(obj));
        //}




    }
}
