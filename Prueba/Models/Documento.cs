using Prueba.Conexions;
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
        Conexion conx = new Conexion();
        
        public Documento(int id, string value, string nombre)
        {
            this.Candidato = id.ToString();
            this.Ruta = value;
            this.Observacion = nombre;
        }

        public Documento()
        {
        }

        public bool Insertar(Documento obj)
        {
            para = new Parametro[5];
            para[0] = new Parametro("PDOCU_CANDIDATURA", obj.Candidato);
            para[1] = new Parametro("PDOCU_RUTA", obj.Ruta);
            para[2] = new Parametro("PDOCU_OBSERVACION", obj.Observacion);
            //para[3] = new Parametro("PDOCU", obj.Document);
            para[4] = new Parametro("PDOCU_NOMBRE", obj.Nombre);
            trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRT_DOCU", para);

            return conx.realizarTransaccion(trans);
        }

    }
}