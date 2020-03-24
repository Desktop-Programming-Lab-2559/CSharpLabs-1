using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker(
                "Jon",
                "Snow",
                new DateTime(2000, 1, 15),
                new DateTime(2010, 4, 1),
                10000
            );

            Console.WriteLine(w);
            Console.WriteLine(w.GetAge());
            Console.WriteLine(w.GetExperience());
            Console.WriteLine(w.GetTotalPayment());
            Console.ReadKey();
        }
    }
}
