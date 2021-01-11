using Libreria.Control;
using Libreria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClaroClima
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtNombreUs.Text;
            string pass = txtPasswordUs.Text;

            UsuarioCRUD login = new UsuarioCRUD();
            usuario us = new usuario();
            try
            {
                us = login.LoginUs(correo, pass);
                if (us.correo_us!="" && us.password!="")
                {
                    Session["id_us"] = us.id_us.ToString();
                    Session["nombre_us"] = us.nombre_us.ToString();
                    Session["apellido_us"] = us.apellido_us.ToString();
                    Session["rut_us"] = us.apellido_us.ToString();
                    Session["fec_nac_us"] = us.fec_nac_us.ToString();
                    Session["correo_us"] = us.correo_us.ToString();
                   // Session["fk_id_cargo"] = int.Parse(us.fk_id_cargo.ToString());
                   // Session["fk_id_fabrica"] = int.Parse(us.fk_id_fabrica.ToString());
                    Session["fk_tipo_us"] = int.Parse(us.fk_tipo_us.ToString());
                    if (us.fk_tipo_us==2)
                    {
                        Response.Redirect("IndexAdmin.aspx");

                    }
                    else
                    {
                        throw new Exception("<script language=javascript>alert('Usuario no valido.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {

                Response.Write("<script language=javascript>alert('Error: "+ex.Message+"');</script>");             
                
            }
        }
    }
}