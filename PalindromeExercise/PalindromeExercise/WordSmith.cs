using System;
//'System' gives access to basic .NET funtions.
//'Sytem.Linq' allows use of LINQ

using System.Linq;
    

namespace PalindromeExercise;
//Defines the namespace for the class. A namespace is used to organize code and avoid naming conflicts.


public class WordSmith
//'public' means this class can be accessed from other parts of the program.
//'WordSmith' is the name of the class. It represents a bluprint for checking if words are palindromes.
//
{
    public WordSmith()
    {//Constructore for the WordSmith class.
        //its empty for now but could be used to initilize data in the future.
        
    }
    //This method takes in a word as input, checks if it reads the same forward and backward (ignoring case), and returns true if it is a palindrome and false if it is not.
    public bool isAPalindrome(string word)
    
        //'public' means it can be called from outside the class.
    //'bool' means the method returns either true or false.
    //'string word' is the parameter, which is the word we are checking.
    {
        var reversed = "";
        // A variable 'reversed' is declared and initialized as a empty string.
        //It will store the reversed versiohn of the input word.

        for (int i = word.Length - 1; i >= 0; i--)
            //This is a for loop that starts at the last charater of the word and moves backwards.
        //'word.Lenght - 1' gets the index of the last character.
        // The loop runs until it reaches the beginning of the word (i>=0).
        {
            reversed += word.ToLower()[i];
            //Adds each lowercase letter from the end of the original word to the 'reversed'  string.
            //'ToLower()' is used to make the comparison case insentive.
        }

        if (reversed == word.ToLower())
            //Checks if the resersed word is the same as the orginal word(in lowescase).
        {
            return true;
            //If they match, the word is palindrome, so it returns true.

        }
        else
        {
            return false;
            //If they don't match, the word is not palindrome, so it returns false.
        }
    } 
    
}