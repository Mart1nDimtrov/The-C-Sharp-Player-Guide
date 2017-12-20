/*
Pig Dice
In the game of Pig Dice, players take turns rolling two six-sided dice. On a player’ s turn, they can roll 
the dice repeatedly until they either choose to hold (stop rolling) or roll a 1. As long as the player 
keeps rolling without getting a 1 on either die, the numbers on the dice are added to the player ’ s 
turn score. At any point, a player can hold, which takes their turn score and permanently adds it to 
their overall score. If they roll a 1 on either die, they lose all of the points they had collected in their 
turn score, nothing extra is added to their overall score, and it becomes the next player ’ s turn. When 
a player’ s overall score reaches 100, the game ends, and they have won.
To illustrate, let’ s say Alice (player #1) rolls a 3 and a 4. That gives her a turn score of 7. Alice chooses 
to roll again, getting a 2 and a 6. That gives her an extra 8 points, for a total turn score of 15 points. 
Alice then chooses to hold, and her current turn score is added to her overall score. Alice now has 15 
points overall, and it is now Wally’ s turn (player #2). Wally rolls a 2 and a 3, giving him a turn score of 
5. Wally chooses to roll again, but this time, gets a 1 and a 5. Since he rolled a 1, he loses his turn 
score (which was 5) leaving him still with 0 overall points, and it becomes Alice’ s turn again.
Our goal is to create a computer version of Pig Dice. On each player’ s turn, allow them choose to 
either hold or roll. When a player rolls, generate two random numbers between 1 and 6, and 
program the game to follow the logic described above. Between rolls, display the current status of 
the game, showing both player ’ s overall score, and the current player ’ s turn score. When a player
gets up to 100, end the game and show who won. For an extra challenge, make the game playable 
by three or more players.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pig_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = 0;
            int secondPlayer = 0;
            bool turn = true;
            Random rnd = new Random();

            while (true)
            {
                if (turn)
                {
                    Console.WriteLine("Player One:");
                    Console.WriteLine("Throw or hold?");
                    string choice = Console.ReadLine();
                    if (choice == "throw")
                    {
                        int firstThrow = rnd.Next(1, 7);
                        int secondThrow = rnd.Next(1, 7);
                        if (firstThrow == 1 && secondThrow == 1)
                        {
                            Console.WriteLine("First dice: {0} Second dice: {1}", firstThrow, secondThrow);
                            firstPlayer = 0;
                        }
                        else
                        {
                            Console.WriteLine("First dice: {0} Second dice: {1}", firstThrow, secondThrow);
                            firstPlayer += firstThrow + secondThrow;
                        }
                        turn = false;
                    }
                    else if (choice == "hold")
                    {
                        turn = false;
                    }

                } else
                {
                    Console.WriteLine("Player Two:");
                    Console.WriteLine("Throw or hold?");
                    string choice = Console.ReadLine();
                    if (choice == "throw")
                    {

                        int firstThrow = rnd.Next(1, 7);
                        int secondThrow = rnd.Next(1, 7);
                        if (firstThrow == 1 && secondThrow == 1)
                        {
                            Console.WriteLine("First dice: {0} Second dice: {1}", firstThrow, secondThrow);
                            secondPlayer = 0;
                        } else
                        {
                            Console.WriteLine("First dice: {0} Second dice: {1}", firstThrow, secondThrow);
                            secondPlayer += firstThrow + secondThrow;
                        }
                        turn = true;
                    }
                    else if (choice == "hold")
                    {
                        turn = true;
                    }
                }

                Console.WriteLine("Current results:");
                Console.WriteLine("Player One: {0} Player Two: {1}", firstPlayer, secondPlayer);

                if (firstPlayer >= 100)
                {
                    Console.WriteLine("Player One won!");
                    break;
                }
                else if (secondPlayer >= 100)
                {
                    Console.WriteLine("Player Two won!");
                    break;
                }
            }


        }
    }
}
