using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt to ask the user to enter any string into the console
            Console.WriteLine("Please enter any word...");

            // this takes 'stringInput' from LoopDaStrang and assigns it to a Console.ReadLine()
            // this allows the user to enter in a string in the console
            var stringInput = Console.ReadLine();

            // this basically runs everything inside the LoopDaString class
            LoopDaStrang.ConvertUserInput(stringInput);

        }
    }
}
