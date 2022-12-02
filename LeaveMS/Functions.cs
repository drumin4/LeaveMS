using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveMS
{
    public class Functions
    {
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private string connectionString;

        public Functions()
        {
            connectionString = @"Data Source=.;Initial Catalog=LeaveDb;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public DataTable GetData(string Query)
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(Query, connection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int SetData(string Query)
        {
            int Count = 0;

            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            command.CommandText = Query;
            Count = command.ExecuteNonQuery();
            return Count;
        }
    }
}
