using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Instancia
    {
        Conexion conx = new Conexion();
        private Parametro[] para;
        private string idInstancia = string.Empty;
        private string idCobertura = string.Empty;
        private string nombreInstancia = string.Empty;
        private string estadoInstancia = string.Empty;

        public string IdInstancia
        {
            get
            {
                return idInstancia;
            }

            set
            {
                idInstancia = value;
            }
        }

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



        public string NombreInstancia
        {
            get
            {
                return nombreInstancia;
            }

            set
            {
                nombreInstancia = value;
            }
        }

        public string EstadoInstancia
        {
            get
            {
                return estadoInstancia;
            }

            set
            {
                estadoInstancia = value;
            }
        }

        public string Detalleid
        {
            get
            {
                return detalleid;
            }

            set
            {
                detalleid = value;
            }
        }

        public Parametro[] ConsultarId()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_ID", IdInstancia);


            return para;
        }

        public Instancia(string idinstancia)
        {
            this.IdInstancia = idinstancia;
        }
        private string detalleid = string.Empty;

        public Instancia(string idinstancia, string iddetalle)
        {
            this.IdInstancia = idinstancia;
            this.Detalleid = iddetalle;
        }
        public Instancia()
        {
        }

        public Parametro[] Consultar_instancia()
        {
            para = new Parametro[1];
            para[0] = new Parametro("INSTANCIA", idInstancia);
            return para;
        }
        public DataTable Consultar_instancia2()
        {
            para = new Parametro[2];
            para[0] = new Parametro("INSTANCIA", idInstancia);
            para[1] = new Parametro("INSTANCIAD", detalleid);

            return conx.realizarConsulta("PR_CONSULTARINSTANCIA", "CR_INSTANCIA", para);
        }

        public DataTable ConsultarPorPalabras(Instancia insta)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_NOMBRE", insta.NombreInstancia);


            return conx.realizarConsulta("PR_CNST_INST_PALA", "CR_CNST_INST_PALA", para);
        }
        public Parametro[] Insertar()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PINST_NOMBRE", NombreInstancia);
            para[1] = new Parametro("PINST_COBERTURA", IdCobertura);

            return para;
        }

        public Parametro[] Modificar()
        {
            para = new Parametro[4];
            para[0] = new Parametro("PINST_ID", IdCobertura);
            para[1] = new Parametro("PINST_NOMBRE", NombreInstancia);
            para[2] = new Parametro("PINST_COBERTURA", IdCobertura);
            para[3] = new Parametro("PINST_ESTADO", EstadoInstancia);

            return para;
        }

        public Parametro[] ConsultarCargosInstancia()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_ID", idInstancia);
            return para;
        }

        public DataTable Consultar()
        {
            return conx.realizarConsulta("PR_CNST_INST", "CR_CNST_INST", null);
        }

        public DataTable ConsultarNombre()
        {
            return conx.realizarConsulta("PR_CNST_INST_NMBR", "CR_CNST_INST_NMBR", null);
        }
    
}
}