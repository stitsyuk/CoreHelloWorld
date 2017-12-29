using System;

namespace SedgewickLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.3.1 Write a program that takes three integer command-line arguments and
            prints equal if all three are equal, and not equal otherwise.*/
            int arg1, arg2, arg3;
            Console.WriteLine("Enter 3 numbers:");
            arg1 = int.Parse(Console.ReadLine());
            arg2 = int.Parse(Console.ReadLine());
            arg3 = int.Parse(Console.ReadLine());
            if (arg1 == arg2 && arg2 == arg3)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");

            /*1.3.5 Improve your solution to EXERCISE 1.2.25 by adding code to check that the
values of the command-line arguments fall within the ranges of validity of the formula,
and also adding code to print out an error message if that is not the case.*/
            int temp, speed;
            Console.WriteLine("Enter the temperature: ");
            temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wind speed: ");
            speed = int.Parse(Console.ReadLine());
            if (temp < 50 || speed < 120 || speed > 3)
            {
                Console.WriteLine(35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16));
            }
            else
                Console.WriteLine("404:Error - wrong value");

            /*1.3.8 Write a program that, using one for loop and one if statement, prints the integers from 1,000 to 2,000 with five integers per line. Hint: Use the % operation.*/
            for (int i = 1000; i <= 2000; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
                else
                    Console.Write(i + " ");
            }

            /*1.3.11 Write a program FunctionGrowth that prints a table of the values log N,
N, N log N, N 2, N 3, and 2 N for N = 16, 32, 64, ... , 2048.*/
            int[] N = new int[] { 16, 32, 64, 128, 256, 512, 1024, 2048 };
            Console.WriteLine("N: " + N[0] + " " + N[1] + " " + N[2] + " " + N[3] + " " + N[4] + " " + N[5] + " " + N[6] + " " + N[7]);
            Console.WriteLine("logN: " + Math.Log(N[0]) + " " + Math.Log(N[1]) + " " + Math.Log(N[2]) + " " + Math.Log(N[3]) + " " + Math.Log(N[4]) + " " + Math.Log(N[5]) + " " + Math.Log(N[6]) + " " + Math.Log(N[7]));
            Console.WriteLine("N*logN: " + N[0] * Math.Log(N[0]) + " " + N[1] * Math.Log(N[1]) + " " + N[2] * Math.Log(N[2]) + " " + N[3] * Math.Log(N[3]) + " " + N[4] * Math.Log(N[4]) + " " + N[5] * Math.Log(N[5]) + " " + N[6] * Math.Log(N[6]) + " " + N[7] * Math.Log(N[7]));
            Console.WriteLine("N^2: " + N[0] * N[0] + " " + N[1] * N[1] + " " + N[2] * N[2] + " " + N[3] * N[3] + " " + N[4] * N[4] + " " + N[5] * N[5] + " " + N[6] * N[6] + " " + N[7] * N[7]);
            Console.WriteLine("N^3: " + N[0] * N[0] * N[0] + " " + N[1] * N[1] * N[1] + " " + N[2] * N[2] * N[2] + " " + N[3] * N[3] * N[3] + " " + N[4] * N[4] * N[4] + " " + N[5] * N[5] * N[5] + " " + N[6] * N[6] * N[6] + " " + N[7] * N[7] * N[7]);
            Console.WriteLine("2^N: " + Math.Pow(2, N[0]) + " " + Math.Pow(2, N[1]) + " " + Math.Pow(2, N[2]) + " " + Math.Pow(2, N[3]) + " " + Math.Pow(2, N[4]) + " " + Math.Pow(2, N[5]) + " " + Math.Pow(2, N[6]) + " " + Math.Pow(2, N[7]));

            /*1.3.12 What are the values of m and n after executing the following code?
int n = 123456789;
int m = 0;
while (n != 0)
{
m = (10 * m) + (n % 10);
n = n / 10;
}
987654321*/

            /*1.3.14 Write a program that takes a command-line argument N and prints all the
positive powers of two less than or equal to N. Make sure that your program works
properly for all values of N. (Integer.parseInt() will generate an error if N is too
large, and your program should print nothing if N is negative.)*/
            int a, b, n;
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            a = rnd.Next(0, n + 1);
            Console.WriteLine(a);
            b = rnd.Next(0, n + 1);
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    Console.Write(i + " ");
                if (a == i)
                    Console.WriteLine("");
            }
            Console.WriteLine(b);
            for (int i = 1; i <= b; i++)
            {
                if (b % i == 0)
                    Console.Write(i + " ");
                if (b == i)
                    Console.WriteLine("");
            }
            //I liked this task

            /*1.3.27 Write a program Checkerboard that takes one command-line argument N
and uses a loop within a loop to print out a two-dimensional N-by-N checkerboard
pattern with alternating spaces and asterisks.*/
            int c;
            Console.Write("Enter the number for making checkerboard: ");
            c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                if (i % 2 != 0)
                    Console.Write(" ");
                for (int j = 0; j < c / 2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*1.3.28 Write a program GCD that finds the greatest common divisor(gcd) of two
integers using Euclid’s algorithm, which is an iterative computation based on the
following observation: if x is greater than y, then if y divides x, the gcd of x and y is
y; otherwise, the gcd of x and y is the same as the gcd of x % y and y.*/
            int z, x, t;
            Console.WriteLine("Enter 2 numbers for GCD:");
            z = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                t = x;
                x = z % x;
                z = t;
            }
            Console.WriteLine("GCD: " + z);

            /*1.3.30 Write a program PowersOfK that takes an integer k as command - line argument
  and prints all the positive powers of k in the Java long data type.Note : The
 constant Long.MAX_VALUE is the value of the largest integer in long.*/
            int k;
            Console.Write("Enter the number:");
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 31; i++)
            {
                if (Math.Pow(k, i) > 2147483647)
                    goto cont;
                Console.WriteLine(Math.Pow(k, i));
            }
            cont:;

            /*1.3.32 Ramanujan’s taxi. Srinivasa Ramanujan was an Indian mathematician
who became famous for his intuition for numbers.When the English mathematician
G.H.Hardy came to visit him one day, Hardy remarked that the number of
his taxi was 1729, a rather dull number.To which Ramanujan replied, “No, Hardy!
No, Hardy!It is a very interesting number.It is the smallest number expressible as
the sum of two cubes in two different ways.” Verify this claim by writing a program
that takes a command - line argument N and prints out all integers less than or equal
to N that can be expressed as the sum of two cubes in two different ways.In other
words, find distinct positive integers a, b, c, and d such that a3 + b3 = c3 + d3.Use four
nested for loops.*/
            //int s, d, q = 0;
            //Console.Write("Enter the number:");
            //s = int.Parse(Console.ReadLine());
            //for (int i = 1; i < s; i++)
            //{
            //    for (int j = 1; j < s; j++)
            //    {
            //        d = s - j * j * j;
            //        if (Math.Pow(d, 1 / 3) is int)
            //            q++;
            //    }
            //}

            /*1.3.33 Checksum.The International Standard Book Number(ISBN) is a 10 - digit
code that uniquely specifies a book. The rightmost digit is a checksum digit that
can be uniquely determined from the other 9 digits, from the condition that d1 +
2d2 + 3d3 + ... + 10d10 must be a multiple of 11(here di denotes the ith digit from the
right).The checksum digit di can be any value from 0 to 10.The ISBN convention is
to use the character 'X' to denote 10.Example: the checksum digit corresponding
to 020131452 is 5 since 5 is the only value of x between 0 and 10 for which
10·0 + 9·2 + 8·0 + 7·1 + 6·3 + 5·1 + 4·4 + 3·5 + 2·2 + 1·x
is a multiple of 11.Write a program that takes a 9 - digit integer as a command - line
argument, computes the checksum, and prints out the the ISBN number.*/
            int w, a1, a2, a3, a4, a5, a6, a7, a8, a9, e;
            Console.Write("Enter a 9-digit integer: ");
            w = int.Parse(Console.ReadLine());
            a1 = w % 10;
            a2 = (w % 100 - a1)/10;
            a3 = (w % 1000 - a1 - a2)/100;
            a4 = (w % 10000 - a1 - a2 - a3)/1000;
            a5 = (w % 100000 - a1 - a2 - a3 - a4)/10000;
            a6 = (w % 1000000 - a1 - a2 - a3 - a4 - a5)/100000;
            a7 = (w % 10000000 - a1 - a2 - a3 - a4 - a5 - a6)/1000000;
            a8 = (w % 100000000 - a1 - a2 - a3 - a4 - a5 - a6 - a7)/10000000;
            a9 = (w % 1000000000 - a1 - a2 - a3 - a4 - a5 - a6 - a7 - a8)/100000000;
            e = (88 - (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9)) % 11;
            if (e > 9)
                Console.WriteLine("Can't unblock with this code");
            Console.WriteLine(e);
            //Veeeeery veeeeeeeeeery nice task

            /*1.3.34 Counting primes. Write a program PrimeCounter that takes a commandline
argument N and finds the number of primes less than or equal to N. Use it to
print out the number of primes less than or equal to 10 million.Note : if you are not
careful, your program may not finish in a reasonable amount of time!*/
            int r;
            Console.Write("1 ");
            for (int i=2; i<=10000000;i++)
            {
                r = 0;
                for(int j=1;j<=i;j++)
                {
                    if (i % j == 0)
                        r++;
                }
                if (r == 2)
                    Console.Write(i+" ");
            }
            //This is right code, I checked, all numbers are really prime. If you want to check farther just comment this part







            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
