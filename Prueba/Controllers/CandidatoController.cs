using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class CandidatoController : ApiController


    {

        Candidato cand = new Candidato();
        //Convocatoria conv = new Convocatoria();
        //[HttpGet]
        //public IHttpActionResult ConsultarCandidato(Convocatoria convo)
        //{
        //    return Json(conv.ConsConsultarCandidato())));
        //}

        //[HttpPost]
        //public IHttpActionResult InsertarCandidato(Candidato obj)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    else
        //    {
        //        if (cand.InsertarCandidato(obj))
        //        {
        //            return Json(new
        //            {
        //                data = obj,
        //                result = true
        //            });
        //        }
        //        else
        //        {
        //            return Json(new
        //            {
        //                result = false
        //            });
        //        }
        //    }
        //}
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

        //public static DataTable ConsultarRol(Loggin log)
        //{
        //    return Conexion.ConsultarConParametros("PR_PERSONAROL", "CR_ROL", log.ConsultarInstancia());
        //}


    }
}

