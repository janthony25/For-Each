using System;

namespace ForEachLoops
{
    public class Program
    {
        static void Main(string[] args)
        {

            // foreach
            // foreach loop, which is used exclusively to loop through elements in an array:

            string[] brothers = { "Wilbert", "Jun", "Limuel" };

            foreach (string brother in brothers)
            {
                Console.WriteLine(brother);
            }

            Console.ReadKey();
        }
    }
}