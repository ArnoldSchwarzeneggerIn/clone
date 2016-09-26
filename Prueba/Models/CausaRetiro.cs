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
        private string idCausaretiro = string.Empty;
        private string nombreCausaretiro = string.Empty;
        private string estadoCausaretiro = string.Empty;
        Parametro[] para;

        public string IdCausaretiro
        {
            get
            {
                return idCausaretiro;
            }

            set
            {
                idCausaretiro = value;
            }
        }

        public string NombreCausaretiro
        {
            get
            {
                return nombreCausaretiro;
            }

            set
            {
                nombreCausaretiro = value;
            }
        }

        public string EstadoCausaretiro
        {
            get
            {
                return estadoCausaretiro;
            }

            set
            {
                estadoCausaretiro = value;
            }
        }


        public DataTable Consultar()
        {
           
            return conx.realizarConsulta("PR_CNST_CAUR", "CR_CNST_CAUR", null);
        }
        //public Parametro[] Insertar()
        //{
        //    para = new Parametro[1];
        //    para[0] = new Parametro("PCAUR_NOMBRE", NombreCausaretiro);

        //    return para;
        //}

        //public Parametro[] Modificar()
        //{
        //    para = new Parametro[3];
        //    para[0] = new Parametro("PCAUR_ID", IdCausaretiro);
        //    para[1] = new Parametro("PCAUR_NOMBRE", NombreCausaretiro);
        //    para[2] = new Parametro("PCAUR_ESTADO", EstadoCausaretiro);

        //    return para;
        //}

    }
}
