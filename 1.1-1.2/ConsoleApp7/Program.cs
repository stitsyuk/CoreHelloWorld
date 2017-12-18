using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1.1 Write a program that prints the Hello, World message 10 times.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello. World");
            }

            //1.1.5 Modify UseArgument.java to make a program UseThree.java that takes three names and prints out a proper sentence with the names in the reverse of the order given, so that, for example, java UseThree Alice Bob Carol gives Hi Carol, Bob, and Alice.
            string name1, name2, name3;
            Console.WriteLine("Write 3 names: ");
            name1 = Console.ReadLine();
            name2 = Console.ReadLine();
            name3 = Console.ReadLine();
            Console.WriteLine("Hi, " + name3 + " " + name2 + " " + name1);

            //1.2.2 Write a program that uses Math.sin() and Math.cos() to check that the value of cos2 & +sin2 & is approximately 1 for any & entered as a command - line argument. Just print the value.Why are the values not always exactly 1 ?
            double q, result;
            Console.WriteLine("Enter the angle: ");
            q = double.Parse(Console.ReadLine());
            result = Math.Sin(q) * Math.Sin(q) + Math.Cos(q) * Math.Cos(q);
            Console.WriteLine(result);

            /*If you want to check exactly values of sin and cos you can uncomment next part
            Console.WriteLine(sin);
            Console.WriteLine(cos);
            The question was: Why are the values not always exactly 1? Before making a programm I thought about the question and decided that the problem can be that the exactly value of sin and cos can be much more than double provide. That's why we can get not exactly 1. But I've tried a lot of times and always get exactly 1 as answer. */

            //1.2.3 Suppose that a and b are int values. Show that the expression (!(a && b) && (a || b)) || ((a && b) || !(a || b)) is true
            bool tr, a, b;
            a = true;
            b = false;
            // I didn't understand how to make this task for all cases of a and b. I mean it should made for all 4 cases: T T, T F, F T, F F but when I clean the previous values it give me error
            tr = (!(a && b) && (a || b)) || ((a && b) || !(a || b));
            Console.WriteLine(tr);

            /*1.2.10 Suppose that a variable a is declared as int a = 2147483647 (or equivalently, Integer.MAX_VALUE). What do each of the following print?
            int z = 2147483647;
            Console.WriteLine(z);
            Console.WriteLine(z+1);
            Console.WriteLine(2-z);
            Console.WriteLine(-2-z);
            Console.WriteLine(2*z);
            Console.WriteLine(4*z);
            Checked and had some fun*/

            //1.2.14 Write a program that takes two positive integers as command-line arguments and prints true if either evenly divides the other.
            int x, y;
            bool c;
            Console.WriteLine("Enter 2 numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                c = true;
            }
            else
                c = false;
            Console.WriteLine(c);

            //1.2.15 Write a program that takes three positive integers as command-line arguments and prints true if any one of them is greater than or equal to the sum of the other two and false otherwise.
            int w, e, r;
            bool v;
            Console.WriteLine("Enter 3 numbers: ");
            w = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
            if (w >= e + r && e >= w + r && r>= w + e)
            {
                v = true;
            }
            else
                v = false;
            Console.WriteLine(v);

            //1.2.16 F = G * mass1 * mass2 / r * r >>>> F = G * mass1 * mass2 / r / r or F = G * mass1 * mass2 / (r * r)

            //1.2.18 Suppose that x and y are double values that represent the Cartesian coordinates of a point(x, y) in the plane. Give an expression whose value is the distance of the point from the origin.
            double t, u, dis;
            Console.WriteLine("Enter your coordinates: ");
            t = int.Parse(Console.ReadLine());
            u = int.Parse(Console.ReadLine());
            dis = Math.Sqrt(t * t + u * u);
            Console.WriteLine("The distance is: " + dis);

            //1.2.19 Write a program that takes two int values a and b from the command line and prints a random integer between a and b.
            int o, p, random1;
            Console.WriteLine("Enter 2 numbers: ");
            o = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            random1 = rnd.Next(o, p);
            Console.WriteLine(random1);

            //1.2.20 Write a program that prints the sum of two random integers between 1 and 6
            int random2, random3, sum;
            Random rand = new Random();
            random2 = rand.Next(1, 6);
            random3 = rand.Next(1, 6);
            sum = random2 + random3;
            Console.WriteLine(sum);

            //1.2.21 Write a program that takes a double value t from the command line and prints the value of sin(2t) " sin(3t).
            double l, result1;
            Console.WriteLine("Enter the angle: ");
            l = double.Parse(Console.ReadLine());
            result1 = Math.Sin(2 * l) + Math.Sin(3 * l);
            Console.WriteLine(result1);

            //1.2.22 Write a program that takes three double values x0, v0, and t from the command line and prints the value of x0 + v0t + gt2 / 2, where g is the constant 9.78033.
            double k, j, h;
            Console.WriteLine("Enter x0: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter V0: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter t: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine(k + j * h + 9.78033 * h * h / 2);

            //1.2.23 Write a program that takes two int values m and d from the command line and prints true if day d of month m is between 3 / 20 and 6 / 20, false otherwise.
            int month, day;
            bool ans;
            Console.Write("Enter the month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter the day: ");
            day = int.Parse(Console.ReadLine());
            if (month == 3)
            {
                if (day >= 20 && day <= 31)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 4)
            {
                if (day >= 1 && day <= 30)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 5)
            {
                if (day >= 1 && day <= 31)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 6)
            {
                if (day >= 1 && day <= 20)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else
                ans = false;
            Console.WriteLine(ans);

            //1.2.24 Loan payments. Write a program that calculates the monthly payments you would have to make over a given number of years to pay off a loan at a given interest rate compounded continuously, taking the number of years t, the principal P, and the annual interest rate r as command - line arguments.The desired value is given by the formula Pe rt. Use Math.exp().




            

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}



//            //1.2.2 Integer multiplication and division
//            int a, b;
//Console.WriteLine("Enter 2 numbers that you want to use: ");
//            a = int.Parse(Console.ReadLine());
//b = int.Parse(Console.ReadLine());
//int sum = a + b;
//int prod = a * b;
//int quot = a / b;
//int rem = a % b;

//Console.WriteLine(a + " + " + b + " = " + sum);
//            Console.WriteLine(a + " * " + b + " = " + prod);
//            Console.WriteLine(a + " / " + b + " = " + quot);
//            Console.WriteLine(a + " % " + b + " = " + rem);
//            Console.WriteLine(a + " = " + quot + " * " + b + " + " + rem);

//            //1.2.3 Quadratic formula for x*x + c*x + d
//            Console.WriteLine("Enter 2 numbers that you want to use: ");
//            double c = double.Parse(Console.ReadLine());
//double d = double.Parse(Console.ReadLine());
//double dis = c * c - 4.0 * d;
//double sqroot = Math.Sqrt(dis);

//double root1 = (-c + sqroot) / 2.0;
//double root2 = (-c - sqroot) / 2.0;

//Console.WriteLine(root1);
//            Console.WriteLine(root2);

//            //1.2.4 Leap year
//            int year;
//Console.WriteLine("Enter the year that you want to check: ");
//            year = int.Parse(Console.ReadLine());

//            if (year % 4 == 0)
//            {
//                Console.WriteLine("This year is leap");
//            }
//            else
//            {
//                Console.WriteLine("This year is not leap");
//            }

//            //1.2.5 Casting to get a random integer
//            int n, value;
//Console.WriteLine("Enter a positive number: ");
//            n = int.Parse(Console.ReadLine());
//Random rnd = new Random();
//value = rnd.Next(0, n);

//            Console.WriteLine(value);