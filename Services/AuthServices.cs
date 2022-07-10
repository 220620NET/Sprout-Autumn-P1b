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
                        // if password for parameter user matches password from database user, return user to controller layer  
                       // throw custom exception if user doesn't exist
                       // throw custom exception if passwords don't match
                       // catch any exception thrown from DataAccess
                       // if exception caught, throw to the controller layer 

                }
                catch(Exception e)
                {
                      Console.WriteLine(e.Message);  
                }

        }  

        public User registerUser(string userName, string password)
        {
                // create temp user object to store data retrieved from DataAccess layer
                private User wantsInside = new User( userName, password);

                try{
                        // check database for existing userName
                                // if userName already exists, thorw customException  
                       // try to call DataAccess method to create user
                       // ensure user is returned with userID greater than zero
                       // if user succesfully saved to database
                        // return user to controller method
                       // catch any exception thrown from DataAccess
                       // if exception caught, throw to the controller layer 
                }
                catch(Exception e)
                {
                      Console.WriteLine(e.Message);  
                }

        }  

*/
}