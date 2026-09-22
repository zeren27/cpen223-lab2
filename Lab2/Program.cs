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
//Console.WriteLine($"hex=AAA; Expected value: 2730, Returned value: {Lab2.HexToDecimalNumber("AAA")}");
Console.WriteLine($"hex=ABCD; Expected value: 43981, Returned value: {Lab2.HexToDecimalNumber("ABCD")}");

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

        for (int index = 0; index <= length - 1; index++)
        {
            int num = 0;
            char entry = hexadecimal[index];
            if (entry >= '0' && entry <= '9')
            {
                num = entry - '0';
            }
            else if (entry >= 'A' && entry <= 'F')
            {
                num = entry - 'A' + 10;
            }
            total += num * (int)Math.Pow(16, length-1-index);
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
        return false;
    }

}