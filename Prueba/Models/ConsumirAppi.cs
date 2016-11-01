using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
namespace Prueba.Models
{
    public class ConsumirAppi
    {
       
        public static dynamic ConsumirGet(RestClient Rest,RestRequest Peticion)
        {
            var response = Rest.Execute(Peticion);
            return response;
        }
        public static dynamic ConsumirPost(RestClient Rest,RestRequest Peticion,dynamic objeto)
        {
             Peticion.AddJsonBody(objeto);
             var Response = Rest.Execute(Peticion);
             return Response;
        }

        public static dynamic Autenticacion(RestClient Rest, RestRequest Peticion, JObject datos)
        {
            Peticion.RequestFormat = DataFormat.Json;
            Peticion.AddParameter("application/javascript", datos.ToString(),ParameterType.RequestBody);
            var Response = Rest.Execute(Peticion).Content;
            return Response;
        }
      



        protected bool Validar(string token,string refresh_token)
        {


            return true;
        }


    }
}