using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNetVip
{
    public class Loops
    {
        public static void Run()
        {
            //Task_1();
            Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            //Task_7();
            //Task_8();
            //Task_9();
            //Task_10();
        }

        public static void Task_1()
        {
            int primeNumberCounter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    //Console.WriteLine($"{i} is prime number");
                    primeNumberCounter++;
                }
            }
            Console.WriteLine($"There are {primeNumberCounter} prime numbers in given range.");
        }

        internal static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Task_2()
        {
            int n = 0;
            StringBuilder result = new StringBuilder();
            do
            {
                if (n % 2 == 0)
                {
                    //Console.WriteLine($"{n} is an even value");
                    result.Append($"{n}, ");
                }
                n++;
            }
            while (n <= 1000);
            Console.WriteLine($"All even values in given range: {result.ToString()}");
        }

        public static void Task_3()
        {
            int n = 15;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        internal static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Task_4()
        {
            int number;

            Console.Write("Enter number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input value");
                return;
            }

            if (number < 1)
            {
                Console.WriteLine("Value must by at least equals or grater then 1");
                return;
            }

            int elementsInRow = 0;
            int currentRow = 1;

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                elementsInRow++;
                if (currentRow == elementsInRow)
                {
                    currentRow++;
                    elementsInRow = 0;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        public static void Task_5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"For {i} the power of 3 is {Math.Pow(i, 3)}");
            }
        }

        public static void Task_6()
        {
            double sum = 0.0;

            for (int i = 1; i <= 20; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        public static void Task_7()
        {
            int number;

            Console.Write("Enter number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input value");
                return;
            }

            int rows = number;
            bool isEven = rows % 2 == 0;

            int middle = rows / 2;

            for (int i = 0; i <= middle; i++)
            {
                if (isEven && middle == i)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < number; j++)
                {
                    if (j >= middle - i && j <= middle + i)
                    {
                        
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
              
                Console.WriteLine();
            }

            for (int i = middle; i > 0; i--)
            {
          
                for (int j = 0; j < number; j++)
                {
                    if (j >= middle - i + 1 && j <= middle + i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Task_8()
        {
            Console.Write("Enter random string: ");
            string? text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        public static void Task_9()
        {
            int number;
            Console.Write("Enter positive number: ");

            if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string result = "";

            while (number > 0)
            {
                result = number % 2 == 0 ? "0" : "1" + result;
                number /= 2;
            }

            Console.Write($"{result}");
        }

        public static void Task_10()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber;
            if (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter second number: ");
            int secondNumber;
            if (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int multipledNumbers = firstNumber * secondNumber;

            int factor;

            // find GCD
            while (secondNumber > 0)
            {
                factor = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = factor;
            }

            int result = multipledNumbers / firstNumber;

            Console.WriteLine($"{result}");
        }
    }
}
