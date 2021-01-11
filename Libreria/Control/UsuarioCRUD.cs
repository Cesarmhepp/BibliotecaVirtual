using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.BDCon;
using Libreria.Modelo;

namespace Libreria.Control
{
    public class UsuarioCRUD
    {
        Conexion c = new Conexion();
        public usuario LoginUs(string correo, string pass)
        {
            usuario us = new usuario();
            try
            {
                c.con.Open();
                string query = "select id_us,nombre_us,apellido_us,rut_us,fec_nac_us,correo_us,fk_id_cargo,fk_id_fabrica,fk_tipo_us from usuario where correo_us='" + correo + "' and password='" + pass + "';";
                BibliotecaVirtualConnection bd = new BibliotecaVirtualConnection();
                SqlCommand cmd = new SqlCommand(query, c.con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    us.id_us = int.Parse(dt.Rows[0][0].ToString());
                    us.nombre_us = dt.Rows[0][1].ToString();
                    us.apellido_us = dt.Rows[0][2].ToString();
                    us.rut_us = dt.Rows[0][3].ToString();
                    us.fec_nac_us = Convert.ToDateTime(dt.Rows[0][4].ToString());
                    us.correo_us = dt.Rows[0][5].ToString();
                   // us.fk_id_cargo = int.Parse(dt.Rows[0][6].ToString());
                   // us.fk_id_fabrica = int.Parse(dt.Rows[0][7].ToString());
                    us.fk_tipo_us = int.Parse(dt.Rows[0][8].ToString());
                }
                else
                {
                    throw new Exception("El correo o la contraseña son incorrectos.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            c.con.Close();
            return us;
        }

        public usuario GetUsuario(int idus)
        {
            usuario us = new usuario();
            try
            {
                c.con.Open();
                string query = "select id_us,nombre_us,apellido_us,rut_us,fec_nac_us,correo_us,fk_id_cargo,fk_id_fabrica,fk_tipo_us from usuario where where id_us="+idus+";";
                SqlCommand cmd = new SqlCommand(query, c.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    us.id_us = int.Parse(dt.Rows[0][0].ToString());
                    us.nombre_us = dt.Rows[0][1].ToString();
                    us.apellido_us = dt.Rows[0][2].ToString();
                    us.rut_us = dt.Rows[0][3].ToString();
                    us.fec_nac_us = Convert.ToDateTime(dt.Rows[0][4].ToString());
                    us.correo_us = dt.Rows[0][5].ToString();
                    us.fk_id_cargo = int.Parse(dt.Rows[0][7].ToString());
                    us.fk_id_fabrica = int.Parse(dt.Rows[0][8].ToString());
                    us.fk_tipo_us = int.Parse(dt.Rows[0][9].ToString());

                }
                else
                {
                    throw new Exception("No se han encontrado datos asociados a esta cuenta.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            c.con.Close();
            return us;
        }

        
    }
}
