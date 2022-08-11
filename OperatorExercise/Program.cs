using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int num1 = 10;
            int num2 = 5;

            Console.Write($"Add: {num1 + num2}");
            Console.Write($"Subtract: {num1 - num2}");
            Console.Write($"Multiply: {num1 * num2}");

            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;
            
            
            if  (a == 17 && b == 4)
            {
              Console.WriteLine($"{a} is == to {a}");
              Console.WriteLine($"{a} /= {b} is {quotient} remainder of {remainder}");



            }
            //Exercise 2
           
              Console.WriteLine("What is the radius of your circle?");
              var userInput = double.Parse(Console.ReadLine());
              double area = Methods.AreaOfCircle(CuserInput);
              Console.WriteLine("Rounded to two decimal place");
            Console.WriteLine(Math.Round(area, 2));
               
            
        }
    }
    
}
