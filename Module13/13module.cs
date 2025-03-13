using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Module13
{
    /* 
        REGEX
        \d = finds the characters from 0-9

        (char1)-(char2) = finds from char1 to char2 in the alfabet
        
        ^(char) = finds the character
        
        [^(char)] = finds all except character
        
        .*(chars)$ = find a string with characters in the end

        . = finds all characters (except for terminators)

        (char1)|(char2) = finds ocurrences of char1 or char2

        (char1)[(char2)]? = finds the char1 with or without char2

        (char1)*(char2) = finds all char1 (being 0 or more) before char2
        
        (char1)+(char2) = finds all char1 (needing at least 1) before char2

        [(char1)(char2)(char3)] = funds all ocurrencies of char1, char2 and char3

        ((char1)(char2)(char3)) = funds all ocurrencies of char1, char2 and char3 in this order
    
    */

    public class Program1
    {
        public static void Main1(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Does 2 match patter: " + regex.IsMatch("2"));
            Console.WriteLine("Does a match patter: " + regex.IsMatch("a"));

            string pattern2 = "(the)";
            Regex regex2 = new Regex(pattern2);
            string text = "the quick brown fox jumped over the lazy dog";
            Match match = regex2.Match(text);
            MatchCollection matches = regex2.Matches(text);
        }
    }
}