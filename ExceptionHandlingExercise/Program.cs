using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------------------
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            var arr = new char[] {'1', '2', '3', '4', '5', '6', 'a', 'b', 'c'};
            var numbers = new List<int>();
            var str = "";
            
            foreach (var item in arr)
            {
                int number;
                
                try
                {
                    str = item.ToString();
                    numbers.Add(int.Parse(str));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
