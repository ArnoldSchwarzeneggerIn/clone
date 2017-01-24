using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Loggin
    {
        private string hola = string.Empty;

        public string UsuarioLogin { get; set; }
        public string ContraceniaLogin { get; set; }
   
        public Loggin(string loggin)
        {
            this.UsuarioLogin = loggin;
        }
    
        public Loggin()
        {
        }

    

      

    }
}