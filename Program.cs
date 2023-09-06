using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to see Factorial of That number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            
            for (int i = 1; i <=number; i++)
            {
                res = res * i;
                Console.WriteLine(res);
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
