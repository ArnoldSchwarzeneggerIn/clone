using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Loggin
    {
        private string usuario = string.Empty;
        private Parametro[] para;


        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
        public Loggin(string loggin)
        {
            this.usuario = loggin;
        }

        public Parametro[] ConsultarInstancia()
        {
            para = new Parametro[1];
            para[0] = new Parametro("USUARIO", this.usuario);
            return para;
        }

    }
}