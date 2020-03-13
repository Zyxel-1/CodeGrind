/*
    Name: Roberto Sanchez
    Date: 04/9/19

    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000
    For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9.
    X can be placed before L (50) and C (100) to make 40 and 90.
    C can be placed before D (500) and M (1000) to make 400 and 900.
    Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
*/
using System;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "MMMCMXCIX";
            int value = RomanToInt(input);
            Console.WriteLine("The integer representation of " + input + " is "+ value);
        }
        static int RomanToInt(string s)
        {
            // Begin Parsing the string
            Console.WriteLine(s);
            int sum = 0;
            for(int i = 0; i < s.Length;i++)
            {
                switch(s[i]){
                    case 'I': sum += 1;
                    break;
                    case 'V': sum += 5;
                    break;
                    case 'X': sum += 10;
                    break;
                    case 'L': sum += 50;
                    break;
                    case 'C': sum +=100;
                    break;
                    case 'D': sum +=500;
                    break;
                    case 'M': sum += 1000;
                    break;
                }
            }
            // Searching for substrings
            string num4 = "IV";
            string num9 = "IX";
            string num40 = "XL";
            string num90 = "XC";
            string num400 = "CD";
            string num900 = "CM";
            // Subtracting
            if(s.Contains(num4) || s.Contains(num9))
            {
                sum -= 2;
            }
            if(s.Contains(num40) || s.Contains(num90)){
                sum -= 20;
            }
            if(s.Contains(num400) || s.Contains(num900)){
                sum -= 200;
            }
            return sum;
        }
    }
}
