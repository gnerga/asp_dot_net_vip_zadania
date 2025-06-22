namespace SzkolaDotNetVip
{
    internal enum Gender
    { 
        M,
        F
    }
    public class Zmienne
    {
        public static void Run()
        {
            Zadanie_2();
            Zadanie_3();
            Zadanie_5();
        }

        public static void Zadanie_1()
        {
            string firstName        = "Grzegorz";
            string lastName         = "Nowak";
            int    age              = 30;
            Gender   gender           = Gender.M;
            string personalNumber   = "25062014013";
            string employeeNumber   = "2509324094";
        }

        public static void Zadanie_2()
        {
            Console.WriteLine("Task number two output: ");

            char firstLetter    = 'g';
            char secondLetter   = 'n';
            char thirdLetter    = 'j';

            Console.Write($"{thirdLetter} {secondLetter} {firstLetter}");
        }

        public static void Zadanie_3()
        {
            Console.WriteLine("Calculate the diagonal of the rectangle:");

            double height   = 11.5;
            double width    = 9.32;

            // c^2 = a^2 + b^2
            double diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));

            Console.WriteLine($"Calculated rectangle's diagonal for heigth {height} and width {width} is: {diagonal:n2}\n");
        }

        public static void Zadanie_4() 
        {
            int     intVariable    = 10;
            string  stringVariable = "Szkola dotneta";
            decimal doubleVariable = 12.5m;
        }

        public static void Zadanie_5()
        {
            string firstName;
            string lastName;
            string phoneNumber;
            string email;
            int height;
            double weight;
            string hobby;

            Console.Write("Your name: ");
            firstName = Console.ReadLine();

            Console.Write("Your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Your phone number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Your email: ");
            email = Console.ReadLine();

            Console.Write("Insert your height");
            if (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input!");
            }

            Console.Write("Insert your weight");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input!");
            }

            Console.Write("Insert the name of your hobby:");
            hobby = Console.ReadLine();
        }
    }
}
