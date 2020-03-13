/*
    Name: Roberto Sanchez
    Date: 4/8/19

    Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

    Example 1:

    Input: 121
    Output: true
    Example 2:

    Input: -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
    Follow up:

    Coud you solve it without converting the integer to a string?
 */
using System;

namespace sample1
{
    class Palidrome
    {
        static void Test(string[] args)
        {
            int val = 11;
            if(isPalindrome(val)){
                Console.WriteLine("Its a Palindrome!!!");
            }else{
                Console.WriteLine("Its NOT a Palidrome...");
            }
        }
        static bool isPalindrome(int val){
            string stringValue = val.ToString();
            // Filters out minimum values for palidromes
            if(val < 0){
                return false;
            }
            // Testing
            // Have a loop that compares the first and last characters until they reach the end.
            int j = stringValue.Length - 1;
            for(int i = 0; i<stringValue.Length; i++)
            {
                Console.WriteLine("Comparing ints "+stringValue[i]+" with "+ stringValue[j]);
                if(stringValue[i] != stringValue[j]){
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}
