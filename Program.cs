using Sensitive;
using System.Data.SqlClient;

string connectionString = "Server=tcp:autumn-server.database.windows.net,1433;Initial Catalog=AutumnDB;Persist Security Info=False;User ID=supremeadmin;Password=" + SensitiveVariables.dbpassword + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

string getAllUsers = "select * from AutumnERS.users;";

SqlConnection makeConnection = new SqlConnection(connectionString);

SqlCommand getEveryUser = new SqlCommand(getAllUsers, makeConnection);

try
{
    makeConnection.Open();
    SqlDataReader reader = getEveryUser.ExecuteReader();

    while (reader.Read())
    {
        Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
    }
    reader.Close();
    makeConnection.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}