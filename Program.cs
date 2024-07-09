using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Part2
{
    // 1. Create a program called Recurse.cs and type in the following methods:
    public class Recurse
    {
        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }

        // rest: returns a new string that contains all but the
        // first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);  // Substring not substring, 's' need to be 'S'
        }

        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }

        // 2. Write some code in Main that tests each of these methods. Make sure they work,
        // and make sure you understand what they do.
        public static void Main(string[] args)
        {
            string testString = "My name is Prem Chhay!";

            // Test First method
            // Takes the first character of the given string and output it 'M'
            char firstChar = First(testString);
            Console.WriteLine($"First character of '{testString}': {firstChar}");

            // Test Rest method
            // Output 'y name is Prem Chhay!'
            string restOfString = Rest(testString);
            Console.WriteLine($"Rest of the string '{testString}': {restOfString}");

            // Test Length method
            // Count the length of the entire string including the spaces
            int lengthOfString = Length(testString);
            Console.WriteLine($"Length of the string '{testString}': {lengthOfString}");

            // Test WriteString method
            Console.WriteLine($"Printing each character of '{testString}' on a new line:");
            WriteString(testString);

            // Print an empty line
            Console.WriteLine();

            // Test WriteBackward method
            Console.WriteLine($"Printing each character of '{testString}' backward on a new line:");
            WriteBackward(testString);

            // Print an empty line
            Console.WriteLine();

            // Test ReverseString method
            string backwards = ReverseString(testString);
            Console.WriteLine(backwards);  // Output should be "!yahhC merP si eman yM"
        }

        // 3. Write a method called WriteString that takes a string as a parameter and that
        // prints the letters of the string, one on each line. It should be a void method.
        // WriteString: prints each character of the string on a new line
        public static void WriteString(string s)
        {
            // The foreach loop in C# is used to iterate over elements in a collection or an array.
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }

        // 4. Write a method called WriteBackward that does the same thing as WriteString but
        // that prints the string backward(one character per line).
        // WriteBackward: prints each character of the string backward on a new line
        public static void WriteBackward(string s)
        {
            // Start the loop from the last character index of the string
            // s.Length - 1 gives the index of the last character
            // i >= 0 ensures the loop runs until the first character index (0)
            // Decrement i after each iteration to move backward through the string
            for (int i = s.Length - 1; i >= 0; i--)
            {
                // Print the character at index i
                Console.WriteLine(s[i]);
            }
        }

        /* 5. Write a method called ReverseString that takes a string as a parameter and
        that returns a new string as a return value.The new string should contain the
        same letters as the parameter, but in reverse order.For example, the output of the
        following code
        string backwards = ReverseString("Allen Downey");
        Console.WriteLine(backwards);
        should be
        yenwoD nellA
        */

        // ReverseString: returns a new string with characters reversed
        public static string ReverseString(string s)
        {
            // Create a StringBuilder to efficiently build the reversed string
            StringBuilder reversed = new StringBuilder();

            // Iterate through the original string 's' from the last character to the first
            for (int i = s.Length - 1; i >= 0; i--)
            {
                // Append each character of 's' in reverse order to 'reversed'
                reversed.Append(s[i]);
            }
            // Convert StringBuilder 'reversed' to a regular string and return it
            return reversed.ToString();
        }
    }
}
