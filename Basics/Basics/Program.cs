using System;
using System.Linq;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pb1();
            Pb2();
            Pb3();

        }
        /// <summary>
        /// 1. Write a method that reads from the console three numbers of type int and prints their sum.
        /// </summary>
        static void Pb1()
        {
            Console.WriteLine("Please enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers entered are: " + number1 + ", " + number2 + ", " + number3 + ".");
            Console.WriteLine("And the sum of them is : ");
            Console.WriteLine(number1 + number2 + number3);

        }
        /// <summary>
        /// 2. Write a method that reads five numbers from the console and prints the greatest of them.
        /// </summary>
        static void Pb2()
        {
            Console.WriteLine("Please enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number5 = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers entered are: " + number1 + "," + number2 + "," + number3 + "," + number4 + "," + number5 + ".");
            int[] numbers = new[] { number1, number2, number3, number4, number5 };
            int greatestNumber = numbers.Max();
            Console.WriteLine("And the biggest one is : " + greatestNumber);

        }
        /// <summary>
        /// 3.Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        /// </summary>
        static void Pb3()
            
        
    }   
        

}
