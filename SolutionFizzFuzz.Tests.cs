using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
    
    using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
    //Multiples of 3 and 5 test cases
    [Test]
    public void MultiplesOfThreeAndFiveTest1()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(15);
        Assert.AreEqual("FizzBuzz", expectedResult);
    }
    
    [Test]
    public void MultiplesOfThreeAndFiveTest2()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(30);
        Assert.AreEqual("FizzBuzz", expectedResult);
    }
    
    
     [Test]
    public void MultiplesOfThreeAndFiveTest3()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(45);
        Assert.AreEqual("FizzBuzz", expectedResult);
    }
    
    [Test]
    public void MultiplesOfThreeAndFiveTest4()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(60);
        Assert.AreEqual("FizzBuzz", expectedResult);
    }
    
    //Test case for Multiples of 3
    [Test]
    public void MultiplesOfThreeTest1()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(3);
        Assert.AreEqual("Fizz", expectedResult);
    }
    
    //Test case for Multiples of 3
    [Test]
    public void MultiplesOfThreeTest2()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(6);
        Assert.AreEqual("Fizz", expectedResult);
    }
    
    //Test case for Multiples of 3
    [Test]
    public void MultiplesOfThreeTest3()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(9);
        Assert.AreEqual("Fizz", expectedResult);
    }
    
    //Test case for Multiples of 3
    [Test]
    public void MultiplesOfThreeTest4()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(36);
        Assert.AreEqual("Fizz", expectedResult);
    }
    
    //Test case for Multiples of 5
    [Test]
    public void MultiplesOfFiveTest1()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(25);
        Assert.AreEqual("Buzz", expectedResult);
    }
    
    
    
    [Test]
    public void MultiplesOfFiveTest3()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(125);
        Assert.AreEqual("Buzz", expectedResult);
    }
    
    [Test]
    public void MultiplesOfFiveTest4()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(250);
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
    
    [Test]
    public void AnyOtherNumberTest2()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(28);
        Assert.AreEqual("28", expectedResult);
    }
    
    //Test case for Zero
    [Test]
    public void ZeroTest()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(0);
        Assert.AreEqual("0 is Neither Positive nor Negative", expectedResult);
    }
    
    //Test case for Negative number
    [Test]
    public void NegativeNumberTest()
    {
        var solution = new Solution();
        var expectedResult = solution.PrintFizzBuzz(-1);
        Assert.AreEqual("Given number -1 is Negative.", expectedResult);
    }
}
}
