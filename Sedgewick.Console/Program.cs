using System;

//1.1 - 1.2

namespace SedgewickBookSolutions
{
    class Programs
    {
        //Может я вас неправильно понял, но вы написали that you call SedgewickBookSolutions in one Main() method, поэтому я сделал все в одном мейне
        static void Main(string[] args)
        {
            //1.1.1 Hello World
            Console.WriteLine("Hello, World");

            //1.1.2 Using a command-line argument
            string name;
            Console.Write("Write your name: ");
            name = Console.ReadLine();
            Console.Write("Hi, ");
            Console.Write(name);
            Console.WriteLine(". How are you?");

            //1.2.1 String concatenation example
            String ruler1 = " 1 ";
            String ruler2 = ruler1 + "2" + ruler1;
            String ruler3 = ruler2 + "3" + ruler2;
            String ruler4 = ruler3 + "4" + ruler3;
            String ruler5 = ruler4 + "5" + ruler4;

            Console.WriteLine(ruler1);
            Console.WriteLine(ruler2);
            Console.WriteLine(ruler3);
            Console.WriteLine(ruler4);
            Console.WriteLine(ruler5);

            //1.2.2 Integer multiplication and division
            int a, b;
            Console.WriteLine("Enter 2 numbers that you want to use: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int prod = a * b;
            int quot = a / b;
            int rem = a % b;

            Console.WriteLine(a + " + " + b + " = " + sum);
            Console.WriteLine(a + " * " + b + " = " + prod);
            Console.WriteLine(a + " / " + b + " = " + quot);
            Console.WriteLine(a + " % " + b + " = " + rem);
            Console.WriteLine(a + " = " + quot + " * " + b + " + " + rem);

            //1.2.3 Quadratic formula for x*x + c*x + d
            Console.WriteLine("Enter 2 numbers that you want to use: ");
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double dis = c * c - 4.0 * d;
            double sqroot = Math.Sqrt(dis);

            double root1 = (-c + sqroot) / 2.0;
            double root2 = (-c - sqroot) / 2.0;

            Console.WriteLine(root1);
            Console.WriteLine(root2);

            //1.2.4 Leap year
            int year;
            Console.WriteLine("Enter the year that you want to check: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("This year is leap");
            }
            else
            {
                Console.WriteLine("This year is not leap");
            }

            //1.2.5 Casting to get a random integer
            int n, value;
            Console.WriteLine("Enter a positive number: ");
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            value = rnd.Next(0, n);

            Console.WriteLine(value);

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}