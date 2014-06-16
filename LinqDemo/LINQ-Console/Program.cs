using System;

namespace LINQ_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var basics = new Basics1();
            Console.WriteLine(basics.ForOutput);

            SpacingMessage();

            var projecting = new Projecting();
            Console.WriteLine(projecting.ForOutput);

            SpacingMessage();

            var takeSkip = new TakeAndSkip();
            Console.WriteLine(takeSkip.ForOutput);

            EndMessage();
        }

        private static void SpacingMessage()
        {
            Console.WriteLine(" ");
        }


        private static void EndMessage()
        {
            Console.WriteLine("Press the Enter key to exit");
            Console.ReadLine();
        }
    }
}