using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class LoginController : ApiController
    {
        Login logi = new Login();
        [HttpPost]
        public IHttpActionResult ConsultarPermisos(Login obj)
        {
            return Json(logi.ConsultarPermisos(obj));
        }
        
        [HttpPost]
        public IHttpActionResult ConsultarPrograma(Login obj)
        {
            return Json(logi.ConsultarPrograma(obj));
        }
        [HttpPost]
        public IHttpActionResult ConsultarInstancia(Login obj)
        {
            return Json(logi.ConsultarInstancia(obj));
        }

        [HttpPost]
        public IHttpActionResult ConsultarDatos(Login obj)
        {
            return Json(logi.ConsultarDatos(obj));
        }

        [HttpPost]
        public IHttpActionResult ConsultarRol(Login obj)
        {
            return Json(logi.ConsultarRol(obj));
        }
    }

}
