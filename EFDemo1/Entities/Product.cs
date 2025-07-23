namespace EFDemo1.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public string? Brand { get; set; }

        public Category Category { get; set; }


    }


    public class Category
    {
        public int CategoryId { get; set; }


        public string CategoryName { get; set; }
    }


}


