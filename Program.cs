using DataAccess;


Console.WriteLine("Welcome to AutumnERS, where expenses are as beautiful as Autumn leaves.");
Console.WriteLine("Here is a list of all our users:");

UserDAO main = new UserDAO();
main.GetAllUsers();

