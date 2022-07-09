namespace Models;

// using customExceptions;

// TICKETS
    // Create Ticket Class

    // ticket creation
    // ticket review
        // View by Manager
            // View tickets from everyone
                // Filter requests by status
            // View tickets from individual
                // approve
                // Deny

        // View by Employee
            // approval request
            
public class Ticket
{
public Ticket(
    int ticketID,
    int author_fk,
    decimal amount,
    int resolver_fk,
    string status,
    string description
)
{
    this.ticketID = ticketID;
    this.author_fk = author_fk;
    this.amount = amount;
    this.resolver_fk = resolver_fk;
    this.status = status;
    this.description = description;
}

public enum status {
Pending, 
Approved,
Denied
}

public int ticketID {get; set;}
public int author_fk {get; set;}
public decimal amount {get; set;}
public int resolver_fk {get; set;}
public string status {get; set;}
public string description {get; set;}

// methods for 
    // submitting ticket
    // requesting approval
    // viewing tickets for one user
    // viewing all tickets
    // filtering tickets
}

