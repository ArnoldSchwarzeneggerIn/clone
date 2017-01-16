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
        public static RestClient ConvocatoriaDetalle = new RestClient("http://191.102.85.226/Electoralapi/api/ConvocatoriaDetalle/");
        public static RestClient Cobertura = new RestClient("http://191.102.85.226/Electoral/api/cobertura/");
        public static RestClient Instancia = new RestClient("http://191.102.85.226/Electoralapi/api/instancia/");
        public static RestClient InstanciaConformacion = new RestClient("http://191.102.85.226/Electoral/api/instanciaconformacion/");
        public static RestClient CausaRetiro = new RestClient("http://191.102.85.226/Electoral/api/causaretiro/");
        public static RestClient InstaciaDetalle = new RestClient("http://191.102.85.226/ElectoralApi/api/instanciadetalle/");
        public static RestClient Jurado = new RestClient("http://191.102.85.226/Electoral/api/jurados");
        public static RestClient Autenticacion = new RestClient("http://chaira.udla.edu.co/api/v0.1/");
        public static RestClient Persona = new RestClient("http://191.102.85.226/Electoral/api/persona");
        public static RestClient Fecha = new RestClient("http://191.102.85.226/Electoral/api/fecha");


        //Rutas locales de pruea
        public static RestClient lConvocatoria = new RestClient("http://localhost:25598/api/convocatoria/");
        public static RestClient lConvocatoriaDetalle = new RestClient("http://191.102.85.226/Electoralapi/api/ConvocatoriaDetalle/");
        public static RestClient lCobertura = new RestClient("http://191.102.85.226/Electoral/api/cobertura/");
        public static RestClient lInstancia = new RestClient("http://191.102.85.226/Electoralapi/api/instancia/");
        public static RestClient lInstanciaConformacion = new RestClient("http://191.102.85.226/Electoral/api/instanciaconformacion/");
        public static RestClient lCausaRetiro = new RestClient("http://191.102.85.226/Electoral/api/causaretiro/");
        public static RestClient lInstaciaDetalle = new RestClient("http://191.102.85.226/ElectoralApi/api/instanciadetalle/");
        public static RestClient lJurado = new RestClient("http://191.102.85.226/Electoral/api/jurados");
        public static RestClient lAutenticacion = new RestClient("http://chaira.udla.edu.co/api/v0.1/");
        public static RestClient lPersona = new RestClient("http://191.102.85.226/Electoral/api/persona");
    }
}