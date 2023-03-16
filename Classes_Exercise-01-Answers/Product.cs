using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_01_Answers
{
    public class Product
    {
        // TODO: Create a private field _productID of type long
        private long _productID;
        // TODO: Create a private field _productCount of type int
        private int _productCount;

        // TODO: Create a public Name property of type string
        public string Name { get; set; }
        // TODO: Create a public Price property of type double
        public double Price { get; set; }
        // TODO: Create a public CategoryID property of type int
        public int CategoryID { get; set; }
        // TODO: Create a public OnSale property of type bool
        public bool OnSale { get; set; }
        // TODO: Create a public StockLevel property of type int
        public int StockLevel { get; set; }

        // TODO: Create a default constructor that increments the _productCount every time a new product is created
        public Product()
        {
            _productCount++;
        }
        // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties
        public Product(string name, double price, int category, bool onSale, int stockLevel)
        {
            _productCount++;
            Name= name;
            Price = price;
            CategoryID = category;
            OnSale = onSale;    
            StockLevel = stockLevel;
        }

        // TODO: Create a method that gets the _productID and displays it creatively
        public static void ShowProductID(Product a)
        {
            Console.WriteLine($"Product ID: {a._productID}");
        }
        // TODO: Create a method that sets the _productID
        public static void AssignProductValue(Product a, int id)
        {
            a._productID = id;
        }
        // TODO: Create a method that shows the current product count
        public static void ShowProductCount(Product a) 
        {
            Console.WriteLine($"Product Count: {a._productCount}");
        }
    }
}
