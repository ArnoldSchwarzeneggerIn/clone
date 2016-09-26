using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Parametro
    {
        private string nombre = string.Empty;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }


        private string value = string.Empty;

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Parametro(string n, string v)
        {
            Nombre = n;
            Value = v;
        }

    }
}