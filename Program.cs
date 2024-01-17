// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Mission2

{
    using System;

    //create the DicePractice class
    public class DicePractice
    {
        //initiate the constructor
        public static void Main()
        {
            //allow for user to input how many rolls they would like to make with dice.
            Console.WriteLine("Welcome to the dice throwing simulator!" +
                "\r\nHow many dice rolls would you like to simulate?");

            //initialize the numRolls variable to read the user input
            int numRolls = int.Parse(Console.ReadLine());

            //create instance of the RollDice class below
            RollDice rd = new RollDice();

            //calls the FakeRolls method of RollDice instance rd
            int[] rolls = rd.FakeRolls(numRolls);

            //outputs the results of the dice simulation 
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\r\n\nEach" +
                "'*' represents 1% of the total number of rolls.\r\n\n" +
                "Total number of rolls = " + numRolls);

            //a for loop for each iteration and increment by 1 every time
            for (int iCount = 2; iCount <= 12; iCount++)
            {
                // calculate the percentage of total rolls for the current sum iCount
                int results = rolls[iCount] * 100 / numRolls;

                //output the histogram for each percentage of total rolls for the current sum
                Console.WriteLine($"{iCount}: {new string('*', results)}");
            }

            //output a thank you for using the simulator
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }

    //create public class for RollDice
    public class RollDice
    {
        //create the constructor for creating instance of the Random class.
        Random rand = new Random();

        //intialize FakeRolls method and pass numRolls as a parameter
        public int[] FakeRolls(int numRolls)
        {
            //initialize results array
            int[] results = new int[13];

            //for loop for each iteration and increment by 1 each time.
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                //simulate the rolling of two dice numRolls times
                int roll = DiceRoll();
                results[roll]++;
            }

            //return the results
            return results;

        }

        // initialize DiceRolls method
        public int DiceRoll()
        {
            //generates random numbers for two six-sided dice
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            //return the sum of both
            return dice1 + dice2;
        }
    }
}



