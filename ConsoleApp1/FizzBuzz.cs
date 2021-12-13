using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FizzBuzz
    {
        
        public static void RunFizzBuzz()
        {
            for(var i  = 1; i < 100; i++)
            {

                Console.WriteLine(GetType(i)); 

            }
        }




        public static string GetType(int number)
        {
            if ((double)number % 3 == 0 && (double)number % 5 != 0)
            {
                return "Fizz";
            }
            else if ((double)number % 3 != 0 && (double)number % 5 == 0)
            {
                return "Buzz"; 
            }
            else if ((double)number % 3 == 0 && (double)number % 5 == 0)
            {
                return "FizzBuzz"; 
            }
            return number.ToString();
        }
    }
}
