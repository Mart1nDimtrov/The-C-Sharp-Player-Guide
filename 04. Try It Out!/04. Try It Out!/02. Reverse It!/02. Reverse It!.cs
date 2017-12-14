/*
Reverse It!
In this task, we’ re going to make a simple array-based game. We’ll start by making an array that can 
hold 9 integer values, and we’ll randomly put the numbers 1 through 9 in the array. Make sure you 
don’t have any duplicates. Each number should appear exactly once.
The array will be printed out to the user like this:
5 3 8 6 4 1 2 9 7
Allow the user to type in a number 1 through 9. Whatever the user types in, we’ re going to reverse 
that many numbers, starting at the front. So from the randomized starting position shown above, if 
the user typed in the number 4, we’ d end up reversing the first four numbers, and the resulting array 
would be:
6 8 3 5 4 1 2 9 7
The player can keep typing in numbers, and you will keep reversing the indicated part of the array 
until the array is in ascending order:
1 2 3 4 5 6 7 8 9
When this happens, the player has won the game, and the game ends. Before closing, show the 
number of moves it took the player to win.
Can you figure out an optimal strategy for this game? It is possible to win this game in no more than 
16 moves, regardless of the starting arrangement.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_It_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
