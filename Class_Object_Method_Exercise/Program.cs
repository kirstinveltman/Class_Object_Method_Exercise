using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Method_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a whole, real number: ");
            math.Number = Convert.ToInt32(Console.ReadLine());

            int result1 = math.Add(13);
            Console.WriteLine($"Your number added to 13 is: {result1}");

            int result2 = math.Subtract(13);
            Console.WriteLine($"Your number subtracted from 13 is: {result2}");

            int result3 = math.Multiply(13);
            Console.WriteLine($"Your number multiplied by 13 is: {result3}");

            Console.ReadLine();

        }
    }
}
