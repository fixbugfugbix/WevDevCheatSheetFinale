using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompleteCheatSheet.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }

    public class Cart
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}