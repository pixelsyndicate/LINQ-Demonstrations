using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Basics1 basics = new Basics1();
            Console.WriteLine(basics.ForOutput);

            Projecting projecting = new Projecting();
            Console.WriteLine(projecting.ForOutput);

            Console.WriteLine("Press the Enter key to exit");
            Console.ReadLine();
        }
    }
}
