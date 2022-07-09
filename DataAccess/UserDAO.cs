using Models;
using Sensitive;
using System.Data.SqlClient;

namespace DataAccess;
// The only purpose of DAO or DataAccess layer is to talk to the database

// Get User by userName method
// Get User by userID method
// Get all users method
// Create User method

public class UserDAO {

    string connectionString = "Server=tcp:autumn-server.database.windows.net,1433;Initial Catalog=AutumnDB;Persist Security Info=False;User ID=supremeadmin;Password=" + SensitiveVariables.dbpassword + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public List<User> GetAllUsers(){

        List<User> users = new List<User>();

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
                users.Add(new User(reader[0], reader[1], reader[2], reader[3]));
            }
            reader.Close();
            makeConnection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public bool CreateUser(User User){

    }

    public List<User> GetUserByID(){

    }

    public List<User> GetUserByUserName(){
        
    }
}