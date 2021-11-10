using CalculatorLibrary;
using System;

namespace CalculatorClient
{
    class Program
    {
        public static void PrintOptions()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }
        public static int GetChoice()
        {
            System.Console.Write("Enter Choice[1/2/3/4]: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int GetInput()
        {
            System.Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static void GetInput(out int first, out int second)
        {
            System.Console.Write("Enter 1st Number: ");
            first = int.Parse(Console.ReadLine());

            System.Console.Write("Enter 2nd Number: ");
            second = int.Parse(Console.ReadLine());
        }
        public static int UseCalculator(int choice, Calculation calculation, int firstNumber, int secondNumber)
        {
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = calculation.Add(firstNumber, secondNumber);
                    break;

                case 2:
                    result = calculation.Subtract(firstNumber, secondNumber);
                    break;

                case 3:
                    result = calculation.Multiply(firstNumber, secondNumber);
                    break;

                case 4:
                    result = calculation.Divide(firstNumber, secondNumber);
                    break;

                default:
                    break;
            }
            return result;
        }
        static void Decide(ref char decision)
        {
            System.Console.WriteLine("Continue?[y/Y/n/N]: ");
            decision = char.Parse(Console.ReadLine());
            if (char.IsUpper(decision))
            {
                decision = char.ToLower(decision);
            }
        }
        public static void Main()
        {
            Calculation calculation = new Calculation();
            char toContinue = 'n';
            do
            {
                PrintOptions();
                int choice = GetChoice();

                // int firstInput = GetInput();
                // int secondInput = GetInput();

                int firstInput;
                int secondInput;
                GetInput(out firstInput, out secondInput);

                int result = UseCalculator(choice, calculation, firstInput, secondInput);
                System.Console.WriteLine("Result: " + result);

                Decide(ref toContinue);

            } while (toContinue != 'n');
        }
    }
}
