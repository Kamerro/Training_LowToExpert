using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_LowToExpert
{
    internal class ParseStringToIntegerJuniority
    {
        //To check if number is negative i need to add some flag.
        public int Parse(string input)
        {
            var obj = input.ToCharArray();
            int value = 0;
            bool negativeFlag = false;
            if (obj.First() == '-')
                negativeFlag = true;


            for (int i = obj.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (!(negativeFlag && i == 0))
                {
                    byte smallChunk = (byte)obj[i];
                    if (CheckIfChunkIsNumber(smallChunk))
                    {
                        int number = smallChunk - 48;
                        value += number * (int)Math.Pow(10, j);
                    }

                    else
                    {
                        throw new InvalidCastException("Provided string is not a number");
                    }
                }
            }

            if (!negativeFlag)
                return value;

            return value * -1;
        }

        private bool CheckIfChunkIsNumber(byte namllChunk)
        {
            if (namllChunk > 47 && namllChunk < 58)
                return true;

            return false;
        }
    }
}
