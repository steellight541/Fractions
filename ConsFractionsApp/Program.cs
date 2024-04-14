using LibraryFractions;

namespace ConsFractionsApp
{
    class Program
    {

        private bool selected;
        public static void Menu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Reciprocal");
            Console.WriteLine("6. Exit");
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void AwaitKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Add()
        {
            Console.Write("Enter the first fractions numerator: ");
            int numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first fractions denominator: ");
            int denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions numerator: ");
            int numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions denominator: ");
            int denominator2 = Convert.ToInt32(Console.ReadLine());
            Fraction fraction1 = new Fraction(numerator1, denominator1);
            Fraction fraction2 = new Fraction(numerator2, denominator2);
            Fraction result = fraction1.Add(fraction2);
            Console.WriteLine("The result is: " + result.Numerator + "/" + result.Denominator + " and " + result.Result() + " as a decimal.");
        }

        public static void Subtract()
        {
            Console.Write("Enter the first fractions numerator: ");
            int numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first fractions denominator: ");
            int denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions numerator: ");
            int numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions denominator: ");
            int denominator2 = Convert.ToInt32(Console.ReadLine());
            Fraction fraction1 = new Fraction(numerator1, denominator1);
            Fraction fraction2 = new Fraction(numerator2, denominator2);
            Fraction result = fraction1.Subtract(fraction2);
            Console.WriteLine("The result is: " + result.Numerator + "/" + result.Denominator + " and " + result.Result() + " as a decimal."); 
        }

        public static void Multiply()
        {
            Console.Write("Enter the first fractions numerator: ");
            int numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first fractions denominator: ");
            int denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions numerator: ");
            int numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions denominator: ");
            int denominator2 = Convert.ToInt32(Console.ReadLine());
            Fraction fraction1 = new Fraction(numerator1, denominator1);
            Fraction fraction2 = new Fraction(numerator2, denominator2);
            Fraction result = fraction1.Multiply(fraction2);
            Console.WriteLine("The result is: " + result.Numerator + "/" + result.Denominator + " and " + result.Result() + " as a decimal.");

        }

        public static void Divide()
        {
            Console.Write("Enter the first fractions numerator: ");
            int numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first fractions denominator: ");
            int denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions numerator: ");
            int numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second fractions denominator: ");
            int denominator2 = Convert.ToInt32(Console.ReadLine());
            Fraction fraction1 = new Fraction(numerator1, denominator1);
            Fraction fraction2 = new Fraction(numerator2, denominator2);
            Fraction result = fraction1.Divide(fraction2);
            Console.WriteLine("The result is: " + result.Numerator + "/" + result.Denominator + " and " + result.Result() + " as a decimal.");
        }

        public static void Reciprocal()
        {
            Console.Write("Enter the fractions numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fractions denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            Fraction fraction = new Fraction(numerator, denominator);
            Fraction result = fraction.Reciprocal();
            Console.WriteLine("The result is: " + result.Numerator + "/" + result.Denominator + " and " + result.Result() + " as a decimal.");
        }



        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Welcome to the Fraction Calculator!");
                Menu();
                Console.Write("Enter your selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    case 5:
                        Reciprocal();
                        break;
                    case 6:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
                AwaitKeyPress();
            }
        }
    }
}
