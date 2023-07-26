using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Programs.July25_2023
{
    internal class StringPalindrome
    {
        public static void PalinMain()
        {
            String str = "abcba";
            String rev = "";
            
            for(int i=str.Length-1; i>=0; i--)
            {
                Console.WriteLine(str[i]); //charAt(str(i)) equivalent in c# is just str[i]
                rev = rev + str[i];
            }
            if (rev.Equals(str))
            {
                Console.WriteLine("String "+str+" is a palindrome");
            }
            else
            {
                Console.WriteLine("String "+str+" is not a palindrome");
            }
          
        }
    }
}
