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
        private Parametro[] para;
        private string idCobertura = string.Empty;
        private string nombreCobertura = string.Empty;
        private string estadoCobertura = string.Empty;
        Conexion conx = new Conexion();

        public string IdCobertura
        {
            get
            {
                return idCobertura;
            }

            set
            {
                idCobertura = value;
            }
        }

        public string NombreCobertura
        {
            get
            {
                return nombreCobertura;
            }

            set
            {
                nombreCobertura = value;
            }
        }

        public string EstadoCobertura
        {
            get
            {
                return estadoCobertura;
            }

            set
            {
                estadoCobertura = value;
            }
        }

        public Parametro [] AgregarParametrosInsertar(Cobertura obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCOBE_NOMBRE", obj.NombreCobertura);
            return para;
        }

        public Parametro[] AgregarParametrosModificar(Cobertura obj)
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
            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_COBE", AgregarParametrosInsertar(obj));
            return conx.realizarTransaccion(trans);
        }
        public bool ModificarCobertura(Cobertura obj)
        {
            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_UPDT_COBE", AgregarParametrosModificar(obj));
            return conx.realizarTransaccion(trans);
        }

    }
}