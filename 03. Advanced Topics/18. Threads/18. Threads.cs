/*
Frog Racing.  Let’ s make a little simulator for a frog race. The idea is that there are multiple 
frogs that are lined up and competing against each other to jump across a finish line. In order to 
finish the race, a frog will need to jump a total of 10 times. Each frog will run on its own thread, 
and we’ll use three frogs total.
To do this, create a method that follows the ParameterizedThreadStart delegate. As input, the 
object that is passed in will be the frog’ s number. Inside of that method, use a loop to print out 
“Frog #X jumped” and then use Thread.Sleep and a Random object to have the frog/thread 
sleep for a random amount of time between 0 and 1 seconds. When the frog/thread has jumped 
ten times total, and the loop ends, print out “Frog #X finished.” (See Chapter 16 for information 
about generating random numbers.)
Start the frog race by creating three separate threads and starting them all with different 
numbers. Wait for each thread to finish using the Join method.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18.Threads
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalFrogs = 5;

            List<Thread> threads = new List<Thread>();

            for (int index = 0; index < totalFrogs; index++)
            {
                Thread thread = new Thread(HandleSingleFrog);
                thread.Start(index + 1);
                threads.Add(thread);
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("The race is over!");
            Console.ReadKey();
        }

        private static Random random = new Random();

        private static void HandleSingleFrog(object numberAsObject)
        {
            int number = (int)numberAsObject;

            for (int jump = 0; jump < 10; jump++)
            {
                Console.WriteLine("Frog " + number + " jumped.");
                Thread.Sleep(random.Next(5000) + 500);
            }

            Console.WriteLine("***Frog " + number + " is finished!***");
        }
    }
}
