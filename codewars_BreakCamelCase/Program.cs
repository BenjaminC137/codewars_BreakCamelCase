using System;
using System.Linq;
using System.Collections;
using System.Text;

namespace codewars_BreakCamelCase
{
    class Program
    {
         static void Main(string[] args)
         {
            Console.WriteLine(BreakCamelCase("camelCasingTest"));
         }
        
         public static string BreakCamelCase(string str)
          {       
            StringBuilder brokenString = new StringBuilder();
            foreach(var ch in str){
                if(char.IsUpper(ch)){
                    brokenString.Append(" ");
                }
                brokenString.Append(ch);
            }            
            return brokenString.ToString();
          }
    }
}
//Complete the solution so that the function will break up camel casing, using a space between words.
//Kata.BreakCamelCase("camelCasing") => "camel Casing"
