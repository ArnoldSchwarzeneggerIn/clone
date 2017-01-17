using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Parametro
    {
        public string Nombre { get; set; }
        public string Value { get; set; }
        public byte[] ValueBit { get; set; }
        
        public Parametro(string n, string v)
        {
            Nombre = n;
            Value = v;
        }


        public Parametro(string n, byte[] v)
        {
            Nombre = n;
           ValueBit = v;
        }

    }
}