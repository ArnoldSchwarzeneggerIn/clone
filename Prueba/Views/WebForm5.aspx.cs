using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Views
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public static List<Loggin> user = new List<Loggin>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.Params["__EVENTTARGET"];
            switch (Request.Params["__EVENTTARGET"])
            {
                case "login":
                    IniciarSesionC(sender, e);
                    break;
            }
            
            if (!IsPostBack)
            {



                Loggin logi = new Loggin();
                logi.UsuarioLogin = "admin";
                logi.ContraceniaLogin = "admin";

                user.Add(logi);

                logi = new Loggin();
                logi.UsuarioLogin = "publico";
                logi.ContraceniaLogin = "publico";

                user.Add(logi);


                user.Add(logi);

                Session["Token"] = null;
                Session["Code"] = null;
            }
        }

        protected void IniciarSesionC(object sender, EventArgs e)
        {
            foreach (var Loggin in user)
            {
                if (Loggin.UsuarioLogin.Equals(usser.Value))
                {
                    if (Loggin.ContraceniaLogin.Equals(pwd.Value))
                    {
                        Response.Redirect("VConvocatoria.aspx");
                    }
                }

            }

        }


        protected void IniciarSesionC()
        {
            foreach (var Loggin in user)
            {
                if (Loggin.UsuarioLogin.Equals(usser.Value))
                {
                    if (Loggin.ContraceniaLogin.Equals(pwd.Value))
                    {
                        Response.Redirect("VConvocatoria.aspx");
                    }
                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}