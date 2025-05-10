using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALEstudiante : IAL
    {
        string connectionString = "Integrated Security = SSPI; Data Source = .; Initial Catalog = DB_UNIVERSIDAD;";
        public void Alta(BEUsuario pUsuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ALTA_ESTUDIANTE", conn);
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
                SqlCommand cmd = new SqlCommand("LISTAR_ESTUDIANTES", conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    temp.Add(new BEUsuario(reader["IDUSUARIO"].ToString(), reader["NOMBRE"].ToString(), reader["APELLIDO"].ToString(), reader["CATEGORIA"].ToString(), reader["EMAIL"].ToString(), reader["PASSWORD"].ToString()));
                }


            }



            return temp;
        }

        
    }
}