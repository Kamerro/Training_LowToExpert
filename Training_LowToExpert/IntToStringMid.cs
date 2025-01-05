using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training_LowToExpert
{
    internal class IntToStringMid
    {
        public string Parse(int input)
        {
            bool isInputPositive = input >= 0;
            StringBuilder valueToReturn = new StringBuilder();
            input = isInputPositive ? input : -input;
            do
            {
                int singleDigit = input % 10;
                char digitAsChar = (char)(singleDigit + '0');
                valueToReturn.Insert(0,digitAsChar);
                input /= 10;

            } while (input > 0);
            valueToReturn.Insert(0,isInputPositive ? String.Empty : "-");
            return valueToReturn.ToString();
        }
    }
}
