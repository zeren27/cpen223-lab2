// Lab 2 
// Student name: Zeren Ulutas
// Student number: 18622894

using System;
using System.ComponentModel.DataAnnotations;
using System.Text; //Use only if StringBuilder is needed
//Do not include any more using statement or any unpermitted type

string userName = "Write Your Name Here";
Console.WriteLine($"CPEN223 Lab 2 for user: {userName}");

//Testing: Write some test cases to test well all methods you are to implement    
//         This is to demonstrates what test cases you have considered
//TODO 
// Test case 1 for HexToDecimalNumber
// Console.WriteLine($"hex=AAA; Expected value: 2730, Returned value: {Lab2.HexToDecimalNumber("AAA")}");
// Test case 2 for HexToDecimalNumber
// Console.WriteLine($"hex=1ABF003; Expected value: 28045315, Returned value: {Lab2.HexToDecimalNumber("1ABF003")}");
// Test case 3 for HexToDecimalNumber
// Console.WriteLine($"hex=4B82F109; Expected value: 1,266,872,585, Returned value: {Lab2.HexToDecimalNumber("4B82F109")}");
// Test case 4 for HexToDecimalNumber
// Console.WriteLine($"hex=0; Expected value: 0, Returned value: {Lab2.HexToDecimalNumber("0")}");

// Test case 1 for AreAnagrams
// Console.WriteLine($"str1 = listen, str2 = silent, Expected return = True; Returned value: {Lab2.AreAnagrams("listen", "silent")}");
// Test case 2 for AreAnagrams
// Console.WriteLine($"str1 = '  ', str2 = '  ', Expected return = True; Returned value: {Lab2.AreAnagrams("  ", "  ")}");
// Test case 3 for AreAnagrams
// Console.WriteLine($"str1 = ClintEastwood, str2 = OldWestAction, Expected return = False; Returned value: {Lab2.AreAnagrams("ClintEastwood", "OldWestAction")}");
// Test case 4 for AreAnagrams
// Console.WriteLine($"str1 = a red bug, str2 = bag rude, Expected return = False; Returned value: {Lab2.AreAnagrams("a red bug", "bag rude")}");


//end Testing code

//Do not change the program skeleton
public class Lab2
{
    // Do not change method headers. 
    // Only add code where it is requested.

    /// <summary>
    /// computes decimal equivalent of a hexadecimal number
    /// </summary>
    /// <param name="hexadecimal">the hexadecimal number passed as a string</param>
    /// <returns>decimal equivalent which is a non-negative int</returns>
    public static int HexToDecimalNumber(string hexadecimal)
    {
        //TODO: To Implement
        int length = hexadecimal.Length;
        int total = 0;

        // Set an index in a for loop to go through each entry in the string until the index reaches the end of the string.
        for (int index = 0; index <= length - 1; index++)
        {
            // Let entry be the corresponding value of the string at index and let num be the numerical equivalent of that entry.
            char entry = hexadecimal[index];
            int num = 0;
            
            // Check if the entry is between 0 and 9, inclusive. If so, use the conversion formula for numbers.
            if (entry >= '0' && entry <= '9')
            {
                num = entry - '0';
            }

            // Check if the entry is between A and F, inclusive. If so, use the conversion formula for letters.
            else if (entry >= 'A' && entry <= 'F')
            {
                num = entry - 'A' + 10;
            }

            // Set a variable, "value", to keep track of the power of 16 in the method. Multiply the value with 16 until the index reaches length-1-index, since
            // the power is calculated from right to left.
            int value = 1;
            for (int i = 1; i <= length-1-index; i++)
            {
                value *= 16;
            }
            // Apply the conversion formula with a variable, "total".
            total += num * value;
        }
        return total;  //to fix 
    }

    /// <summary>
    /// checks if str1 and str2 are anagrams
    /// </summary>
    /// <param name="str1">the first string</param>
    /// <param name="str2">the second string</param>
    /// <returns>true if anagrams, false otherwise</returns>
    public static bool AreAnagrams(string str1, string str2)
    {
        //TODO: Implement
        int length1 = str1.Length;
        int length2 = str2.Length;
        bool check = true;

        // Check if the lengths of the two strings are the same. If they are not, meaning they don't have the same number of characters and therefore 
        // not an anagram, assign false to the "check" variable.
        if (length1 != length2)
        {
            check = false;
        }
        else
        {
            // Convert the strings into arrays of char. We do this
            char[] str1tochar = str1.ToCharArray();
            char[] str2tochar = str2.ToCharArray();

            // Sort the arrays into two different arrays of char.
            Array.Sort(str1tochar);
            Array.Sort(str2tochar);

            // Go through the arrays one by one with the for loop.
            for (int index1 = 0; index1 <= length1 - 1; index1++)
            {
                // Check if the entries at index1 in both arrays are the same. If not, assign false to the "check" variable.
                if (str1tochar[index1] != str2tochar[index1])
                {
                    check = false;
                }
            }
        }
        // If no change happens, the function will return true.
        return check;
    }
}