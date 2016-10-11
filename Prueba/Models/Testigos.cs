using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Testigos
    {
        public string Nombre {get; set;}
        public string IdTestigo {get; set;}
        public string Cedula {get; set;}
        public string Candidatura {get; set;}
        public string Usuario {get; set;}
        Parametro[] para;


        public Testigos(string v)
        {
            this.Candidatura = v;
        }

        public Testigos() {
        }
        

        public Parametro[] ConsultarTestigos()
        {
            para = new Parametro[1];
            para[0] = new Parametro("CANDIDATO", Candidatura);
            return para;
        }
        public Parametro[] EliminarTestigo()
        {
            para = new Parametro[1];
            para[0] = new Parametro("CANT_ID", IdTestigo);
            return para;
        }
        internal Parametro[] InsertarTestigo()
        {
            para = new Parametro[2];
            para[0] = new Parametro("USUARIO", Usuario);
            para[1] = new Parametro("CANDIDATO", Candidatura);
            return para;
        }
    }
}