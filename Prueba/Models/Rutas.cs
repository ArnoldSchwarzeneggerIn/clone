using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace Prueba.Models
{
    public static class Rutas
    {
        private static RestClient convocatoria = new RestClient("http://localhost:25597/api/convocatoria/");
        private static RestClient cobertura = new RestClient("http://localhost:25597/api/cobertura/");
        private static RestClient instancia = new RestClient("http://localhost:25597/api/instancia/");
        private static RestClient instanciaConformacion = new RestClient("http://localhost:25597/api/instanciaconformacion/");
        private static RestClient causaRetiro = new RestClient("http://localhost:25597/api/causaretiro/");


        public static RestClient Convocatoria
        {
            get
            {
                return convocatoria;
            }

            set
            {
                convocatoria = value;
            }
        }

        public static RestClient Cobertura
        {
            get
            {
                return cobertura;
            }

            set
            {
                cobertura = value;
            }
        }

        public static RestClient Instancia
        {
            get
            {
                return instancia;
            }

            set
            {
                instancia = value;
            }
        }

        public static RestClient InstanciaConformacion
        {
            get
            {
                return instanciaConformacion;
            }

            set
            {
                instanciaConformacion = value;
            }
        }

        public static RestClient CausaRetiro
        {
            get
            {
                return causaRetiro;
            }

            set
            {
                causaRetiro = value;
            }
        }
    }
}