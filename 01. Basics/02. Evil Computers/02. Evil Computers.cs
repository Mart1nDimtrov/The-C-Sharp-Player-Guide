/*
Evil Computers. In the influential movie 2001: A Space Odyssey, an evil computer named HAL 
9000 takes over a Jupiter-bound spaceship, locking Dave, the movie’ s hero, out in space. As Dave 
tries to get back in, to the ship, he tells HAL to open the pod bay doors. HAL ’ s response is "I’ m 
sorry, Dave. I’ m afraid I can’t do that." Since we know not all computers are friendly and happy to 
help people, modify your Hello World program to say HAL 9000’ s famous words, instead of 
"Hello World!"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Evil_Computers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the name of the computer operating the ship:");
            var nameOfComputer = Console.ReadLine();

            if (nameOfComputer.ToLower() == "hal 9000")
            {
                Console.WriteLine("I’m sorry, Dave. I’m afraid I can’t do that.");
            }
            else
            {
                Console.WriteLine("You are all set!");
            }
        }
    }
}
