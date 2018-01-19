using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLoops
{
    class LoopDaStrang
    {

        static public void ConvertUserInput(string stringInput)
        {

            int idx = 1;

            foreach (var letterInInput in stringInput)
            {

                string letter = letterInInput.ToString();

                for (int i = 1; i <= idx; i++)
                {

                    if (i == 1 && idx != 1)
                    {
                        var uppercaseLetter = letter.ToUpper();
                        Console.Write($"-{uppercaseLetter}");
                    }
                    else if (i == 1 && idx == 1)
                    {
                        var uppercaseLetter = letter.ToUpper();
                        Console.Write($"{uppercaseLetter}");
                    }
                    else
                    {
                        letter = letter.ToLower();
                        Console.Write($"{letter}");
                    }

                }

                idx++;

            }

            Console.ReadKey();

        }

    }
}
