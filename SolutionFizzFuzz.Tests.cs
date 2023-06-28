using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
    
    [Test]
    public void Test1()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(15);
        Assert.AreEqual("FizzBuzz", expectedResult);
    }
    
    //Test case for Multiples of 3
    [Test]
    public void MultiplesOfThreeTest()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(9);
        Assert.AreEqual("Fizz", expectedResult);
    }
    
    
    //Test case for Multiples of 5
    [Test]
    public void MultiplesOfFiveTest()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(25);
        Assert.AreEqual("Buzz", expectedResult);
    }
    
    //Test case for any other number than mulltiples of 3 or 5
    [Test]
    public void AnyOtherNumberTest1()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(22);
        Assert.AreEqual("22", expectedResult);
    }
    
    //Test case for Zero
    [Test]
    public void AnyOtherNumberTest2()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(0);
        Assert.AreEqual("0 is Neither Positive nor Negative", expectedResult);
    }
    
    //Test case for Negative number
    [Test]
    public void AnyOtherNumberTest()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(-1);
        Assert.AreEqual("Given number -1 is Negative.", expectedResult);
    }
}