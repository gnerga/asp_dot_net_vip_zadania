using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNetVip
{
    public class OperatoryLogiczne
    {
        public static void Run()
        {
            //Zadanie_1();
            //Zadanie_2();
            //Zadanie_3();

            //Zadanie_4(2000);
            //Zadanie_4(1900);
            //Zadanie_4(2024);
            //Zadanie_4();

            //Zadanie_5();

            //Zadanie_6();

            //Zadanie_7();
            //Zadanie_8();

            //Zadanie_9();
            //Zadanie_10();
            //Zadanie_11();
            //Zadanie_12();
            Zadanie_13();
        }

        public static void Zadanie_1()
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

        public static void Zadanie_2()
        {
            double userInput = -1;

            Console.Write("Please insert number to check if it is odd or even: ");
            double.TryParse(Console.ReadLine(), out userInput);

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is even.");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd.");
            }

        }

        public static void Zadanie_3()
        {
            double userInput = 0;

            Console.WriteLine("Please insert number to check if it is negative or not: ");
            double.TryParse(Console.ReadLine(), out userInput);

            if (userInput < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }

        public static void Zadanie_4(int? _userInput = null)
        {
            int userInput;

            if (_userInput == null)
            {
                Console.Write("Insert year to check if it is a leap or not: ");
                int.TryParse(Console.ReadLine(), out userInput);
            }
            else
            {
                userInput = (int)_userInput;
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

        public static void Zadanie_5()
        {
            int userInput;

            Console.WriteLine("Wprowadź swój wiek: ");
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput < 21)
            {
                Console.WriteLine("Jesteś za młody na stanowiska polityczne");
            }
            else
            {
                if (userInput >= 21)
                {
                    Console.WriteLine("Możesz zostać posłem lub premierem");
                }

                if (userInput >= 30)
                {
                    Console.WriteLine("Możesz zostać senatorem");
                }

                if (userInput >= 35)
                {
                    Console.WriteLine("Możesz zostać prezydentem");
                }
            }
        }

        public static void Zadanie_6()
        {
            int userInput;

            Console.Write("Insert your height: ");
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput <= 140)
            {
                Console.WriteLine("Congratulation! You are a dwarf!");
            }
            else
            {
                Console.WriteLine("Nice! You are a human or... maybe elf?!");
            }
        }

        public static void Zadanie_7()
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

        public static void Zadanie_8()
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

        public static void Zadanie_9()
        {
            Console.Write("Wprowadz temperature: ");
            double temperature;
            double.TryParse(Console.ReadLine(), out temperature);

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

        public static void Zadanie_10()
        {
            Console.WriteLine("Check if is possible to build a triangle from lines with given length");

            Console.Write("Enter a: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter b: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter c: ");
            int c;
            int.TryParse(Console.ReadLine(), out c);

            if ((a < b + c) || (b < a + c) || (c < a + b))
            {
                Console.WriteLine("You can build a triangle");
            }
            else
            {
                Console.WriteLine("You can't build a triangle");
            }            
        }

        public static void Zadanie_11()
        {
            Console.Write("Wprowadź ocenę: ");
            int mark;
            int.TryParse(Console.ReadLine(), out mark);

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

        public static void Zadanie_12()
        {
            Console.Write("Enter number of week day: ");
            int day;
            int.TryParse(Console.ReadLine(), out day);

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

        public static void Zadanie_13()
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

            bool isResultCalculated = false;

            switch (operationNum)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    isResultCalculated = true;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    isResultCalculated = true;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    isResultCalculated = true;
                    break;
                case 4:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nie można dzielic przez zero!");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        isResultCalculated = true;
                    }
                    break;
                default:
                    Console.WriteLine("Nie wspierana operacja");
                    break;
            }

            if (isResultCalculated)
            {
                Console.WriteLine($"Wynik: {result}");
            }
        }   
    }
}
