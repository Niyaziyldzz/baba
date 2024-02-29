using System.Data.SqlClient;
using System.Data;
using System;

namespace xquant.Models
{
    public class DAL
    {
        public Response register(Users users,SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand command = new SqlCommand("sp_register",connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", users.FirstName);
            command.Parameters.AddWithValue("@LastName", users.LastName);
            command.Parameters.AddWithValue("@Password", users.Password);
            command.Parameters.AddWithValue("@Email", users.Email);
            command.Parameters.AddWithValue("@Fund", 0);
            command.Parameters.AddWithValue("@Type", "Users");
            command.Parameters.AddWithValue("@Type", "Pending");
            connection.Open();

            int i = command.ExecuteNonQuery();

            connection.Close();
            if(i>0) 
            { 
                response.StatusCode = 200;
                response.StatusMessage = "User Register Succesfully";
            }
            else
            {
                response.StatusCode= 100;
                response.StatusMessage= "User Register Failed";
            }

            return response;
        }


        public Response login(Users users, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_login",connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Email", users.Email);
            da.SelectCommand.Parameters.AddWithValue("@Password", users.Password);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Response response = new Response();
            Users user = new Users();
            if(dt.Rows.Count>0)
            {
                user.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                user.FirstName = Convert.ToString(dt.Rows[0]["FirstName"]);
                user.LastName = Convert.ToString(dt.Rows[0]["LastName"]);
                user.Email = Convert.ToString(dt.Rows[0]["Email"]);
                user.Type = Convert.ToString(dt.Rows[0]["Type"]);




                response.StatusCode = 200;
                response.StatusMessage = "User is valid";
                response.user = user;
            }
            else
            {
                response.StatusCode= 100;
                response.StatusMessage = "User is İnvalid";
                response.user = null;

            }
            return response;
        }
        
        
        public Response wiewUser(Users users, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("p_wiewUser", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ID", users.ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
           
            if (dt.Rows.Count > 0)
            {
               
                response.StatusCode = 200;
                response.StatusMessage = "User exists";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "User does not exits";
            }
            return response;
        }



    }
}
