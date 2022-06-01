using CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarRental.DataAccess
{
    public class UserDal
    {
        DbContext DbContext = new DbContext();

        public  UserRole getUserRole(string userId)
        {
            DbContext.ConnectionOpen();


            SqlCommand command = new SqlCommand("SELECT RoleId FROM AspNetUserRoles Where UserId=@userId", DbContext._connection);
            if (String.IsNullOrEmpty(userId))
            {
                command.Parameters.AddWithValue("@userId", DBNull.Value);
            }
            else
                command.Parameters.AddWithValue("@userId", userId);
           
            SqlDataReader reader =  command.ExecuteReader();
            while (reader.Read())
            {
                UserRole userRole = new UserRole
                {
                    Role = reader["RoleId"].ToString()
                };
                    
                return userRole;

            }
            reader.Close();
            DbContext._connection.Close();
            return null;
            
        }

    }
}