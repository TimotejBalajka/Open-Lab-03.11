using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] charArray = str.ToCharArray();
            string  reversedString = "";
            for(int i = charArray.Length -1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            return reversedString ==str;

            
            if (reversedString == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }   
}
