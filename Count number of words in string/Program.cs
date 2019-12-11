﻿using System;
public class Exercise5
{
    public static void Main()
    {
        string str;
        int i, wrd, l;

        Console.Write("\n\nCount the total number of words in a string :\n");
        Console.Write("------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        l = 0;
        wrd = 1;

        /* loop till end of string */
        while (l <= str.Length - 1)
        {
            /* check whether the current character is white space or new line or tab character*/
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
    }
}
/*
Count the total number of words in a string :
------------------------------------------------------
Input the string : today is not saturday
Total number of words in the string is : 4
Press any key to continue . . .

*/
