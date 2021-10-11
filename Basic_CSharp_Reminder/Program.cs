using Basic_CSharp_Reminder.Class;
using System;
using System.Threading.Tasks;

namespace Basic_CSharp_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExercise();
        }

        public static void FirstExercise()
        {
            Stopwatch stopwatch = new Stopwatch();
            try
            {
                stopwatch.Start();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            var t = Task.Run(async delegate
            {
                await Task.Delay(2000);
                return 42;
            });
            t.Wait();
            try
            {
                stopwatch.Start();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            stopwatch.Stop();
            Console.ReadLine();
        }
    }
}
