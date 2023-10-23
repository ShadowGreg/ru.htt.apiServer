namespace ru.htt.apiServer.Core.Domain; 

public class Product: BaseEntity {
    public Guid CategoryId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

}