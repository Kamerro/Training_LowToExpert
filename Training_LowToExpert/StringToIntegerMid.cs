using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_LowToExpert
{
    internal class StringToIntegerMid
    {
        public int Parse(string input)
        {

            if (String.IsNullOrWhiteSpace(input)) throw new ArgumentException($"Input cannot be null or empty{nameof(input)}");


            var inputSingleCharacters = input.ToCharArray();
            int valueToReturn = 0;
            bool negativeFlag = inputSingleCharacters[0] == '-';
            int startIndex = negativeFlag ? 1 : 0;


            for (int index = startIndex; index < inputSingleCharacters.Length; index++)
            {

                if (char.IsDigit(inputSingleCharacters[index]))
                {
                    
                    int digit = inputSingleCharacters[index] - 48; // may be changed into  int digit = inputSingleCharacters[index] - '0'; but i think no one really care about that.

                    if (valueToReturn > (int.MaxValue-digit)/10) throw new OverflowException($"Holy cow hold your horses. Number is too big!{nameof(input)}");
                    
                    valueToReturn = valueToReturn * 10 + digit;
                    
                }

                else
                    throw new FormatException($"Provided string is not a number{nameof(input)}");
            }

            return negativeFlag ? -valueToReturn : valueToReturn;
        }
    }
}
