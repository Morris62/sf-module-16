using Module_16.Tickets;

namespace Module_16.Tests;

[TestFixture]
public class TicketTests
{
    [Test]
    public void GetTicketPriceMustReturnExistingPrice()
    {
        var ticketServiceTest = new TicketService();
        Assert.That(ticketServiceTest.GetTicketPrice(1), Is.Not.Null.And.EqualTo(3500));
    }

    [Test]
    public void GetTicketPriceMustReturnException()
    {
        var ticketServiceTest = new TicketService();
        Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(1000));
    }
}