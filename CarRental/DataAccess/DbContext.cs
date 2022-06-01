using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarRental.DataAccess
{
    public class DbContext
    {
        
        public SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=CarDatabase;integrated security=true;MultipleActiveResultSets=True");
        public void ConnectionOpen()
        {
            if (this._connection.State == System.Data.ConnectionState.Closed)
            {
                this._connection.Open();
            }
        }
    }
}