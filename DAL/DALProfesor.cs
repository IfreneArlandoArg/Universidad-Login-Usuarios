using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProfesor : IAL
    {
        string connectionString = "Integrated Security = SSPI; Data Source = .; Initial Catalog = DB_UNIVERSIDAD;";
        public void Alta(BEUsuario pUsuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ALTA_PROFESOR", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NOMBRE", pUsuario.Nombre));
                cmd.Parameters.Add(new SqlParameter("@APELLIDO", pUsuario.Apellido));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", pUsuario.Email));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", pUsuario.Password));

                conn.Open();

                cmd.ExecuteNonQuery();


            }
        }

        public List<BEUsuario> Listar()
        {
            List<BEUsuario> temp = new List<BEUsuario>();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("LISTAR_PROFESORES", conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    temp.Add(new BEUsuario(reader["IDUSUARIO"].ToString(), reader["NOMBRE"].ToString(), reader["APELLIDO"].ToString(), reader["CATEGORIA"].ToString(), reader["EMAIL"].ToString(), reader["PASSWORD"].ToString() ));
                }


            }



            return temp;
        }



        
    }
}
