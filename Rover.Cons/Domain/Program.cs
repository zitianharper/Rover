using System;
using Rover.Cons.Input;

namespace Rover.Cons.Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var result = InputParser.InputCleaner("L");

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
