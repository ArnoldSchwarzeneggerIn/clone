using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CausaRetiroController : ApiController
    {
        CausaRetiro caur = new CausaRetiro();
        [HttpGet]
        public IHttpActionResult ConsultarCausaRetiro()
        {
            return Json(caur.ConsultarCausaRetiro());
        }
        [HttpPost]
        public IHttpActionResult InsertarCausaRetiro(CausaRetiro obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (caur.InsertarCausaRetiro(obj))
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
        public IHttpActionResult ModificarCausaRetiro(CausaRetiro obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else {
                if (caur.ModificarCausaRetiro(obj))
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

