// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Mission2

{
    using System;
    public class DicePractice
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!" +
                "\r\nHow many dice rolls would you like to simulate?");

            int numRolls = int.Parse(Console.ReadLine());

            RollDice rd = new RollDice();
            int[] rolls = rd.FakeRolls(numRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\r\n\nEach" +
                "'*' represents 1% of the total number of rolls.\r\n\n" +
                "Total number of rolls = " + numRolls);

            for (int iCount = 2; iCount <= 12; iCount++)
            {
                int results = rolls[iCount] * 100 / numRolls;
               
                Console.WriteLine($"{iCount}: {new string('*', results)}");
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }

    public class RollDice
    {
        Random rand = new Random();

        public int[] FakeRolls(int numRolls)
        {
            int[] results = new int[13];

            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                int roll = DiceRoll();
                results[roll]++;
            }

            return results;

        }
        public int DiceRoll()
        {
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            return dice1 + dice2;
        }
    }
}



