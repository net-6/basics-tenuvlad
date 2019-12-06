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
            Pb4();
            Pb5();
            Pb6();
            Pb7();
            Pb8();
            Pb9();
            Pb10();
            Pb11();
            Pb14();
        }
        /// <summary>
        /// 1. Write a method that reads from the console three numbers of type int and prints their sum.
        /// </summary>
        static void Pb1()
        {
            Console.WriteLine("Problem 1");
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
            Console.WriteLine("Problem 2");
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

        {
            Console.WriteLine("Problem 3");
            Console.WriteLine("If you want to find the perimeter and area of cercle please insert the radius.");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * (r * r);
            Console.WriteLine("The area is :  {0}", area );
            Console.WriteLine("The perimeter is :  {0}", perimeter);

        }

        /// <summary>
        /// 4. Write a method that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the  remainder of their division by 5 is 0. 
        /// </summary>
        static void Pb4()
        {
            Console.WriteLine("Problem 4");
            Console.WriteLine("Please insert a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number2 = int.Parse(Console.ReadLine());
            int lownumber = Math.Min(number1, number2);
            int highnumber = Math.Max(number1, number2);
            int i = lownumber;
            int counter = 0;
            while (i < highnumber)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
                i++;
            }
            Console.WriteLine("Between " + lownumber + " and " + highnumber + " are " + counter + " divizible with 5.");
        }
        /// <summary>
        /// 5. Write a method that reads two numbers from the console and prints the greater of them.Solve the problem without using conditional statements and with conditional statements.
        /// </summary>
        static void Pb5()
        {
            int greatestNumber;
            Console.WriteLine("Problem 5");
            Console.WriteLine("Please insert a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
                greatestNumber = number1;
            else
                    greatestNumber = number2;
            Console.WriteLine("The greatest number is : {0}", greatestNumber);
        }
        /// <summary>
        /// 6.Write a method that reads five integer numbers and prints their sum. If an invalid number is entered the method should prompt the user to enter another number(only once)
        /// </summary>
        static void Pb6()
        {
            Console.WriteLine("Problem 6");
            int number1, number2, number3, number4, number5;
            bool correctNumber = true;
            Console.WriteLine("Please inser first number");
            bool numberOne = int.TryParse(Console.ReadLine(), out number1);
            if (!numberOne)
            {
                Console.WriteLine("Please insert a valid number");
                bool secondNumberOne = int.TryParse(Console.ReadLine(), out number1);
                if (!secondNumberOne)
                {
                    correctNumber = false;
                }
            }
            Console.WriteLine("Please inser second number");
            bool numberTwo = int.TryParse(Console.ReadLine(), out number2);
            if (!numberTwo)
            {
                Console.WriteLine("Please insert a valid number");
                bool secondNumberTwo = int.TryParse(Console.ReadLine(), out number2);
                if (!secondNumberTwo)
                {
                    correctNumber = false;
                }
            }
            Console.WriteLine("Please inser third number");
            bool numberTree = int.TryParse(Console.ReadLine(), out number3);
            if (!numberTree)
            {
                Console.WriteLine("Please insert a valid number");
                bool secondNumberTree = int.TryParse(Console.ReadLine(), out number3);
                if (!secondNumberTree)
                {
                    correctNumber = false;
                }
            }
            Console.WriteLine("Please inser fourth number");
            bool numberFour = int.TryParse(Console.ReadLine(), out number4);
            if (!numberFour)
            {
                Console.WriteLine("Please insert a valid number");
                bool secondNumberFour = int.TryParse(Console.ReadLine(), out number4);
                if (!secondNumberFour)
                {
                    correctNumber = false;
                }
            }
            Console.WriteLine("Please inser fifth number");
            bool numberFive = int.TryParse(Console.ReadLine(), out number5);
            if (!numberFive)
            {
                Console.WriteLine("Please insert a valid number");
                bool secondNumberFive = int.TryParse(Console.ReadLine(), out number5);
                if (!secondNumberFive)
                {
                    correctNumber = false;
                }
            }
            Console.WriteLine("The sum of them is : ");
            Console.WriteLine(number1 + number2 + number3 + number4 + number5);
        }
        ///<summary>
        /// Write a method that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        /// </summary>
        static void Pb7()
        {
            Console.WriteLine("Problem 7");
            Console.WriteLine("Please insert a number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
        ///<summary>
        /// Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
        /// </summary>
        static void Pb8()
        {
            Console.WriteLine("Problem 8");
            Console.WriteLine("Please insert a number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("The number is {0} ", i);
                }
            }
        }
        ///<summary>
        /// Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
        /// </summary>
        static void Pb9()
        {
            Console.WriteLine("Problem 9");
            Console.WriteLine("Please insert a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another number");
            int number5 = int.Parse(Console.ReadLine());
            int[] numbers = new[] { number1, number2, number3, number4, number5 };
            int greatestNumber = numbers.Max();
            int lowerNumber = numbers.Min();
            Console.WriteLine("The biggest number is : " + greatestNumber + " And the lowerst number is: " + lowerNumber);
        }
        ///<summary>
        /// Write method that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.
        /// </summary>
        static void Pb10()
        {
            Console.WriteLine("Problem 10");
            Console.WriteLine("Please insert a number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                string results = new string('*', i);
                Console.WriteLine(results);
            }
            for (int i = 0; i < number; i++)
            {
                string results = new string('*', number - i);
                Console.WriteLine(results);
            }
        }
        ///<summary>
        /// Write a method that converts a given number from decimal to binary notation (numeral system).
        /// </summary>
        static void Pb11()
        {
            Console.WriteLine("Problem 11");
            Console.WriteLine("Please insert a number");
            int binarNumber = int.Parse(Console.ReadLine());
            // mai simplu sring binar = Convert.ToString(nr, 2);    
            string rezultat = "";
            while (binarNumber > 1)
            {
                int numar = binarNumber % 2;
                rezultat = Convert.ToString(numar) + rezultat;
                binarNumber /= 2;

            }
            Console.WriteLine(binarNumber.ToString() + rezultat);
        }
        ///<summary>
        ///A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.Write a program that reads information about the company and its manager and then prints it on the console.
        /// </summary>
        static void Pb14()
        {
            Console.WriteLine("Introduceti numele companiei:");
            String numeCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon al companiei:");
            String telefonCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de fax al companiei:");
            String faxCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti  siteul al companiei:");
            String siteCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele Managerului:");
            String prenumenumeManager = Console.ReadLine();
            Console.WriteLine("Introduceti numele Managerului:");
            String numeManager = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon al Managerului:");
            String telefonManager = Console.ReadLine();
            Console.WriteLine($"Datele companiei sunt urmatoarele:\n Nume Companie: {numeCompanie}\n Telefon: {telefonCompanie}\n Fax: {faxCompanie}\n site {siteCompanie}\n Manager: {prenumenumeManager} {numeManager}\n Telefon manager: {telefonManager}");
        }
    }
}

        }
    }


}
