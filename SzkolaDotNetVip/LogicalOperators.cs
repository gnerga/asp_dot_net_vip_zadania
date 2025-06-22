using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNetVip
{
    public class LogicalOperators
    {
        public static void Run()
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
            Task_6();
            Task_7();
            Task_8();
            Task_9();
            Task_10();
            Task_11();
            Task_12();
            Task_13();
        }

        public static void Task_1()
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są  równe.");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe.");
            }
        }

        public static void Task_2()
        {
            double userInput;

            Console.Write("Please insert number to check if it is odd or even: ");
            if (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input");
            }

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is even.");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd.");
            }
        }

        public static void Task_3()
        {
            double userInput = 0;

            Console.WriteLine("Please insert number to check if it is negative or not: ");
            if (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input");
                return;    
            }
            
            if (userInput < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }

        public static void Task_4()
        {
            int userInput;


            Console.Write("Insert year to check if it is a leap or not: ");
            if (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            bool isDivisibleBy4   = userInput % 4 == 0;
            bool isDivisibleBy100 = userInput % 100 == 0;
            bool isDivisibleBy400 = userInput % 400 == 0;

            if ((isDivisibleBy4 && isDivisibleBy100 && isDivisibleBy400) || (isDivisibleBy4 && !isDivisibleBy100))
            {
                Console.WriteLine($"Year: {userInput} is leap.");
            }
            else
            {
                Console.WriteLine($"Year: {userInput} isn't leap.");
            }
        }

        public static void Task_5()
        {
            int userInput;

            Console.WriteLine("Enter your age: ");

            if (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();

            if (userInput < 21)
            {
                stringBuilder.Append("You are too young");
                Console.WriteLine(stringBuilder.ToString());
                return;
            }
            else
            {
                stringBuilder.Append("You can become a member of parliamentm, prime minister");
            }

            if (userInput >= 30)
            {
                stringBuilder.Append(", senator");
            }

            if (userInput >= 35)
            {
                stringBuilder.Append(", president");
            }

            Console.WriteLine(stringBuilder.ToString());
        }

        public static void Task_6()
        {
            int userInput;

            Console.Write("Insert your height: ");
            if (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (userInput <= 140)
            {
                Console.WriteLine("Congratulation! You are a dwarf!");
            }
            else
            {
                Console.WriteLine("Nice! You are a human or... maybe elf?!");
            }
        }

        public static void Task_7()
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out secondNumber);

            int max = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.Write("Enter third number: ");
            int.TryParse(Console.ReadLine(), out thirdNumber);

            max = thirdNumber > max ? thirdNumber : max;

            Console.WriteLine($"The number with max value is {max}");
        }

        public static void Task_8()
        {
            Console.WriteLine("Check candidate graduation exam results");

            Console.Write("Enter math exam result: ");
            int mathResult;
            int.TryParse(Console.ReadLine(), out mathResult);

            Console.Write("Enter physic exam result: ");
            int physicsResult;
            int.TryParse(Console.ReadLine(), out physicsResult);

            Console.Write("Enter chemistry exam result: ");
            int chemistryResult;
            int.TryParse(Console.ReadLine(), out chemistryResult);

            bool checkTotalResult = mathResult + physicsResult + chemistryResult > 180 ? true : false;
            bool isMinResultMet = mathResult > 70 && chemistryResult > 55 && chemistryResult > 45;
            bool mixedResult = (mathResult + physicsResult > 150) || (mathResult + chemistryResult > 150);

            if ((isMinResultMet && checkTotalResult) || (mixedResult))
            {
                Console.WriteLine("Candidate accepted for recruitment");
            }
            else
            {
                Console.WriteLine("Candidate rejected from recruitment");
            }
        }

        public static void Task_9()
        {
            Console.Write("Wprowadz temperature: ");
            double temperature;
            if (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Niewłaściwe dane wejściowe");
                return;
            }

            if (temperature < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("Zaczyna być słabom, bo gorąco");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę!");
            }
        }

        public static void Task_10()
        {
            Console.WriteLine("Check if is possible to build a triangle from lines with given length");

            Console.Write("Enter a: ");
            int a;
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input value!");
                return;
            }

            Console.Write("Enter b: ");
            int b;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input value!");
                return;
            }

            Console.Write("Enter c: ");
            int c;
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Invalid input value!");
                return;
            }

            if ((a < b + c) || (b < a + c) || (c < a + b))
            {
                Console.WriteLine("You can build a triangle");
            }
            else
            {
                Console.WriteLine("You can't build a triangle");
            }            
        }

        public static void Task_11()
        {
            Console.Write("Wprowadź ocenę: ");
            int mark;
            if (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Niewłasciwe dane wejściowe!");
                return;
            }

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
                default:
                    Console.WriteLine("Ocena po za skalą oceniania");
                    break;
            }
        }

        public static void Task_12()
        {
            Console.Write("Enter number of week day: ");
            int day;
            if (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Invalid input value");
                return;
            }

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("There is no such day !");
                    break;
            }
        }

        public static void Task_13()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber;
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber;
            int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Wybierz operację [1-4]:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            Console.Write("Wybierz operację: ");
            int operationNum;
            int.TryParse(Console.ReadLine(), out operationNum);

            int result = -1;

            switch (operationNum)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nie można dzielic przez zero!");
                        return;
                    }
                    else
                    {
                        result = firstNumber / secondNumber; 
                    }
                    break;
                default:
                    Console.WriteLine("Nie wspierana operacja");
                    break;
            }

            Console.WriteLine($"Wynik: {result}");
        }   
    }
}
