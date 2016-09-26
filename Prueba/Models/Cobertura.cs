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

        public DataTable Consultar()
        {
            return conx.realizarConsulta("PR_CNST_COBE", "CR_CNST_COBE", null);
        }
        public Parametro[] Insertar()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCOBE_NOMBRE", NombreCobertura);

            return para;
        }

        public Parametro[] Modificar()
        {
            para = new Parametro[3];
            para[0] = new Parametro("PCOBE_ID", IdCobertura);
            para[1] = new Parametro("PCOBE_NOMBRE", NombreCobertura);
            para[2] = new Parametro("PCOBE_ESTADO", EstadoCobertura);

            return para;
        }
    }
}