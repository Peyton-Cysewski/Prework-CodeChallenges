using System;

namespace Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            problem_2();
        }

        private static void problem_1()
        {
            Console.Clear();

            int[] inputs = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number between 1 and 10: ");
                inputs[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.Write(@"Your choices were {0}, {1}, {2}, {3}, and {4}. Now choose one number to score: ",
                inputs[0], inputs[1], inputs[2], inputs[3], inputs[4]);

            int choice = Convert.ToInt32(Console.ReadLine());

            int score = choice * Array.FindAll(inputs, x => x == choice).Length;

            Console.Clear();
            Console.WriteLine($"The final score is {score}");
        }

        private static void problem_2()
        {
            Console.Clear();
            Console.WriteLine("Enter a year to see if it is a leap year: ");

            int year = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            } else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is not a leap year.");
            } else if (year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
        }
    }
}
