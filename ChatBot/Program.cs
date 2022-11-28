using System;

namespace Lessons
{
    internal class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            var test = new Program();
            Console.WriteLine("Hello! My name is Rubel.");
            Console.WriteLine("I was created in 2022");
            Console.WriteLine("Please, remind me your name");
            string user_name = Console.ReadLine();
            string name_print = string.Format("What a great name you have, {0}", user_name);
            Console.WriteLine(name_print);
            Console.WriteLine("Let me guess your age.");
            Console.WriteLine("Enter remainders of dividing your age by 3, 5 and 7.");
            int remainder3 = Int32.Parse(Console.ReadLine());
            int remainder5 = Int32.Parse(Console.ReadLine());
            int remainder7 = Int32.Parse(Console.ReadLine());
            int age = (remainder3 * 70 + remainder5 * 21 + remainder7 * 15);
            int formula = Math.DivRem(age, 105, out result);
            string result_print = string.Format("Your age is {0}; that's a good time to start programming!", result.ToString());
            Console.WriteLine(result_print);
            Console.WriteLine("Now I will prove to you that I can count to any number you want.");
            int counter = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine(i.ToString() + "!");
            }
            test.print_questions();
            test.test();
        }
        void test()
        {
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == 2)
            {
                Console.WriteLine("Completed, have a nice day!");
                Console.WriteLine("Congratulations, have a nice day!");
            }
            else
            {
                Console.WriteLine("Please, try again.");
                test();
            }
        }
        void print_questions()
        {
            Console.WriteLine("Why do we use methods?");
            Console.WriteLine("1. To repeat a statement multiple times.");
            Console.WriteLine("2. To decompose a program into several small subroutines.");
            Console.WriteLine("3. To determine the execution time of a program.");
            Console.WriteLine("4. To interrupt the execution of a program.");
        }
    }
}
