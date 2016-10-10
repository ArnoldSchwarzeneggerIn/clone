using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class ConsumirAppi
    {
        public ConsumirAppi()
        {

        }
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

    }
}