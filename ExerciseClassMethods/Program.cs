using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick an integer to perform math operations on");
            int pickNum = Convert.ToInt32(Console.ReadLine());

            int result1 = MathOperations.AddbyTen(pickNum);
            Console.WriteLine("Your number " + pickNum + " plus 10 eqauls " + result1);

            int result2 = MathOperations.MultbyTen(pickNum);
            Console.WriteLine("Your number " + pickNum + " multiplied by 10 eqauls " + result2);

            int result3 = MathOperations.Square(pickNum);
            Console.WriteLine("Your number " + pickNum + " squared equals" + result3);

            Console.ReadLine();




        }
    }
}
