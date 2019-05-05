using FizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //create loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                //print number
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadLine();

        }
    }
}
