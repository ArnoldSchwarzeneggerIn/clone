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
        public Conexion conx = new Conexion();
        public Parametro[] para;
        public string IdInstancia { get; set; }
        public string IdCobertura { get; set; }
        public string NombreInstancia { get; set; }
        public string EstadoInstancia { get; set; }


        public Parametro[] ConsultarId()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_ID", IdInstancia);


            return para;
        }
        public Instancia()
        {
        }
      
        public Parametro[] InstanciaModificar(Instancia obj)
        {
            para = new Parametro[4];
            para[0] = new Parametro("PINST_ID", obj.IdCobertura);
            para[1] = new Parametro("PINST_NOMBRE", obj.NombreInstancia);
            para[2] = new Parametro("PINST_COBERTURA", obj.IdCobertura);
            para[3] = new Parametro("PINST_ESTADO", obj.EstadoInstancia);

            return para;
        }

        public DataTable ConsultarPorPalabras(Instancia obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_NOMBRE", obj.NombreInstancia);


            return conx.realizarConsulta("PR_CNST_INST_PALA", "CR_CNST_INST_PALA", para);
        }
        public bool InsertarInstancia(Instancia obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PINST_NOMBRE", obj.NombreInstancia);
            para[1] = new Parametro("PINST_COBERTURA", obj.IdCobertura);

            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_INST",para);
            return conx.realizarTransaccion(trans);
        }

        public bool ModificarInstancia(Instancia obj)
        {
            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_INST", InstanciaModificar(obj));

            return conx.realizarTransaccion(trans);
        }

        public Parametro[] ConsultarCargosInstancia()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINST_ID", IdInstancia);
            return para;
        }

        public DataTable ConsultarInstancia()
        {
            return conx.realizarConsulta("PR_CNST_INST", "CR_CNST_INST", null);
        }

        public DataTable ConsultarInstanciaNombre()
        {
            return conx.realizarConsulta("PR_CNST_INST_NMBR", "CR_CNST_INST_NMBR", null);
        }
    
}
}
//public Parametro[] Consultar_instancia()
//{
//    para = new Parametro[1];
//    para[0] = new Parametro("INSTANCIA", IdInstancia);
//    return para;
//}
//public DataTable Consultar_instancia2()
//{
//    para = new Parametro[2];
//    para[0] = new Parametro("INSTANCIA", idInstancia);
//    para[1] = new Parametro("INSTANCIAD", detalleid);

//    return conx.realizarConsulta("PR_CONSULTARINSTANCIA", "CR_INSTANCIA", para);
//}

//public DataTable ConsultarInstancia(Instancia obj)
//{
//    para = new Parametro[0];
//    para[0] = new Parametro("",);
//    return conx.realizarConsulta("PR_CNST_INST", "CR_CNST_INST", null);
//}
