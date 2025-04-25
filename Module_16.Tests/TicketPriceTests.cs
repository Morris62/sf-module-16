using Module_16.Tickets;
using Moq;

namespace Module_16.Tests;

[TestFixture]
public class TicketPriceTests
{
    [Test]
    public void TicketPriceMustReturnNotNullValue()
    {
        var mockTicketService = new Mock<ITicketService>();
        mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
        mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(200);
        mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

        var ticketPrice = new TicketPrice(mockTicketService.Object);
        Assert.That(ticketPrice.MakeTicketPrice(3), Is.EqualTo(7800));
    }
}