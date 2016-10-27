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


        public static dynamic Autenticacion(RestClient Rest, RestRequest Peticion, dynamic objeto)
        {
            Peticion.RequestFormat = DataFormat.Json;
            Peticion.AddBody(new { grant_type = "authorization_code",code= "w59r3y9s16057802359", redirect_uri = "http://191.102.85.226/electoral/views/index.aspx", client_id = "503998150027", client_secret = "xlo1nmj9e5pldnq7g89rzdvw8q7r4g", state = "cyz" });
            var Response = Rest.Execute(Peticion);
            return Response;
        }


    }
}