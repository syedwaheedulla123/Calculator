using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, result;
            string operation;
            Console.WriteLine("Please enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            num2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose the operation (+, -, *, /, %): ");
            operation = Console.ReadLine();
            switch (operation) {
                    
            case "+":
                    result=num1+num2;
                    break;
                case "-":
                    result=num1-num2;
                    break;
                case "*":
                    result=num1*num2;
                    break;
                case "/":

                    if (num2!=0)
                    {
                        result=num1/num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                case "%":

                    result=num1%num2;
                    break;
                default:
                    Console.WriteLine("invalid option");
                    return;
                }
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

        }
    }
}
