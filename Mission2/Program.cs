using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // int[] blah = {45, 20, 67, 10}; // fill the array when instantiating
            int[] counter = new int[6]; // create a new array with null values

            // loop to store the roll counts 1-6
            for (int i = 0; i < 6; i++)
            {
                counter[i] = 0; // fill the array with 0s for each value
            }

            // loop to roll the dice 100 times (but the user will have the option to choose how many times to roll)
            // keep track of how many times each die was rolled

            Console.Write("Welcome to the dice throwing simulator!");
            Console.Write("How many times would you like to roll the dice?");

            string input = Console.ReadLine();
            int rolls = Convert.ToInt32(input);


            for (int i = 0; i < rolls; i++)
            {
                // Console.WriteLine(rand.Next(1, 7)); // prints the roll to the console
                counter[rand.Next(6)]++;
            }

            Console.Write("SIIMULATION RESULTS\nEach '*' represents 1% of total rolls\nThe total number of rolls=" + input);

            int number = 0;

            Console.WriteLine((number + 1) + ": " + counter[5]);


        }
    }
}
