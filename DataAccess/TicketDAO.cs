using Models;

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

    }

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
}