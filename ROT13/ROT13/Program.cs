using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ROT13
{
    class Program
    {
        public static char Rot(char c)
        {
            if ('a' <= c && c <= 'm' || 'A' <= c && c <= 'M')
            {
                return (char)(c + 13);
            }
            if ('n' <= c && c <= 'z' || 'N' <= c && c <= 'Z')
            {
                return (char)(c - 13);
            }
            return c;
        }
        public static string En(string input)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Rot(ch);
            return output;
        }
        //public static string dE(string input)
        //{
        //    return En(input - 13);
        //}  
    static void Main(string[] args)
        {
            WriteLine("Please enter text for ROT!");
            string userin = ReadLine();
            WriteLine("\n");

            WriteLine("The encrypted message is:");
            string em = En(userin);
            WriteLine(em);
            WriteLine("\n");

            WriteLine("Enter 1 to show original message!");
            double uM = Convert.ToInt32(ReadLine());
            
            if(uM == 1)
            {
                WriteLine("Your decrypted message is:");
                string dm = userin;
                WriteLine(dm);
                WriteLine("\n");
            }

            ReadKey();
        }
    }
}
