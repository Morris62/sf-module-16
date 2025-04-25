namespace Module_16.Tickets;

public class TicketService : ITicketService
{
    private IEnumerable<Ticket> FakeBaseData =>
        new List<Ticket>
        {
            new(1, "Москва - Санкт-Петербург", 3500),
            new(2, "Челябинск - Магадан", 3500),
            new(3, "Норильск - Уфа", 3500)
        };

    public int? GetTicketPrice(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(x => x.Id == ticketId);
        return ticket?.Price ?? throw new TicketNotFoundException();
    }
}