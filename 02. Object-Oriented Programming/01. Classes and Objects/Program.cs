/**
Die Rolling. Tons of games use dice. And the Random class that we’ve been talking about gives 
us the ability to simulate die rolling. Many games give the player the task of rolling multiple sixsided dice and adding up the results.
We’ re going to write a program that makes life easier for the player of a game like this. Start t he 
program off by asking the player to type in a number of dice to roll. Create a new Random
object and roll that number of dice. Add the total up and print the result to the user. (You should 
only need one Random object for this.)
For bonus points, put the whole program in a loop and allow them to keep typing in numbers 
until they type “ quit” or “ exit”. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Type in the number of dice to roll or type quit or exit to stop:");

            string numberOfDiceRolls = Console.ReadLine();


            while (numberOfDiceRolls != "quit" && numberOfDiceRolls != "exit")
            {
                int numberOfDice = int.Parse(numberOfDiceRolls);
                int sumOfRolls = 0;

                for (int i = 0; i < numberOfDice; i++)
                {
                    sumOfRolls += random.Next(6) + 1;
                }

                Console.WriteLine("The sum of all your rolls is: {0}", sumOfRolls);

                Console.WriteLine("Type in the number of dice to roll or type quit or exit to stop:");
                numberOfDiceRolls = Console.ReadLine();
            }

        }
    }
}
