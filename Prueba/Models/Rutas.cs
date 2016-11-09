using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace Prueba.Models
{
    public static class Rutas
    {
        private static RestClient convocatoria = new RestClient("http://191.102.85.226/Electoral/api/convocatoria/");
        private static RestClient cobertura = new RestClient("http://191.102.85.226/Electoral/api/cobertura/");
        private static RestClient instancia = new RestClient("http://191.102.85.226/Electoral/api/instancia/");
        private static RestClient instanciaConformacion = new RestClient("http://191.102.85.226/Electoral/api/instanciaconformacion/");
        private static RestClient causaRetiro = new RestClient("http://191.102.85.226/Electoral/api/causaretiro/");
        private static RestClient instaciaDetalle = new RestClient("http://191.102.85.226/Electoral/api/InstanciaDetalle/");
        private static RestClient jurado = new RestClient("http://localhost:25597/api/jurados");
        private static RestClient autenticacion = new RestClient("http://chaira.udla.edu.co/api/v0.1/");
        private static RestClient persona = new RestClient("http://localhost:25597/api/persona");


        public static RestClient Persona
        {
            get
            {
                return persona;
            }
            set
            {
                persona = value;
            }
        }
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

        public static RestClient InstaciaDetalle
        {
            get
            {
                return instaciaDetalle;
            }

            set
            {
                instaciaDetalle = value;
            }
        }

        public static RestClient Autenticacion
        {
            get
            {
                return autenticacion;
            }

            set
            {
                autenticacion = value;
            }
        }

        public static RestClient Jurado
        {
            get
            {
                return jurado;
            }
            set
            {
                jurado = value;
            }
        }
    }
}