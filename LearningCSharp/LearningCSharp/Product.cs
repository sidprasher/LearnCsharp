using System.Collections.Generic;

namespace LearningCSharp
{
    public class Product
    {
        readonly string name;
        readonly double price;

        public string Name
        {
            get { return name; }
        }

        public double Price { get { return price; } }

        public Product(string n, double p)
        {
            name = n;
            price = p;
        }

        public static List<Product> GetSampleProducts()
        {
            var result = new List<Product>();
            result.Add(new Product("Lego", 10.2d));
            result.Add(new Product("Cars", 4.5));


            return result;
        }
    }

    public class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            else if (y == null)
                return 1;
            else return x.Name.CompareTo(y.Name);
        }
    }
}
