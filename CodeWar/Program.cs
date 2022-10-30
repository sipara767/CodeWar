using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] greeting = { "edu", "sis", "robi" };
            foreach(string i in greeting)
            {
                Console.WriteLine("hallo how you guys doing {0}", i);
            }
            Console.ReadKey();
            
        }
    }
}