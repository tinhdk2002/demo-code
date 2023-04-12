using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhHocPhi
{
    internal class DataProvider
    {
        private readonly string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=TinhHocPhi;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new();

            using (SqlConnection connection = new(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new(query, connection);

                SqlDataAdapter adapter = new(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
    }
}
