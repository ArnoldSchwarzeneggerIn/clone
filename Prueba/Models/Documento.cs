using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Documento
    {
        public string Candidato { get; set; }
        public string Ruta { get; set; }
        public string Observacion { get; set; }
        public Byte[] Document { get; set; }
        public string Nombre { get; set; }

        Parametro[] para;
        Transaction[] trans;
        
        
        public Documento(int id, string value, string nombre)
        {
            this.Candidato = id.ToString();
            this.Ruta = value;
            this.Observacion = nombre;
        }

        public Documento()
        {
        }

   

    }
}