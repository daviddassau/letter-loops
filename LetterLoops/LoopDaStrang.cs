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

            // set int variable to 1, as a type of counter
            int idx = 1;

            // main loop that will loop through the user's string input
            foreach (var letterInInput in stringInput)
            {

                // this creates a letter string variable, and assigns it to the previous declared letterInInput variable
                // the ToString() method is used to convert an object to its string representation so that it can be displayed in the console
                string letter = letterInInput.ToString();

                // for loop that contains an if/elseif/else statement
                // this loop will run until it is out of letters in the entered string 
                for (int i = 1; i <= idx; i++)
                {
                    // this checks to see if it's the next letter in the string, and needs to be capitalized
                    // if this if is hit, a capitalized letter is printed, and the for loop starts over
                    if (i == 1 && idx != 1)
                    {
                        var uppercaseLetter = letter.ToUpper();
                        Console.Write($"-{uppercaseLetter}");
                    }
                    // this else if checks to see if it's the next letter in the entered string
                    // if a capital letter was just added, then it proceeds to the else part and adds an additional letter that is lowercase
                    // if it's time to add a new capital letter, the loop starts over
                    else if (i == 1 && idx == 1)
                    {
                        var uppercaseLetter = letter.ToUpper();
                        Console.Write($"{uppercaseLetter}");
                    }
                    // this else part runs when it's next letter in the string that follows a capital letter, and it needs to be lowercase
                    // i.e. if the string is David, then it would make the lowercase 'a' in "D-Aa"
                    else
                    {
                        letter = letter.ToLower();
                        Console.Write($"{letter}");
                    }

                }

                // this runs when it's time to move on to the next letter in the entered string
                idx++;

            }

            // this prevents the console window from closing out until the user hits enter
            Console.ReadKey();

        }

    }
}
