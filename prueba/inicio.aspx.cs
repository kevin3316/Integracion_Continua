using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                btnLogin.Click += new System.EventHandler(Login_Click);
            }
        }

        private void Login_Click(Object sender, System.EventArgs e)
        {
            if(login(txtUsuario .Text ,txtContra .Text))
            {
                lblSalida.Text = "Login correcto";
            }else
            {
                lblSalida.Text = "Login incorrecto";
            }
        }

        public bool login(string usuario, string contra)
        {
            if(usuario == "kevin" && contra == "123")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}