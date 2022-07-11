using Models;
using Services;
using System.Data.SqlClient;

namespace DataAccess;
// The only purpose of DAO or DataAccess layer is to talk to the database



public class UserDAO 
{

/*
    // used by RegisterUser method in Services to put user into database
    public bool CreateUser(User User){

    }

    public List<User> GetUserByID(){

    }
  */ 
    public List<User> GetUserByUserName(string userWanted){

        List<User> thisUser = new List<User>();
        
        string getThisUser = "select * from AutumnERS.users where userName ='" + userWanted + "';";

        SqlConnection makeConnection = new SqlConnection(AuthServices.connectionString);

        SqlCommand goGetThisUser = new SqlCommand(getThisUser, makeConnection);

        try
        {
            makeConnection.Open();
            SqlDataReader reader = goGetThisUser.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                thisUser.Add(new User((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            reader.Close();
            makeConnection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return thisUser;
    }
 
    // public List<User> LoginUser(string wantsInUserName, string wantsInPassword)
    // {
    //     // create temp user object to store data retrieved from DataAccess layer
    //     List<User> userWantsIn = new List<User>();

    //     // retrieve user from database using DataAccess method

    //     string getThisUser = "select * from AutumnERS.users where userName ='" + wantsInUserName + "';";

    //     SqlConnection makeConnection = new SqlConnection(AuthServices.connectionString);

    //     SqlCommand goGetThisUser = new SqlCommand(getThisUser, makeConnection);

    //     try
    //     {
    //         makeConnection.Open();
    //         SqlDataReader reader = goGetThisUser.ExecuteReader();
    //         while (reader.Read())
    //         {
    //             Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
    //             userWantsIn.Add(new User((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
    //         }
    //         reader.Close();
    //         makeConnection.Close();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }

    //     return userWantsIn;

    //             // if password for parameter user matches password from database user
    //             // return user to UI layer  
    //             // If user is a Manager, display Manager Menu
    //     // try

    //             // throw custom exception if user doesn't exist
    //             // throw custom exception if passwords don't match
    //             // catch any exception thrown from DataAccess
    //             // if exception caught, throw to the UI layer 
    // }  







    public List<User> GetAllUsers(){

        List<User> users = new List<User>();

        string getAllUsers = "select * from AutumnERS.users;";

        SqlConnection makeConnection = new SqlConnection(AuthServices.connectionString);

        SqlCommand getEveryUser = new SqlCommand(getAllUsers, makeConnection);

        try
        {
            makeConnection.Open();
            SqlDataReader reader = getEveryUser.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                users.Add(new User((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
            }
            reader.Close();
            makeConnection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return users;
    }



}
