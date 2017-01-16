using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Prueba.Utileria
{
    public class ConsumirAppi
    {
       
        public static dynamic ConsumirGet(RestClient Rest,RestRequest Peticion)
        {
            var response =Rest.Execute(Peticion);
            return response;
        }
        public static dynamic ConsumirPost(RestClient Rest,RestRequest Peticion,dynamic objeto)
        {
             Peticion.AddJsonBody(objeto);
             var Response = Rest.Execute(Peticion);
             return Response;
        }

        //public static dynamic ConsumirPost(RestClient Rest, RestRequest Peticion, dynamic objeto, dynamic objeto2)
        //{
        //    Peticion.AddJsonBody(objeto);
        //    Peticion.AddJsonBody(objeto2);
        //    var Response = Rest.Execute(Peticion);
        //    return Response;
        //}
        public static dynamic Autenticacion(RestClient Rest, RestRequest Peticion, string code)
        {

            JObject datos = new JObject();
            datos.Add("grant_type", "authorization_code");
            datos.Add("code",code );
            datos.Add("redirect_uri", "http://191.102.85.226/electoral/views/index.aspx");
            datos.Add("client_id", "503998150027");
            datos.Add("client_secret", "xlo1nmj9e5pldnq7g89rzdvw8q7r4g");
            datos.Add("state", "cyz");
            Peticion.RequestFormat = DataFormat.Json;
            Peticion.AddParameter("application/javascript", datos.ToString(),ParameterType.RequestBody);
            var Response = Rest.Execute(Peticion).Content;
            return Response;
        }
        public static dynamic Scope(RestClient Rest, RestRequest Peticion, string scope)
        {
            JObject datos = new JObject();
            datos.Add("access_token",HttpContext.Current.Session["Token"].ToString());
            datos.Add("scope", scope);
            Peticion.RequestFormat = DataFormat.Json;
            Peticion.AddParameter("application/javascript", datos.ToString(), ParameterType.RequestBody);
            var Response = Rest.Execute(Peticion).Content;
            return Response;
        }

        protected bool Validar(string token,string refresh_token)
        {

            return true;
        }


    }
}