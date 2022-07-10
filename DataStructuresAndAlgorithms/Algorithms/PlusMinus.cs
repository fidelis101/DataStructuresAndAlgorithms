using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    class Result
    {
        public static string timeConversion(string s)
        {
            var timeSplit = s.Split(':');
            var hour = timeSplit[0];
            if (timeSplit[2].Substring(2) == "PM")
            {
                if (hour != "12")
                    hour = $"{(int.Parse(timeSplit[0]) + 12)}";
            }
            else
            {
                if (hour == "12")
                    hour = "00";
            }

            return $"{hour}:{timeSplit[1]}:{timeSplit[2].Substring(0, 2)}";
        }

        public static int lonelyinteger(List<int> a)
        {
            int i = 0;
            while (i < a.Count())
            {
                int count = a.Where(x => x == a[i]).Count();
                if (count == 1)
                    return a[i];
                i++;
            }
            return 0;
        }

        public static void plusMinus(List<int> arr)
        {
            var positiveCount = arr.Where(x => x > 0).Count();
            var negativeCount = arr.Where(x => x < 0).Count();
            var zeroCount = arr.Where(x => x == 0).Count();

            var positiveRatio = (double)positiveCount / (double)arr.Count();
            var negativeRatio = (double)negativeCount / (double)arr.Count();
            var zeroRatio = (double)zeroCount / (double)arr.Count();

            Console.WriteLine(positiveRatio.ToString("N6"));
            Console.WriteLine(negativeRatio.ToString("N6"));
            Console.WriteLine(zeroRatio.ToString("N6"));

        }

        public static void miniMaxSum(List<int> arr)
        {
            var sortedArray = arr.OrderBy(x => x).ToList();
            Int64 minValue = 0;
            Int64 maxValue = 0;

            for (int i = 0; i < sortedArray.Count() - 1; ++i)
            {
                minValue += sortedArray[i];
            }

            for (int i = 1; i < sortedArray.Count(); ++i)
            {

                maxValue += sortedArray[i];
                Console.WriteLine(maxValue);
            }
            Console.WriteLine($"{minValue} {maxValue}");
        }
    }

    class Solution
    {
        public static void Calc()
        {
            // int n = Convert.ToInt32(Console.ReadLine().Trim());

            // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Result.miniMaxSum(arr);
        }
    }
}