using System.ComponentModel.DataAnnotations;

namespace ru.htt.apiServer.Core.Domain; 

public class Category: BaseEntity {
    [MaxLength(80)]
    public string CategoryName { get; set; }
}