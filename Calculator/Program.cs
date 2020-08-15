using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float operand1 = 0;
            bool oper1valid = false;
            if (float.TryParse(args[0], out operand1))
            {
                operand1 = float.Parse(args[0]);
                oper1valid = true;
            }
            float operand2 = 0;
            bool oper2valid = false;
            if (float.TryParse(args[1], out operand2))
            {
                operand2 = float.Parse(args[1]);
                oper2valid = true;
            }
            if (oper2valid && oper1valid)
            {
                Console.WriteLine("Input is valid: " + "\"" + operand1 + "\"" + " and " + "\"" + operand2 + "\"");
                Console.WriteLine("Operation to perform?");
                string operation = Console.ReadLine();
                if (operation.Length > 1)
                {
                    Console.WriteLine("Input is invalid");
                    Console.ReadKey();
                    return;
                }
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("= " + (operand1 + operand2));
                        break;
                    case "-":
                        Console.WriteLine("= " + (operand1 - operand2));
                        break;
                    case "*":
                        Console.WriteLine("= " + (operand1 * operand2));
                        break;
                    case "/":
                        if(operand2 != 0)
                        {
                            Console.WriteLine("= " + (operand1 / operand2));
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    default:

                        break;
                }

            }
            else
            {
                Console.WriteLine("Input is invalid");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
