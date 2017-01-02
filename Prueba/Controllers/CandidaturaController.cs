using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CandidaturaController : ApiController


    {

        Candidatura cand = new Candidatura();
        //Convocatoria conv = new Convocatoria();
        //[HttpGet]
        //public IHttpActionResult ConsultarCandidato(Convocatoria convo)
        //{
        //    return Json(conv.ConsConsultarCandidato())));
        //}

        [HttpPost]
        public IHttpActionResult InsertarCandidatura(Candidatura obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (cand.InsertarCandidadatura(obj))
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
        public IHttpActionResult ModificarCandidatura(Candidatura obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (cand.ModificarCandidadatura(obj))
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
        public IHttpActionResult ConsultarCandidatos(Candidatura obj)
        {
            return Json(cand.ConsultarCandidatos(obj));
        }

        //public DataTable ConsultarPrograma(Loggin log)
        //{
        //    return Conexion.ConsultarConParametros("PR_CONSULTARPROGRAMA", "CR_CONSP", log.ConsultarInstancia());
        //}

        //public DataTable ConsultarInstancia(Loggin LOG)
        //{
        //    return Conexion.ConsultarConParametros("PR_CONSULTARREPRESENTANE", "CR_REPRESENTANTE", LOG.ConsultarInstancia());
        //}

        //public DataTable ConsultarDatos(Loggin log)
        //{
        //    return Conexion.ConsultarConParametros("PR_CONSULTARDATOS", "CR_DATOSPER", log.ConsultarInstancia());
        //}
        //public int InsertarCandidato(Candidato cand)
        //{
        //    return Conexion.Operacion2("PR_REGISTRARCANDIDATO", cand.InsertarCandidato());
        //}
        //public DataTable ListarCandidatos(Convocatoria conv)
        //{
        //    return Conexion.ConsultarConParametros("PR_CONSULTARCANDIDATOS", "p_recordset", conv.ConsultaPorId());
        //}




    }
}

