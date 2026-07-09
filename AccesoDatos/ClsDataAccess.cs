using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Models.Users;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;


namespace DataAccess
{
    public class ClsDataAccess
    {
        public static SqlConnection ObtenerConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }


        public ClsResponse Registrar(ClsRequest obj_users)
        {
            using (SqlConnection conn = ClsDataAccess.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Register", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User", obj_users.Tbl_Username);
                cmd.Parameters.AddWithValue("@Pass", obj_users.Tbl_Password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new ClsResponse
                    {
                        Status = int.Parse(reader["Status"].ToString()),
                        message = reader["message"].ToString()
                    };

                return null;
            }
        }

        public ClsResponse Login(ClsRequest obj_users)
        {
            using (SqlConnection conn = ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_LoginUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User", obj_users.Tbl_Username);
                cmd.Parameters.AddWithValue("@Pass", obj_users.Tbl_Password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new ClsResponse
                    {
                        Status = int.Parse(reader["Status"].ToString()),
                        message = reader["message"].ToString()
                    };

                return null;
            }
        }

    }

}


