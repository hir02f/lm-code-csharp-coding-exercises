using System;
using System.Linq;
using System.Threading;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                int count = 0; // count how many characters in input (should be 26)
                var charactersInInput = input.ToCharArray().Distinct(); // makes a list of characters, distinct
                
                foreach (char ch in charactersInInput)                
                {
                    if (Char.IsLetter(ch))
                    {
                        count++;
                    }
                }
                return count == 26;
            }
        }
    }
}
