namespace EFDemo1.Entities
{
    public class Product
    {
        public int ProductId { get; set; } // Primary Key
        //[MaxLength(100)]
        //[Required]
        public string ProductName { get; set; }
        //[Required]
        //[Range(1000, 10000)]
        public int Price { get; set; }

        public string? Brand { get; set; }

        //[NotMapped]
        public int Profit { get; set; }
    }

    // [Table("tbl_categories")]
    public class Category
    {
        public int CategoryId { get; set; }

        //[Column("")]
        public string CategoryName { get; set; }
    }

    //public class Student
    //{
    //    [Key]
    //    public int RollNo { get; set; }
    //    public string Name { get; set; }
    //}
}


