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
// Console.WriteLine($"str1 = madam curie, str2 =radium came, Expected return = True; Returned value: {Lab2.AreAnagrams("madam curie", "radium came")}");
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
        int length1 = str1.Length;
        int length2 = str2.Length;
        bool check = true;

        if (length1 != length2)
        {
            check = false;
        }
        else
        {
            char[] str1tochar = str1.ToCharArray();
            char[] str2tochar = str2.ToCharArray();

            Array.Sort(str1tochar);
            Array.Sort(str2tochar);

            for (int index1 = 0; index1 <= length1 - 1; index1++)
            {
                if (str1tochar[index1] != str2tochar[index1])
                {
                    check = false;
                }
            }
        }
        return check;
    }
}