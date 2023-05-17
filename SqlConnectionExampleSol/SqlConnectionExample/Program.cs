using System.Configuration;
using System.Data.SqlClient;

namespace SqlConnectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Es posible crear de esta forma una conexion a la base
            string connectionString = @"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }

            //Es posible crear de esta forma una conexion a la base
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"myDataBase";
            sqlConnectionStringBuilder.InitialCatalog = "myDataBase";
            connectionString = sqlConnectionStringBuilder.ToString();

            //Este metodo nos sirve para tomar la conexion desde el .config
            string connectionST = ConfigurationManager.ConnectionStrings["MyCadenaConexion"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionST))
            {
                connection.Open();
            }
        }
    }
}