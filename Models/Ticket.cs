namespace Models;

// using customExceptions;
            
public class Ticket
{
    public int ticketID {get; set;}
    public int author_fk {get; set;}
    public decimal amount {get; set;}
    public int resolver_fk {get; set;}
    public string status {get; set;}
    public string description {get; set;}

    // for retrieving objects from database
    public Ticket(
        int ticketID,
        int author_fk,
        decimal amount,
        int resolver_fk,
        string status,
        string description)
    {
        this.ticketID = ticketID;
        this.author_fk = author_fk;
        this.amount = amount;
        this.resolver_fk = resolver_fk;
        this.status = status;
        this.description = description;
    }

    // for putting objects into database
    public Ticket(
        int author_fk,
        decimal amount,
        int resolver_fk,
        string status,
        string description)
    {
        this.author_fk = author_fk;
        this.amount = amount;
        this.resolver_fk = resolver_fk;
        this.status = status;
        this.description = description;
    }
/*
    public enum status {
    Pending, 
    Approved,
    Denied
    }
*/
    public override string ToString()
    {
        return "ID: " + this.ticketID +
        ", Author: " + this.author_fk +
        ", Amount: " + this.amount +
        ", Description: " + this.description +
        ", Status: " + this.status +               
        ", Manager: " + this.resolver_fk;
    }

}

