using System;
using System.Data;
using Npgsql;

namespace Cambio_Climático.Controllers
{
    public static class DatabaseConnection
    {
        private static string host = "ec2-34-192-173-173.compute-1.amazonaws.com",
            dataBase = "d8fh1lbfhq1uhj",
            userID = "mptuttmhstnajm",
            Password = "1146110d504a92b1d41635c54e75590521031ccf9c562721dbe90babf624992f";


        private static string sConnection =
            $"Server={host};Port=5432;User Id={userID};Password={Password};Database={dataBase};" +
            "sslmode=Require;Trust Server Certificate=true ";


        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            Console.WriteLine(sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}