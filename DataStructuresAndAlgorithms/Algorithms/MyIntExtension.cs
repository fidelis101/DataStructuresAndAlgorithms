using System;

namespace DataStructuresAndAlgorithms{
    public static class MyIntExtension{
        public static bool CheckPalindrome(this int num)
        {
            if(num < 0)
                return false;

            int num1 = num;
            int reversedNum = 0;
            while(num>0)
            {
                int temp = num % 10;
                reversedNum = reversedNum * 10 + temp;
                num = num / 10;
            }

            Console.WriteLine($"number is {num1} the reversed is: {reversedNum}");
            return num1 == reversedNum;
        }
    }
}