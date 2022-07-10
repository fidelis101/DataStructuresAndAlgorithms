using System;

namespace DataStructuresAndAlgorithms{
    public static class MyStringExtention{
        public static bool CheckPalindrome(this string s)
        {
            var reversedString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedString += s[i];
            }
            Console.WriteLine("reversed: " + reversedString);

            return s == reversedString;
        }

         public static string LongestPalindrome(this string s)
            {
                //Flip String
                //Check Whole String Palindrome
                //Check Cases with first Character
                //Check from next Character with string lenghtof current pStrng

                string pSubString = "";
                string fString = FlipString(s);

                if (s == fString)
                    return fString;

                for (int i = 0; i < s.Length; i++)
                {
                if (pSubString.Length < (s.Length - i))
                    for (int j = pSubString.Length + 1; j <= s.Length - i; j++)
                    {
                            string checkString = s.Substring(i, j);
                            fString = FlipString(checkString);
                            if (fString == checkString && fString.Length > pSubString.Length)
                                pSubString = checkString;
                        }
                }

                return pSubString;
            }

            private static string FlipString(string s)
            {
                string testString = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    testString += s[i].ToString();
                }
                return testString;
            }
        }
}