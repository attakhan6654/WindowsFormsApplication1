using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DatabaseConnection
    {
        //Method For Connecting To Microsoft SQL Server Database
        public SqlConnection getConn()
        {
            //Connection String.
            string connectionString = @"Data Source=DESKTOP-KF1H18L;Initial Catalog=abc;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            //Return Connection.
            return connection;
        }
    }
}
