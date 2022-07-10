using Models;
// using DataAccess;
// using customExceptions;
using Sensitive;

namespace Services;

public class AuthServices 
{
        public static string connectionString = "Server=tcp:autumn-server.database.windows.net,1433;Initial Catalog=AutumnDB;Persist Security Info=False;User ID=supremeadmin;Password=" + SensitiveVariables.dbpassword + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

/*
        public User LoginUser(string userName, string password)
        {
                // create temp user object to store data retrieved from DataAccess layer
                private User wantsInside = new User( userName, password);

                try{
                        // retrieve user from database using DataAccess method
                        // if password for parameter user matches password from database user
                                // return user to UI layer  
                                // If user is a Manager, display Manager Menu
                        // throw custom exception if user doesn't exist
                        // throw custom exception if passwords don't match
                        // catch any exception thrown from DataAccess
                        // if exception caught, throw to the UI layer 

                }
                catch(Exception e)
                {
                      Console.WriteLine(e.Message);  
                }

        }  



*/
}