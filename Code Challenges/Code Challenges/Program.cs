using System;
using System.Net;

namespace Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1:");
            Console.ReadLine();

            problem_1();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Problem 2:");
            Console.ReadLine();
            
            problem_2();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Problem 3:");
            Console.ReadLine();

            int[] test1 = new int[] { 1, 2, 3 };
            int[] test2 = new int[] { 10, 2, 7 };
            int[] test3 = new int[] { 2, 2 };
            int[] test4 = new int[] { -1, 1, 0 };
            problem_3(test1);
            problem_3(test2);
            problem_3(test3);
            problem_3(test4);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Problem 4:");
            Console.ReadLine();

            int[,] matrix1 = new int[,] { { 1, 2, 3, 1 }, { 4, 5, 6, 1 }, { 7, 8, 9, 10 } };
            int[,] matrix2 = new int[,] { { 1, 2 }, { 4, 5 }, { 7, 8 }, { 9, 10 }, { 11, 12} };
            int[,] matrix3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12} };
            int[,] matrix4 = new int[,] { { 1 }, { 2 }, { 3 }, { 4 } };
            problem_4(matrix1);
            problem_4(matrix2);
            problem_4(matrix3);
            problem_4(matrix4);
        }

        private static void problem_1()
        {
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
            Console.WriteLine("Enter a year to see if it is a leap year: ");

            int year = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is not a leap year.");

            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leap year.");
            }
        }

        private static string problem_3(int[] testArray)
        {
            int product = 1;
            int sum = 0;
            bool positive = true;

            Console.Write("\nThe array: [ ");
            foreach (int num in testArray)
            {
                if (num < 0)
                {
                    positive = false;
                }
                Console.Write($"{num} ");
                product *= num;
                sum += num;
            }
            Console.Write("] ");
            //Console.Write(sum == product && positive == true ? "contains a perfect sequence!" : "does not contain a perfect sequence.\n");
            string result = sum == product && positive == true ? "contains a perfect sequence!" : "does not contain a perfect sequence.\n";
            Console.Write(result);
            return sum == product && positive == true ? "Yes" : "No"; // added to fulfill the requirements, but is not shown in the console; only the 'result' message is shown.
        }

        private static int[] problem_4(int[,] matrix)
        {
            int[] out_array = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    out_array[i] += matrix[i, j];
                }
            }
            foreach(int num in out_array)
            {
                Console.Write($"{num} ");
            }
            Console.Write("\n");
            return out_array;
        }
    }
}
