using ru.htt.apiServer.Core.Domain;

namespace ru.htt.apiServer.DataAccess.Data;

public static class FakeDataFactory {
    public static IEnumerable<Category> Categoryes => new List<Category>() {
        new Category() {
            Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
            CategoryName = "Напитки",
        },
        new Category() {
            Id = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
            CategoryName = "Крупы",
        }
    };

    public static IEnumerable<Product> Products => new List<Product>() {
        new Product() {
            Id = Guid.Parse("ef7f299f-92d7-459f-896e-078ed53ef99c"),
            CategoryId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
            ProductName = "Сок",
            Price = 12.99
        },
        new Product() {
            Id = Guid.Parse("c4bda62e-fc74-4256-a956-4760b3858cbd"),
            CategoryId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
            ProductName = "Молоко",
            Price = 15.99
        },
        new Product() {
            Id = Guid.Parse("76324c47-68d2-472d-abb8-33cfa8cc0c84"),
            CategoryId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
            ProductName = "Вода",
            Price = 4.99
        },
        new Product() {
            Id = Guid.Parse("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
            CategoryId = Guid.Parse("c4bda62e-fc74-4256-a956-4760b3858cbd"),
            ProductName = "Ром",
            Price = 9.99
        },
        new Product() {
            Id =  Guid.Parse("a6c8c6b1-4349-45b0-ab31-244740aaf0f0"),
            CategoryId = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
            ProductName = "Эль",
            Price = 5.99
        },
        new Product() {
            Id = Guid.Parse("76324c47-68d2-345d-abb8-33cfa8cc0c84"),
            CategoryId = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
            ProductName = "Гречка",
            Price = 13.99
        },
        new Product() {
            Id = Guid.Parse("76324c47-76d2-472d-abb8-33cfa8cc0c84"),
            CategoryId = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
            ProductName = "Рис",
            Price = 17.99
        }
    };

    public static IEnumerable<JoinRequest> JoinRequest
    {
        get
        {
            var result = from product in Products
                join category in Categoryes on product.CategoryId equals category.Id
                select new JoinRequest
                {
                    ProductName = product.ProductName,
                    CategoryName = category.CategoryName,
                    Price = product.Price
                };

            return result;
        }
    }

}