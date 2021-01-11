using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BDCon
{
    public class Conexion
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader rd;

        public Conexion()
        {
            try
            {
                con = new SqlConnection("Data Source = DESKTOP-M9JO16K; " + "Initial Catalog = BibliotecaVirtual; " + "Integrated Security = True;");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            
        }
    }
}
