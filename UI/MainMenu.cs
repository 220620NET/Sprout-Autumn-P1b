using DataAccess;

namespace UI;

public class MainMenu
{
    public void Begin()
    {
        do
        {
            Console.WriteLine("Welcome to AutumnERS, where expenses are as beautiful as Autumn leaves.");
            Console.WriteLine("What do you need to do?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[3] Exit");
            // Console.WriteLine("[3] View User List");
            // Console.WriteLine("[4] View Ticket List");
            
            string input = Console.ReadLine();

            switch(input)
            {
                case "1": // Login
                    Console.WriteLine("userName: ");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Password, too: ");
                    string password = Console.ReadLine ();
                    Console.WriteLine("Welcome, " + userName + ".");
                break;
                case "2": // register
                    Console.WriteLine("Choose a userName");
                    string maybeUserName = Console.ReadLine();
                    Console.WriteLine("Your typed " + maybeUserName + ".");
                    Console.WriteLine("Type a password.");
                    string maybePassword = Console.ReadLine();
                    Console.WriteLine("First Name: ");
                    string maybeFirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    string maybeLastName = Console.ReadLine();  
                    Console.WriteLine("Your role: ");
                    Console.WriteLine("[1] Employee");
                    Console.WriteLine("[2] Manager");
                    string maybeRole = Console.ReadLine();  
                    switch(maybeRole)
                    {
                        case "1": // Employee
                            maybeRole = "Employee";
                        break;
                        case "2": // Manager
                            maybeRole = "Manager";               
                        break;
                        default:
                            Console.WriteLine("Thank you.");
                        break;
                    }  
                    Console.WriteLine(maybeFirstName + " " + maybeLastName + " is a " + maybeRole + ".");
                    Environment.Exit(0);               
                break;
                case "3": // View User List
                    Console.WriteLine("The User list displays.");
                break;
                case "4": // View Ticket List
                    Console.WriteLine("The Ticket list displays.");
                break;
                case "5": // Exit
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("What kind of nonsense was that?");
                break;
            } 
            // UserDAO peeps = new UserDAO();
            // peeps.GetAllUsers();

            // Console.WriteLine("Here is a list of what they want you to pay for:");

            // TicketDAO claims = new TicketDAO();
            // claims.GetAllTickets();
        } while (true);
    }


}