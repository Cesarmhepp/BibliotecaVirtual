using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClaroClima.MasterPage
{
    public partial class MasterAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                

                if (Session["fk_tipo_us"].ToString()!="1" || Session["fk_tpo_us"] !=null)
                {

                    lblLogin.InnerText = Session["nombre_us"].ToString();
                    btnLoginMenu.Visible = false;
                    btnRegisMenu.Visible = false;
                    btnCerrarSesion.Visible = true;
                    //btnMiCuenta.Visible = true;
                }
                else
                {
                    
                    throw new Exception("Acceso denegado.");

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Error: "+ex.Message+"')</script>");
                Response.Redirect("index.aspx");
            }

            

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            Session.Remove("id_us");
            Session.Remove("nombre_us");
            Session.Remove("apellido_us");
            Session.Remove("rut_us");
            Session.Remove("fec_nac_us");
            Session.Remove("correo_us");
           // Session.Remove("fk_id_cargo");
           // Session.Remove("fk_id_fabrica");
            Session.Remove("fk_tipo_us");
            Response.Redirect("Index.aspx");


        }
    }
}