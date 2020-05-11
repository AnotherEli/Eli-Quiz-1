using System;
using System.Collections.Generic;


namespace Palindrome_Stack_Problem
{
    class Program
    {
        /* 
         * Write a method that uses a Stack and a Queue to determine 
         * if a string is a palindrome.  The method should take a 
         * string s as its parameter and return a bool. Use your 
         * method to write an application that asks the user to enter 
         * a word or phrase from the keyboard and then tells the user 
         * whether or not the text that they entered is a palindrome.
         * 
         * A palindrome is a word, number, phrase, or other sequence 
         * of characters which reads the same backward as forward, 
         * such as madam, racecar.
         * 
         * Adding each character in the word or phrase to the stack 
         * and the queue in order, followed by removing each character 
         * from the stack and the queue in the natural order for each 
         * data structure and comparing the character from the top of 
         * the stack with the character from the front of the queue 
         * should help you identify if the word is a palindrome.
         */
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter a word or phrase to test if it's a palindrome: \n");
            str = Console.ReadLine();

            if (PalindromeStack(str))
                Console.WriteLine(str + " is a palindrome! ");
            else
                Console.WriteLine(str + " is not a palindrome. :( ");

        }

        static public bool PalindromeStack(string str)
        {
            bool isPalindrome = true;
            bool odd = false;

            string s = "";
            char c;
            //convert it into a solid block
            for (int i = 0; i < str.Length; i++)
                if (!Char.IsWhiteSpace(str[i]) && !Char.IsPunctuation(str[i]))
                    s += str[i];
           
            s = s.ToLower();
            
            Console.WriteLine('\n' + s + '\n');
            
            if (s.Length % 2 != 0)
                odd = true;

            int middle = s.Length / 2;
            Stack<char> firstLetters = new Stack<char>();
            Queue<char> lastLetters = new Queue<char>();

            //push characters to a stack until the middle
            for (int i = 0; i < middle; i++)
                firstLetters.Push(s[i]);
            
            int middleStart = middle;
            
            //if the number of characters is odd start at middle + 1 
            //else start at the middle
            if (odd)
                middleStart = middle + 1;
            //then enqueue the second half

            for (int i = middleStart; i < s.Length; i++)
                lastLetters.Enqueue(s[i]);
            //pop characters and compare the first half to the second
            while(firstLetters.Count != 0 && lastLetters.Count != 0)
            {
                char a = firstLetters.Pop();
                char b = lastLetters.Dequeue();
                if (!a.Equals(b))
                    isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
