// Lab 2 
// Student name:
// Student number:

using System;
using System.Text; //Use only if StringBuilder is needed
//Do not include any more using statement or any unpermitted type

Console.WriteLine("CPEN223 Lab 2");

//Testing: Write some test cases to test well all methods you are to implement    
//         This is to demonstrates what test cases you have considered
//TODO 
Console.WriteLine($"hex=AAA; Expected value: 2730, Returned value: {Lab2.HexToDecimalNumber("AAA")}");


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
        return -1;  //to fix 
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
        return false;
    }

}