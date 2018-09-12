using System;
using System.Linq;

namespace codewars_BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("helloWorld!"));
        }
        
         public static string BreakCamelCase(string str)
          {
          //  foreach(char letter in str){
            
          //}
            
            str.Where(x => x.IsUpper);            
            
            return "balls";
          }
    }
}
//Complete the solution so that the function will break up camel casing, using a space between words.
//Kata.BreakCamelCase("camelCasing") => "camel Casing"
