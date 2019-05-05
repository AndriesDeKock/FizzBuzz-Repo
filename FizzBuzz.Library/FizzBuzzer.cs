using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        //method that returns value
        public static string GetValue(int input)
        {
            //create empty output parameter
            string output = string.Empty;

            //if value is divisible by 3 return fizz
            if (input % 3 == 0)
            {
                output += "Fizz";
            }

            //if value is divisible by 5 return buzz
            if (input % 5 == 0)
            {
                output += "Buzz";
            }

            //else set output to input value
            if (string.IsNullOrEmpty(output))
            {
                output = input.ToString();
            }

            //return output
            return output;

        }
    }
}
