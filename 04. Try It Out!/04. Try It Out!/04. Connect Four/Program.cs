/*
Connect Four
The game of Connect Four is a simple and interesting game played on a 
grid with six rows and seven columns. Two players take turns taking 
tokens and dropping them into one of the seven columns, where it falls 
down to either the bottom if the column is currently empty or to the top of 
the pile if it is not.
The goal of the game is to get four of your tokens in a row, up and down, 
side to side, or diagonally, before the other player does. Your task is to 
make a game where two alternating players can select a row (numbers 1 through 7) to place their 
token on and play the game of Connect Four.
There are a few pieces to this game that might be challenging. One will be writing the code to take a 
row and add a token to the top of it. On a related note, it may also be tricky to ensure that if a row is 
full, the game doesn’t crash, but instead, notifies the player that the move they wanted to make was 
an illegal move, and give them another chance. Also, after each move, you’ll want to check to see if 
that move caused the player to win.
By the way, while many games like this tend to look great with a GUI the game can still easily be 
made to look good by printing out the right things to the console window, as shown below:
. . . . . . .
. . . . . . .
. . . . . . .
. . . O . . .
. . . X . . .
. X . X O . . 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Connect_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[6,7];
            InitMatrix(board, 6, 7);
            Console.WriteLine("Player One choose your sign:");
            char playerOneSign = char.Parse(Console.ReadLine());
            Console.WriteLine("Player Two choose your sign:");
            char playerTwoSign = char.Parse(Console.ReadLine());
            bool playerTurn = true;
            int duration = 6 * 7;

            while (duration > 0)
            {
                if (playerTurn)
                {
                    Console.WriteLine("Player One choose your column:");
                    int moveCol = int.Parse(Console.ReadLine());
                    int row = MakeMove(board, 6, moveCol - 1, playerOneSign, playerTwoSign);
                    if (CheckPlayerVertical(board, moveCol - 1, playerOneSign) || CheckPlayerHorizontal(board, row, playerOneSign))
                    {
                        WriteMatrix(board, 6, 7);
                        Console.WriteLine("Player One won!");
                        break;
                    }
                    playerTurn = false;

                }
                else
                {
                    Console.WriteLine("Player Two choose your column:");
                    int moveCol = int.Parse(Console.ReadLine());
                    int row = MakeMove(board, 6, moveCol - 1, playerTwoSign, playerOneSign);
                    if (CheckPlayerVertical(board, moveCol - 1, playerTwoSign) || CheckPlayerHorizontal(board, row, playerTwoSign))
                    {
                        WriteMatrix(board, 6, 7);
                        Console.WriteLine("Player Two won!");
                        break;
                    }
                    playerTurn = true;
                }
                duration--;
                WriteMatrix(board, 6, 7);
            }


        }

        public static void InitMatrix(char [,] board, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    board[row, col] = '.';
                }
            }
        }

        public static void WriteMatrix(char[,] board, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
        }
       
        public static int MakeMove(char[,] board, int height, int col, char playerSign, char otherPlayerSign)
        {
            for (int row = height - 1; row >= 0; row--)
            {
                if (board[row, col] == playerSign || board[row, col] == otherPlayerSign)
                {

                }
                else
                {
                    board[row, col] = playerSign;
                    return row;

                }
            }
            return -1;
        }

        public static bool CheckPlayerVertical (char [,] board, int column, char playerSign) 
        {
            bool playerWon = false;
            int signCount = 0;
            for (int row = 1; row < 6; row++)
            {
                if (board[row, column] == playerSign && board[row - 1, column] == playerSign)
                {
                    signCount++;
                    if (signCount == 3)
                    {
                        return true;
                    }
                } else
                {
                    signCount = 0;
                }
            }

            return playerWon;
        }

        public static bool CheckPlayerHorizontal(char[,] board, int row, char playerSign)
        {
            int signCount = 0;
            for (int col = 1; col < 7; col++)
            {
                if (board[row, col] == playerSign && board[row, col - 1] == playerSign)
                {
                    signCount++;
                    if (signCount == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    signCount = 0;
                }
            }

            return false;
        }



    }
}
