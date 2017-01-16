using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace Prueba.Models
{
    public static class Rutas
    {
        public static RestClient Convocatoria = new RestClient("http://191.102.85.226/Electoralapi/api/convocatoria/");
        public static RestClient Cobertura = new RestClient("http://191.102.85.226/Electoralapi/api/cobertura/");
        public static RestClient Instancia = new RestClient("http://191.102.85.226/Electoralapi/api/instancia/");
        public static RestClient InstanciaConformacion = new RestClient("http://191.102.85.226/Electoralapi/api/instanciaconformacion/");
        public static RestClient CausaRetiro = new RestClient("http://191.102.85.226/Electoralapi/api/causaretiro/");
        public static RestClient InstaciaDetalle = new RestClient("http://191.102.85.226/Electoralapi/api/InstanciaDetalle/");
        public static RestClient Jurado = new RestClient("http://191.102.85.226/Electoralapi/api/jurados");
        public static RestClient Autenticacion = new RestClient("http://chaira.udla.edu.co/api/v0.1/");
        public static RestClient Persona = new RestClient("http://191.102.85.226/Electoralapi/api/persona");
        public static RestClient Requisito = new RestClient("http://191.102.85.226/Electoralapi/api/Requisito/");
       
    }
}