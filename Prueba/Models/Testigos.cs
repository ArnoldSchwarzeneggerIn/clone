using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Testigos
    {
        private string nombre = string.Empty;
        private string idTestigo = string.Empty;
        private string cedula = string.Empty;
        private string candidatura = string.Empty;
        private string usuario = string.Empty;
        Parametro[] para;


        public Testigos(string v)
        {
            this.Candidatura = v;
        }
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
        public Testigos()
        {
        }

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

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Candidatura
        {
            get
            {
                return candidatura;
            }

            set
            {
                candidatura = value;
            }
        }

        public string IdTestigo
        {
            get
            {
                return idTestigo;
            }

            set
            {
                idTestigo = value;
            }
        }

        public Parametro[] ConsultarTestigos()
        {
            para = new Parametro[1];
            para[0] = new Parametro("CANDIDATO", candidatura);
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