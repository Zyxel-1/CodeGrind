/*
    Name: Roberto Sanchez
    Date: 02/12/19

    Given a 32-bit signed integer, reverse digits of an integer.

        Example 1:

        Input: 123
        Output: 321
        Example 2:

        Input: -123
        Output: -321
        Example 3:

        Input: 120
        Output: 21
*/

public class ReverseS {
    public int Reverse(int x) {
        // Converting integer to string
        string val = x.ToString();
        // Check if first character is a '-' symbol to remove it
        if(val[0]=='-'){
            // Append it at the end of the string
            val+="-";
            // Remove it from the start of the string
            val = val.TrimStart('-');
        }
        // Convert each character to a character array to reverse them and back
        // to an array as a new string.
        string s = new string( val.ToCharArray().Reverse().ToArray());
        // Begin parsing string back to an integer
        int rev;
        if(!int.TryParse(s, out rev)){
            // integer overflow
            return 0;
        }else{
            // return new integer
            return Int32.Parse(s);
        }


    }
}
