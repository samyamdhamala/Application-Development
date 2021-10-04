using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:\n");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:\n");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            int action = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:
                    result = Addition(firstNum, secondNum);
                    break;

                case 2:
                    result = Substraction(firstNum, secondNum);
                    break;

                case 3:
                    result = Multiplication(firstNum, secondNum);
                    break;

                case 4:
                    result = Division(firstNum, secondNum);
                    break;

                default:
                    Console.WriteLine("No action chosen");
                break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }

        public static int Addition(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        public static int Substraction(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }

        public static int Multiplication(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }

        public static int Division(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            return result;
        }

    }
}
