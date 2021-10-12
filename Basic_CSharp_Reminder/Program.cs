using Basic_CSharp_Reminder.Class;
using System;
using System.Threading.Tasks;

namespace Basic_CSharp_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExercise();

            //PostExercise();




        }
        public static void PostExercise() {
            Post post = new Post("Jak w c# policzyc czas w sekundach", "Cześć! Zastanawiam się jak policzyć czas w sekundach w c# bo używając Datetime Now i odejmując różnice dostaje całą date. Pozdrawiam losowy uzytkownik");

            Console.WriteLine(post.ToString());

            for (int i = 0; i < 4; i++)
            {
                post.UpVote();
            }

            Console.WriteLine(post.ToString());

            for (int i = 0; i < 10; i++)
            {
                post.DownVote();
            }
            Console.WriteLine(post.ToString());

            for (int i = 0; i < 85; i++)
            {
                post.UpVote();
            }
            for (int i = 0; i < 2; i++)
            {
                post.DownVote();
            }
            Console.WriteLine(post.ToString());
        }
        public static void FirstExercise()
        {
            Stopwatch stopwatch = new Stopwatch();
            for(int i = 0; i < 2; i++) { 
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
                Console.WriteLine("Press any button to turn on it again or finish program if u alredy try it 2 times");
            Console.ReadLine();
            }
        }
    }
}
