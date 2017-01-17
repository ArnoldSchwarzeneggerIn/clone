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
        

        public Testigos(string v)
        {
            this.Candidatura = v;
        }

        public Testigos() {
        }
        
    }
}