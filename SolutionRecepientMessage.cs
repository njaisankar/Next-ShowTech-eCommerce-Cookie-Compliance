using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public class Solution
{
    public string GetRecipient(string message, int position)
    {
        string expectedResult = string.Empty;
            // set pattern for valid characters in user name can contains
            string pattern = "^[A-Za-z][A-Za-z0-9-_]*$";
            Regex regex = new Regex(pattern);
            
            //To remove word if does not contains with @ symbol in starting of the sentences
            message = message.Substring(message.IndexOf('@'));

            //Split with @ symbol and make it list of user names
            string[] userNameList = message.Split('@');

            if (position > 0)
            {
                //Make sure given position is within the container size or limit
                if (position <= userNameList.Count() - 1)
                {
                    //Consider username only non-white space
                    string userName = userNameList[position].Split(' ')[0];
                    
                    //Remove any special chars if any other than allowed in valid user name
                    userName = RemoveSpecialCharacters(userName);
                    //validate user name with above mentioned pattern
                    if (regex.IsMatch(userName))
                    {
                        expectedResult = userName;
                    }
                }
            }

            return expectedResult;
    }
    
    private string RemoveSpecialCharacters(string message)
    {
        StringBuilder newUserName = new StringBuilder();
        foreach (char c in message)
        {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_' || c == '-' || c == '.')
            {
                newUserName.Append(c);
            }
            else // Stop loop if it deduct any special chars than allowed one
            {
                break;
            }
        }
        return newUserName.ToString();
    }
}l