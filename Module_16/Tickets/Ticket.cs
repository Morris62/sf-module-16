namespace Module_16.Tickets;

public class Ticket(int id, string description, int price)
{
    public int Id { get; set; } = id;
    public string Description { get; set; } = description;
    public int Price { get; set; } = price;
}