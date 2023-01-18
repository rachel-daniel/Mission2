using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] counter = new int[11]; // create a new array with 11 null values

            // initialize roll totals (between 2-12) at 0
            for (int i = 0; i < 11; i++)
            {
                counter[i] = 0; // fill the array with 0s for each value
            }

            // get number of rolls from user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to roll the dice?");

            string input = Console.ReadLine();
            int rolls = Convert.ToInt32(input);

            // loop to keep track of the totals for x rolls
            for (int i = 0; i < rolls; i++)
            {
                // roll both dice and assign a random value from 1-6
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);

                // fill the counter array with the counts for each total
                int total = die1 + die2;
                counter[total]++;
            }

            // keep track of how many times each die was rolled
            Console.WriteLine("SIMULATION RESULTS\nEach '*' represents 1% of total rolls\nThe total number of rolls=" + input);

            // print histogram for percentage each number was rolled
            // each * = 1% total rolls

            int number = 0;

            Console.WriteLine((number + 1) + ": " + counter[5]);


        }
    }
}
