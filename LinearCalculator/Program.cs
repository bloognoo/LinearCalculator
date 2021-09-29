using System;

namespace LinearCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome to the Linear Calculator

                    No Precedence, just the operators you demand, when you want them

                    Specify the number and it's following operator + - * /,
                    Specify the = operator to finish
                    ");

            bool done = false;
            int total = 0;

            string expr = "";
            int number = 0;

            do {
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Enter Expression:");
                expr = Console.ReadLine();
                if(expr[0] != '='){number = int.Parse(expr.Substring(1));}
                switch (expr[0]) {
                    case '+': total += number; break;
                    case '-': total -= number; break;
                    case '*': total *= number; break;
                    case '/': total /= number; break;
                    case '=': done = true; break;
                    default: Console.WriteLine("\n\nInvalid Operator!\n\n"); break;
                };
            } while (!done);

            Console.WriteLine("\nFinal Total: " + total);
        }
    }
}
