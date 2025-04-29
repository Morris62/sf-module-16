namespace Module_16.Tickets;

public class TicketService : ITicketService
{
    private readonly List<Ticket> FakeBaseData = new()
    {
        new Ticket(1, "Москва - Санкт-Петербург", 3500),
        new Ticket(2, "Челябинск - Магадан", 3500),
        new Ticket(3, "Норильск - Уфа", 3500)
    };

    public int? GetTicketPrice(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(x => x.Id == ticketId);
        return ticket?.Price ?? throw new TicketNotFoundException();
    }

    public Ticket GetTicket(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(x => x.Id == ticketId);
        return ticket ?? throw new TicketNotFoundException();
    }

    public void SaveTicket(Ticket ticket)
    {
        FakeBaseData.Add(ticket);
    }

    public void DeleteTicket(Ticket ticket)
    {
        FakeBaseData.Remove(ticket);
    }

    public IEnumerable<Ticket> GetAllTickets()
    {
        return FakeBaseData;
    }
}