using System;
using System.Threading.Tasks;

namespace MultithreadingAndTasks
{
    class Program
    {
        static bool timesOut = false;
        static void Main(string[] args)
        {
            SimpleNumberGuesser(secondsToFinish: 10);
        }

        static void SimpleNumberGuesser(int secondsToFinish)
        {
            Console.WriteLine("Du har 10 sekunder til at gætte det rigtige tal");

            bool isRunning = true;
            Random random = new Random();
            int correctNumber = random.Next(1, 20);
            SetGameTimer(secondsToFinish);
            
            while (isRunning)
            {
                if (!timesOut)
                {
                    int t;
                    Console.Write("Guess number: ");
                    int userGuess;
                    if (Int32.TryParse(Console.ReadLine(), out userGuess))
                    {
                        if (userGuess == correctNumber)
                        {
                            Console.WriteLine("Congratz, you won!");
                            isRunning = false;
                        }
                    }
                }
                else
                {
                    isRunning = true;
                }
            }
        }

        public static Task SetGameTimer(int seconds)
        {
            Task task = new Task(() =>
            {
                for (int i = 1; i < seconds; i++)
                {
                    if (!timesOut)
                    {
                        Console.WriteLine($"Time remaining: {seconds - i}");
                        Task.Delay(seconds * 100).Wait();
                        
                    }
                    
                }
                timesOut = true;

                if (timesOut)
                {
                    Console.WriteLine("You ran out of time!");
                }
                
            });
            task.Start();
            return task;
        }
    }
}
