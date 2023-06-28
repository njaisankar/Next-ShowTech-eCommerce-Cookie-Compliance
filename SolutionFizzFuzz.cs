using System;
using System.Collections.Generic;
using System.IO;

public class Solution
{
    /// <summary>
    /// Print Fizz Buzz FizzBuzz word based on given input number
    /// </summary>
    /// <param name="input"></param>
    /// <returns>string</returns>
    public string PrintFizzBuzz(int input)
    {
        var expectedResult = string.Empty;
       
        //Check given number is positive number
        if(input>0)
        {
            //Multiples of 3 * 5
            if(input==15)
            {
                expectedResult = "FizzBuzz";
            }
            //for Multiples of 3 or 5 or ?other then 3 and 5
            else if(input % 3 == 0)
            {
                expectedResult="Fizz";
            }
            else if(input % 5 == 0)
            {
                expectedResult="Buzz";
            }
            else
            {
                expectedResult = input.ToString();
            }
        }
        //Check given number is Zeor or Negative number
        else  
        {
            if(input == 0)
            {
                expectedResult=$"{input} is Neither Positive nor Negative";
            }
            else
            {
                expectedResult = $"Given number {input} is Negative.";
            }
        }
        
        return expectedResult;
    }
    
}


