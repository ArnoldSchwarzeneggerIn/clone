using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Documentos
    {
        private string candidato = string.Empty;
        private string ruta = string.Empty;
        Parametro[] para;

        public string Candidato
        {
            get
            {
                return candidato;
            }

            set
            {
                candidato = value;
            }
        }

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

        public string Observacion1
        {
            get
            {
                return Observacion;
            }

            set
            {
                Observacion = value;
            }
        }


        private string Observacion = string.Empty;


        public Documentos(int id, string value, string nombre)
        {
            this.candidato = id.ToString();
            this.Ruta = value;
            this.Observacion1 = nombre;
        }

        public Parametro[] Insertar()
        {
            para = new Parametro[3];
            para[0] = new Parametro("DOCU_CANDIDATURA", Candidato);
            para[1] = new Parametro("DOCU_RUTA", Ruta);
            para[2] = new Parametro("DOCU_OBSERVACION", Observacion1);
            return para;
        }

    }
}