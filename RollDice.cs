using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    //create public class for RollDice
    internal class RollDice
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