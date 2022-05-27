using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diary dy1 = new Diary(5);
            Diary dy2 = dy1;

            dy2.Flip();

            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage);

            // While reference-type variables refer to a place in memory,
            // value-type variables hold the actual data.

            Book bookLocation = new Book("Armstrong","Bozkurt");
            Book sameBookLocation = bookLocation;

            bookLocation.Title = "Kozkurt";

            Console.WriteLine(bookLocation.Title);
            Console.WriteLine(sameBookLocation.Title);
            Console.WriteLine("----------------------------------------------------------");

            bool falseValue = false;
            bool anotherFalseValue = falseValue;

            falseValue = true;

            Console.WriteLine(falseValue);
            Console.WriteLine(anotherFalseValue);
            Console.WriteLine("----------------------------------------------------------");

            // Reference vs. Value Comparison
            Book b1 = new Book();
            Book b2 = b1;
            Console.WriteLine(b1 == b2);

            // References of Different Types
            Dissertation diss = new Dissertation();
            IFlippable fdiss = diss;
            Book bdiss = diss;
            fdiss.CurrentPage = 42;
            // these lines are not allowed
            //bdiss.CurrentPage = 43;
            //fdiss.Stringify();
            bdiss.Stringify();
            Console.WriteLine(fdiss == bdiss);
            Console.WriteLine("----------------------------------------------------------");

            // Arrays of References
            Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
            Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Diary dy01 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
            Diary dy02 = new Diary(23, "Lili Elbe", "Man into Woman");

            Book[] books = new Book[] { diss1, diss2, dy01, dy02 };

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine("----------------------------------------------------------");

            // Polymorphism
            Book bo1 = new Book();
            Book bo2 = new Diary();
            Console.WriteLine(bo1.Stringify());
            Console.WriteLine(bo2.Stringify());
            Console.WriteLine("----------------------------------------------------------");

            // Casting
            /* 
            * Upcasting is creating a superclass or interface reference from a subclass reference
            * Downcasting is creating a subclass reference from a superclass or interface reference.
            * Upcasting can be done implicitly, while downcasting cannot
            */

            Dissertation disS = new Dissertation();
            Diary dY = new Diary();

            Book Bdiss = diss;
            Book Bdy = dY;

            // Null and Unassigned References
            Book bookOne = null;
            Console.WriteLine(bookOne == null);
            Console.WriteLine("----------------------------------------------------------");

            //to keep console open
            Console.ReadLine();
        }
    }
}
