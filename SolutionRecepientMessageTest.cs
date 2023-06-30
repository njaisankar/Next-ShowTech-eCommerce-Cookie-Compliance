using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
    
    //Test case
    [Test]
    public void Test1()
    {
        var solution = new Solution();

        Assert.AreEqual("JoeBloggs", solution.GetRecipient("@JoeBloggs yo", 1));
    }

    //Test case 2 with special character in the end, that need to strip off
    [Test]
    public void Test2()
    {
        var solution = new Solution();

        Assert.AreEqual("FredBloggs", solution.GetRecipient("Hey @Joe_Bloggs what time are we meeting @FredBloggs?", 2));
    }
    
    //Test case to validate email which needs to skip
    [Test]
    public void EmailTest()
    {
        var solution = new Solution();

        Assert.AreEqual("", solution.GetRecipient("Hey @njaisankar your email id is njaisankar@gmail.com and git id is @jai_test", 2));
    }
    
    //Test case to check simple user name without any specail character
    [Test]
    public void UserNameWithHypenTest()
    {
        var solution = new Solution();

        Assert.AreEqual("njaisankar", solution.GetRecipient("Hey @njaisankar your email id is njaisankar@gmail.com and git id is @jai_test", 1));
    }

    //Test case for user name with allowed special character and endwith special character that needs to strip off
    [Test]
    public void UserNameWithSpecialCharTest()
    {
        var solution = new Solution();

        Assert.AreEqual("jai-sankar_n", solution.GetRecipient("Hey @njaisankar your email id is njaisankar@gmail.com and git id is @jai-sankar_n!", 3));
    }

    //Test case for user name which is does not match
    [Test]
    public void UserNameNotMatchTest()
    {
        var solution = new Solution();

        Assert.AreEqual("", solution.GetRecipient("Hey @njaisankar your email id is njaisankar@gmail.com and git id is @jai-sankar_n!", 4));
    }

    //Test case for user name contains any special character, separate out with rest of char
    [Test]
    public void UserNameWithSpecialCharacterTest()
    {
        var solution = new Solution();

        Assert.AreEqual("jai-san", solution.GetRecipient("Hey @njaisankar your email id is njaisankar@gmail.com and git id is @jai-san#kar_n!", 3));
    }
}
