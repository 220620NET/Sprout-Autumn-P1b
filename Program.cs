using DataAccess;


Console.WriteLine("Welcome to AutumnERS, where expenses are as beautiful as Autumn leaves.");
Console.WriteLine("Here is a list of all our users:");

UserDAO peeps = new UserDAO();
peeps.GetAllUsers();

Console.WriteLine("Here is a list of what they want you to pay for:");

TicketDAO claims = new TicketDAO();
claims.GetAllTickets();