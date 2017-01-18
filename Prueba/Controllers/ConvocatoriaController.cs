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
        public IHttpActionResult CNmroCnvt(Convocatoria obj)
        {
            return Json(conv.CNmroCnvt(obj));
        }

        [HttpPost]
        public IHttpActionResult CCnvt(Convocatoria obj)
        {
            return Json(conv.CCnvt(obj));
        }




        [HttpPost]
        public IHttpActionResult CInstCnvt(Convocatoria obj)
        {
            return Json(conv.CInstCnvt(obj));
        }


        [HttpPost]
        public IHttpActionResult CInsdCnvt(Convocatoria obj)
        {
            return Json(conv.CInsdCnvt(obj));
        }


        [HttpPost]
        public IHttpActionResult VotacionConvocatoria(Convocatoria obj)
        {
            return Json(conv.VotacionConvocatoria(obj));
        }


        [HttpPost]
        public IHttpActionResult ConsultarCargosPorConvocatoria(Convocatoria obj)
        {
            return Json(conv.ConsultarCargosPorConvocatoria(obj));
        }


        // Consultar tods los cargos de todas instancia que se pueden elejir
        [HttpGet]
        public IHttpActionResult CCrgsInst()
        {
            return Json(conv.CCrgsInst());
        }

        [HttpPost]
        public IHttpActionResult CCnvtE(Convocatoria obj)
        {
            return Json(conv.CCnvtE(obj));
        }

        [HttpPost]
        public IHttpActionResult ConsultaConvocaotoriaPorFecha(Convocatoria obj)
        {
            return Json(conv.ConsultaConvocaotoriaPorFecha());
        }

        [HttpPost]
        public IHttpActionResult ConsultarConvocatoriaPorNumero(Convocatoria obj)
        {
            return Json(conv.ConsultarConvocatoriaPorNumero(obj));
        }

        [HttpPost]
        //insertar convocatoria
        public IHttpActionResult ICnvt(Convocatoria obj)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (conv.ICnvt(obj))
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
        public IHttpActionResult MCnvt(Convocatoria obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (conv.MCvnt(obj))
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


        public IHttpActionResult MECnvt(Convocatoria obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (conv.MECnvt(obj))
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
    