/*
In 1970, British mathematician John Conway invented a “zero player” game called the Game of Life. 
This is not the Milton Bradley board game called LIFE, but rather a mathematical game that 
simulates life.
The game is “played” on a grid, where the game advances in generations, with cells becoming alive 
or dying, based on certain conditions.
If a particular cell in the grid is empty (dead) then it can come to life if the following conditions are
met:
  Exactly three neighbors that are alive.
If a particular cell in the grid is alive, then it dies in the following generation if any of the following are 
true:
  It has more than three neighbors. (Overcrowding.)
  It has 0 or 1 neighbors (Loneliness, I guess...)
These simple rules for determining when cells in the grid come to life or die create very interesting 
results that are much more interesting to see than to read in a book.
Because of this, we’ re going to take upon ourselves the challenge of creating the Game of Life as a 
computer program.
There are several key parts to this. For one, we will need to store the current grid. There are lots of 
ways to do this, but one might be a two dimensional array of bools. 
We will also need a method for drawing our current grid. Again, it would look nice with a fancy GUI, 
but we can get away without needing to go beyond the console. If you’ re sticking with the console, 
your best bet is to use 40 columns in your grid, and have each cell take up two characters (an  “X” or 
“.” depending on if it is alive or dead, plus an empty space) because on the console, characters are 
twice as tall as they are wide, and there are 80 columns by default. Using 40 columns with two 
characters per column gives you nice, square shaped cells. About 12 rows fit on the console window 
by default, but you can go up to 20 rows pretty easily and then drag the console window to resize it 
and make it taller.
Additionally, you will need to create a mechanism to update the grid using the rules described 
earlier for cell death and generation. It is important to work with a copy for the next generation or 
updating one cell will mess up the calculation in another cell.
Finally, you’ll need to put it all together in a loop that repeats forever, updating the g rid, drawing the 
grid, and waiting for a while in between, to animate the game and let you see what ’ s happening. For 
this, you might find the Thread.Sleep method useful. We talked about this method in Chapter 37. 
You will need to add a using directive to the top of your code for System.Threading to get access to 
this, as discussed in Chapter 26. You might also find it useful to be able to clear the console window 
before you draw the new grid, using Console.Clear();
he most interesting part about the Game of Life is being able to start with different starting 
configurations and watching it evolve. To make this happen, make it so you can load in initial 
configurations in a file.
You can create these files in any text editor, like Notepad.
There are tons of interesting patterns that show up in the Game of Life, so when you get your game 
working, experiment with various configurations, and look online and see what other interesting 
patterns exist.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.Conway_s_Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int[] positions = System.IO.File.ReadAllText(@path)
                           .Split(',')
                           .Select(int.Parse)
                           .ToArray();

            char[,] plane = new char[40, 40];

            for (int row = 0; row < 40; row++)
            {
                for (int col = 0; col < 40; col++)
                {
                    plane[row, col] = '.';
                }
            }

            for (int i = 0; i < positions.Length; i+=2)
            {
                plane[positions[i] - 1, positions[i + 1] - 1] = 'X';
            }

            while (true)
            {
                for (int row = 0; row < 40; row++)
                {
                    for (int col = 0; col < 40; col++)
                    {
                        CheckPosition(ref plane, row, col);
                    }
                }
                             
                WritePlane(plane);
                Thread.Sleep(2000);
                Console.Clear();
            }
            
        }

        public static void CheckPosition(ref char[,] plane, int row, int col)
        {
            int neighboursCount = 0;
            if (row - 1 >= 0 && col - 1 >= 0 && plane[row - 1, col - 1] == 'X')
            {
                neighboursCount++;
            }
            if (row - 1 >= 0 && plane[row - 1, col] == 'X')
            {
                neighboursCount++;
            }
            if (col - 1 >= 0 && plane[row, col - 1] == 'X')
            {
                neighboursCount++;
            }
            if (row + 1 <= 39 && plane[row + 1, col] == 'X')
            {
                neighboursCount++;
            }
            if (row + 1 <= 39 && col + 1 <= 39 && plane[row + 1, col + 1] == 'X')
            {
                neighboursCount++;
            }
            if (col + 1 <= 39 && plane[row, col + 1] == 'X')
            {
                neighboursCount++;
            }
            if (row - 1 >= 0 && col + 1 <=39 && plane[row - 1, col + 1] == 'X')
            {
                neighboursCount++;
            }
            if (row + 1 <= 39 && col - 1 >= 0 && plane[row + 1, col - 1] == 'X')
            {
                neighboursCount++;
            }

            if (neighboursCount == 0 || neighboursCount == 1 || neighboursCount > 3)
            {
                plane[row, col] = '.';
            }
            else if (neighboursCount == 3)
            {
                plane[row, col] = 'X';
            }

        }

        public static void WritePlane(char [,] plane)
        {
            for (int row = 0; row < 40; row++)
            {
                for (int col = 0; col < 40; col++)
                {
                    Console.Write(plane[row, col]); 
                }
                Console.WriteLine();
            }
       
        }
    }
}
