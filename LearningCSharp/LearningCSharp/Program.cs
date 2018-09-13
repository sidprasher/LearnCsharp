using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Product.GetSampleProducts();

            // Sort style 1 -- call the IComparer object for each list item
            list.Sort(new ProductComparer());

            // sort style 2 --> delegate to an inline anonymous type
            // this uses delegates
            list.Sort(delegate (Product x, Product y) { return x.Name.CompareTo(y.Name); });

            // sort style 3 --> lambda expression
            list.Sort((x, y) => { return x.Name.CompareTo(y.Name); });

            // sort style 4 --> Linq

            list.OrderBy(p => p.Name);

            foreach (var i in list)
                Console.WriteLine(string.Format("Product:{0}; Price:{1}", i.Name, i.Price));
            Console.Read();
        }
    }

    public class GradeBook
    {

    }

    public class Student
    {
        GradeBook gb;
    }
}
