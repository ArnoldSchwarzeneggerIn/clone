using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Transacion
    {
        public string Procedure { get; set; }
        public Parametro[] Parameters { get; set; }

        public Transacion(string Procedure, Parametro[] Parameters)
        {
            this.Procedure = Procedure;
            this.Parameters = Parameters;
        }
    }
}