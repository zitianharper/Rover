using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Cons.Input
{
    public static class InputParser
    //parsing the inputs into instructions.

    /*since input is a string and the instructionsEnum is made of char, will need to:
         1) loop trhough the input 
         2) check if the chars match somethign in InstructionsEnum
         3) if it matches, add to a new THING - what type? - which will actually hold the cleaned instructions

     */
    {
        public static List<Domain.InstructionsEnum> InputCleaner(string input)
        {
            var result = new List<Domain.InstructionsEnum>();
            Domain.InstructionsEnum cleanInstruction;

            foreach (char c in input)
            {
                if (Enum.TryParse<Domain.InstructionsEnum>(c.ToString(), out cleanInstruction))
                {
                    result.Add(cleanInstruction);
                    //TryParse used instead of Parse because it throws 'false' when input does not match, instead of just breaking
                    //used ToString() because TryParse only takes strings

                }
                else
                {
                    throw new ArgumentException($"Input does not match Instructions");
                }
            }
            
            return result;

        }
    }
        
}
