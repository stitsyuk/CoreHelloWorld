using System;

namespace ReferenceAndValue
{
    class Program
    {
        static void by_value(int a)
        {
            a = 1;
        }

        static void by_reference(ref int a)
        {
            a = 1;
        }

        static void Main(string[] args)
        {
            int b, c;
            Console.WriteLine("This is the program that shows how I do my homework:");
            Console.Write("Enter the number of days until Friday deadline(imagine that it is more than 1 day): ");
            b = int.Parse(Console.ReadLine());
            c = b;

            by_reference(ref b);
            if (b == 1)
            {
                Console.WriteLine("This is the way Farrukh wants me to think:<<I should do all my homework TODAY!!!>>");
            }
            else
                Console.WriteLine("This is the way Artyom thinks:<<Okay, there are a lot of days until deadline, today I can just create a MarkDown and do allthing tomorrow.>>");

            //Farrukh always wants me to do most every day, it means he wants me to think like this is last day (set numbers of my days equal to 1 by reference)

            b = c;
            by_value(b);
            if (b == 1)
            {
                Console.WriteLine("This is the way Farrukh wants me to think:<<I should do all my homework TODAY!!!>>");
            }
            else
                Console.WriteLine("This is the way Artyom thinks:<<Okay, there are a lot of days until deadline, today I can just create a MarkDown and do allthing tomorrow.>>");

            //This is the reality in which Artyom always does most in the last day and he sees the real number until deadline set by value

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
