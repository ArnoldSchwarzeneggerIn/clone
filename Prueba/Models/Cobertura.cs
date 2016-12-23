using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Cobertura
    {
        Conexion conx = new Conexion();
        public Parametro[] para;
        public string IdCobertura { get; set; }
        public string NombreCobertura { get; set; }
        public string EstadoCobertura { get; set; }
        
        public Parametro [] ParametrosInsertar(Cobertura obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCOBE_NOMBRE", obj.NombreCobertura);
            return para;
        }

        public Parametro[] ParametrosModificar(Cobertura obj)
        {
            para = new Parametro[3];
            para[0] = new Parametro("PCOBE_ID", obj.IdCobertura);
            para[1] = new Parametro("PCOBE_NOMBRE", obj.NombreCobertura);
            para[2] = new Parametro("PCOBE_ESTADO", obj.EstadoCobertura);

            return para;

        }

        public DataTable ConsultarCobertura()
        {
            return conx.realizarConsulta("PR_CNST_COBE", "CR_CNST_COBE", null);
        }

        public bool InsertarCobertura(Cobertura obj)
        {
            Transaction[] trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRT_COBE", ParametrosInsertar(obj));
            return conx.realizarTransaccion(trans);
        }
        public bool ModificarCobertura(Cobertura obj)
        {
            Transaction[] trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDT_COBE", ParametrosModificar(obj));
            return conx.realizarTransaccion(trans);
        }

    }
}