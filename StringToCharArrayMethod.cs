using System;
using System.Runtime.InteropServices;

class Sample
{
    public static void Main()
    {
        string str = "012wxyz789"; //this is the string that is being worked with 
        char[] arr; //create an array

        arr = str.ToCharArray(3, 4);
        Console.Write("The letters in '{0}' are: '", str);
        Console.Write(arr);
        Console.WriteLine("'");
        Console.WriteLine("Each letter in '{0}' is:", str);
        foreach (char c in arr)
            Console.WriteLine(c);
    }
}

//https://learn.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=net-7.0
