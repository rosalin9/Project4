using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            BasicCalculator calculate = new BasicCalculator(x,y);

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            int op,res;
            double res1;

            do
            {
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        res=calculate.Addition();
                        Console.WriteLine("Addition is: "+ res);
                        break;
                    case 2:
                        res=calculate.Subtraction();
                        Console.WriteLine("Subtraction is: "+ res);
                        break;
                    case 3:
                        res=calculate.Multiplication();
                        Console.WriteLine("Multiplication is: "+ res);
                        break;
                    case 4:
                        res1=calculate.Division();
                        Console.WriteLine("Division is: "+ res1);
                        break;
                    case 5:
                        break;
                }
            }while (op  < 5 && op  > 0);


        }
    }
}
