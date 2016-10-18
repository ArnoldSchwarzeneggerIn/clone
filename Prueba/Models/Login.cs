using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Login
    {
        private string hola = string.Empty;

        public string UsuarioLogin { get; set; }
        public string ContraceniaLogin { get; set; }

        private Parametro[] para;
        Conexion conx = new Conexion();
        public Login(string loggin)
        {
            this.UsuarioLogin = loggin;
        }
    
        public Login()
        {
        }

        public DataTable ConsultarInstancia(Login obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PLOGI_USUARIO", obj.UsuarioLogin);
            return conx.realizarConsulta("PR_CNST_RPSN", "CR_CNST_RPSN", para);
        }

        public DataTable ConsultarPrograma(Login obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PLOGI_USUARIO", obj.UsuarioLogin);
            return conx.realizarConsulta("PR_CNST_PRGM", "CR_CNST_PRGM",para);
        }

        public DataTable ConsultarDatos(Login obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PLOGI_USUARIO", obj.UsuarioLogin);
            return conx.realizarConsulta("PR_CNST_DTOS", "CR_CNST_DTOS", para);
        }


        //public DataTable ConsultarCedulaCandidato(Loggin obj)
        //{
        //    //return cond.realizarConsulta();
        //}

    }
}