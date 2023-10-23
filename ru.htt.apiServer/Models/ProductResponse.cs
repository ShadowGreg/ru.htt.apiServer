namespace ru.htt.apiServer.Models; 

public class ProductResponse {
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string ProductName { get; set; }

    public double Price { get; set; }
}