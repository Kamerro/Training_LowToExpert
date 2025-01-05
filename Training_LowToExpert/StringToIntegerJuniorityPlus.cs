using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_LowToExpert
{
    internal class StringToIntegerJuniorityPlus
    {
        
        public int Parse(string input)
        {

            //Secondly there is need to add check if null/empty value were passed;
            if(String.IsNullOrWhiteSpace(input)) throw new ArgumentException("Input cannot be null or empty");


            //Some of the variables may be better named.
            var inputSingleCharacters = input.ToCharArray();
            int valueToReturn = 0;
            bool negativeFlag = false;
            int multiplier = 1;
            if (inputSingleCharacters.First() == '-')
                negativeFlag = true;


            //Firstly we will go here and clear this for loop.
            for (int i = inputSingleCharacters.Length - 1; i >= 0; i--)
            {
                if (!(negativeFlag && i == 0))
                {
                    byte smallChunk = (byte)inputSingleCharacters[i];
                    if (CheckIfChunkIsNumber(smallChunk))
                    {
                        int number = smallChunk - 48;
                        valueToReturn += number * multiplier;
                        //After adding multiplier instead of math pow code will be more efficient.
                        multiplier *= 10;
                    }

                    else
                        throw new FormatException("Provided string is not a number"); //Its more clear and written in better way.
                }
            }

            if (!negativeFlag)
                return valueToReturn;

            return -valueToReturn; // we can remove -1 and return just -value. 
        }

        private bool CheckIfChunkIsNumber(byte namllChunk)
        {
            if (namllChunk > 47 && namllChunk < 58)
                return true;

            return false;
        }
    }
}
