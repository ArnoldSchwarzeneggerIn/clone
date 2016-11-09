using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class CausaRetiro
    {
        Conexion conx = new Conexion();
        Parametro[] para;
        public string IdCausaretiro { get; set; }
        public string NombreCausaretiro { get; set; }
        public string EstadoCausaretiro { get; set; }

        public Parametro[] AgregarParametros(CausaRetiro obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCAUR_NOMBRE", obj.NombreCausaretiro);

            return para;
        }

        public Parametro[] ModificarParametros(CausaRetiro obj)
        {
            para = new Parametro[3];
            para[0] = new Parametro("PCAUR_ID", obj.IdCausaretiro);
            para[1] = new Parametro("PCAUR_NOMBRE", obj.NombreCausaretiro);
            para[2] = new Parametro("PCAUR_ESTADO", obj.EstadoCausaretiro);

            return para;
        }


        public DataTable ConsultarCausaRetiro()
        {         
            return conx.realizarConsulta("PR_CNST_CAUR", "CR_CNST_CAUR", null);
        }

        public bool InsertarCausaRetiro(CausaRetiro obj)
        {

            Transacion[] tran = new Transacion[1];
            tran[0] = new Transacion("PR_NSTR_CAUR", AgregarParametros(obj));
            return conx.realizarTransaccion(tran);
        }

        public bool ModificarCausaRetiro(CausaRetiro obj)
        {
            Transacion[] tran = new Transacion[1];
            tran[0] = new Transacion("PR_UPDT_CAUR", ModificarParametros(obj));
            return conx.realizarTransaccion(tran);
        }

    }
}
