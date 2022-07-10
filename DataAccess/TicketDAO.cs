using Models;
using Services;
using System.Data.SqlClient;

namespace DataAccess;

// The only purpose of DAO or DataAccess layer is to talk to the database

// methods for 
    // update/process = approve or deny 
    // Get a ticket by ticketID
    // Get all tickets by userID
    // filtering tickets by status
    // viewing all tickets


public class TicketDAO {
    public List<Ticket> GetAllTickets(){

        List<Ticket> tickets = new List<Ticket>();

        string getAllTickets = "select * from AutumnERS.tickets;";

        SqlConnection makeConnection = new SqlConnection(SecretServices.connectionString);

        SqlCommand getEveryTicket = new SqlCommand(getAllTickets, makeConnection);

        try
        {
            makeConnection.Open();
            SqlDataReader reader = getEveryTicket.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                tickets.Add(new Ticket((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], (decimal)reader[5]));
            }
            reader.Close();
            makeConnection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return tickets;
    }
/*
    public List<Ticket> GetTicketsByStatus(status){

    }    

    public bool CreateTicket(Ticket Ticket){

    }

    public List<Ticket> GetTicketByID(ticketID){

    }

    public List<Ticket> GetTicketsByUserName(userName){
        
    }

    public List<Ticket> resolveTicket(){
        
    }  

*/
}
