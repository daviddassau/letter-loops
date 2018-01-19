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

            Console.WriteLine("Please enter any word...");

            var stringInput = Console.ReadLine();

            LoopDaStrang.ConvertUserInput(stringInput);

        }
    }
}
