using Module_16.Tickets;

namespace Module_16.Tests;

[TestFixture]
public class TicketServiceIntegrationTests
{
    [Test]
    public void SaveTicketMustAddTicketInBase()
    {
        var ticketServiceTest = new TicketService();
        var newTicket = new Ticket(5, "Test ticket", 10_000);

        ticketServiceTest.SaveTicket(newTicket);

        var allTicketsAfterAddNewTicket = ticketServiceTest.GetAllTickets();
        Assert.That(allTicketsAfterAddNewTicket, Has.Member(newTicket));

        ticketServiceTest.DeleteTicket(newTicket);
        Assert.That(allTicketsAfterAddNewTicket, Has.No.Member(newTicket));
    }
}