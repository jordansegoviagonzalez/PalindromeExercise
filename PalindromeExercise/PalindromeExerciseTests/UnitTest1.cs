using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    //public class named 'UnitTest1' that will contain our test methods
    {
        [Theory]
        //This attribute mark the method as parameterized test
        //it will run multiple times with different sends of data provided by InlineData.
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", false)]
        public void PalindromeTester(string word, bool expected)
        //This method test if the value(word) is palindrome by checking if the result from the robot(isAPalindrome) matches what we expected.
        
        {
            //arrange
            var wordSmith = new WordSmith();
            //act
            var actual = wordSmith.isAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
