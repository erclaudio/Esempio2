using System;

namespace Esempio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("This will perform a calculation with 2 integers\n" +
                "Insert the first number and press enter: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the second number and press enter: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n1 for addition\n2 for subtraction\n3 for multiplication\n4 for division");
            int operation = Convert.ToInt32(Console.ReadLine());/*
            if (operation == 1) { Console.WriteLine(num1 + " inserted & " + num2 +" inserted, sum is: " + (num1+num2)); }
            if (operation == 2) { Console.WriteLine(num1 + " inserted & " + num2 + " inserted, subtraction is: " + (num2 - num1)); }
            if (operation == 3) { Console.WriteLine(num1 + " inserted & " + num2 + " inserted, multiplication is: " + (num1 * num2)); }
            if (operation == 4) { Console.WriteLine(num1 + " inserted & " + num2 + " inserted, division is: " + (Convert.ToDouble(num1) / Convert.ToDouble(num2))); }
            else { Console.WriteLine("Enter a valid selection\n\n"); Main(args); }
            Console.Read();
            */
            
            switch (operation)
            {
                case 1:
                    Console.WriteLine(num1 + " inserted & " + num2 + " inserted, sum is: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine(num1 + " inserted & " + num2 + " inserted, subtraction is: " + (num2 - num1));
                    break;
                case 3:
                    Console.WriteLine(num1 + " inserted & " + num2 + " inserted, multiplication is: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine(num1 + " inserted & " + num2 + " inserted, division is: " + (Convert.ToDouble(num1) / Convert.ToDouble(num2)));
                    break;

                default:
                    break;
            }
            Console.Read();
        }
    }
}
