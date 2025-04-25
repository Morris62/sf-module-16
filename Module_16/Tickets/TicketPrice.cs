namespace Module_16.Tickets;

public class TicketPrice(ITicketService ticketService)
{
    private readonly ITicketService ticketService = ticketService;

    public int? MakeTicketPrice(int ticketId)
    {
        return ticketService.GetTicketPrice(ticketId);
    }
}