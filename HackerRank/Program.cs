using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRank
{
    class Program
    {
        public static int palindrome(string s)
        {
            var ltS = s.Split();
            var distinctLtS = s.Split().Distinct().ToList();
            var dtS = new Dictionary<string, string>();

            for (var idx = 0; idx < ltS.Count(); idx++)
            {
                if (string.IsNullOrEmpty(dtS.Where(x => x.Key == ltS[idx]).Select(x => x.Value).FirstOrDefault())){
                    dtS.Add(ltS[idx], ltS[idx]);
                }

                for (var idx2 = idx + 1; idx2 < ltS.Count(); idx2++)
                {
                    if (string.IsNullOrEmpty(dtS.Where(x => x.Key == ltS[idx] + ltS[idx2]).Select(x => x.Value).FirstOrDefault())){
                        dtS.Add(ltS[idx] + ltS[idx2], ltS[idx] + ltS[idx2]);
                    }


                }

            }
            return dtS.Count();
        }

        public static string smallestString(List<string> substrings)//3
        {
            string result = string.Empty;
            foreach (string temp in substrings.OrderBy(x => x).ToList())
            {
                result += temp;
            }
            return result;
        }

        public static List<int> subsetA(List<int> arr)//2
        {
            var distinctData = arr.Distinct().OrderByDescending(x => x).ToList();
            var listSelected = new List<int>();
            var result = new List<int>();
            var startIteration = true;

            for (var updown = 0; updown < distinctData.Count(); updown++)
            {
                if (listSelected.Where(x => x == distinctData[updown]).FirstOrDefault() == 0)
                {
                    for (var couple = updown + 1; couple < distinctData.Count(); couple++)
                    {
                        if (listSelected.Where(x => x == distinctData[couple]).FirstOrDefault() == 0)
                        {
                            var temp = arr.OrderByDescending(x => x).ToList();
                            temp.Remove(distinctData[updown]); temp.Remove(distinctData[couple]);
                              if (temp.Sum() < (distinctData[updown] + distinctData[couple])) { 
                                var value = listSelected.Where(x => x == distinctData[couple]).FirstOrDefault();
                                if (value == 0)
                                {
                                    listSelected.Add(distinctData[couple]);
                                }
                                if (startIteration)
                                {
                                    startIteration = false;
                                    listSelected.Add(distinctData[updown]);
                                }

                            }
                        }
                    }
                }

            }


            foreach (var idxSelected in listSelected)
            {
                var totalData = arr.Where(x => x == idxSelected).Count();
                for (int idxTotal = 0; idxTotal < totalData; idxTotal++)
                {
                    result.Add(idxSelected);
                }
            }
            return result.OrderBy(x => x).ToList();
        }

        public static long countMax(List<string> upRight)//1
        {
            var tempData = new Dictionary<string, int>();
            foreach (var idxUpRight in upRight)
            {
                var ltString = idxUpRight.Split(' ');
                for (var idx = 1; idx <= Convert.ToInt32(ltString[0]); idx++)
                {
                    for (var idx2 = 1; idx2 <= Convert.ToInt32(ltString[1]); idx2++)
                    {
                        var selectedData = tempData.Where(x => x.Key == idx + " " + idx2).Select(x => x.Value).FirstOrDefault();
                        if (selectedData > 0)
                        {
                            tempData[idx + " " + idx2]++;
                        }
                        else
                        {
                            tempData.Add(idx + " " + idx2, 1);
                        }
                    }

                }
            }

            var highestValue = tempData.Max(x => x.Value);
            return tempData.Where(x => x.Value == highestValue).Count();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            return Math.Abs((arr[0][0] + arr[1][1] + arr[2][2]) - (arr[0][2] + arr[1][1] + arr[2][0]));
        }
         
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int>();
            int valA = 0;
            int valB = 0;
            for (var idx = 0; idx < a.Count(); idx++)
            {
                valA = a[idx] > b[idx] ? valA + 1 : valA;
                valB = a[idx] < b[idx] ? valB + 1 : valB;
            }
            result.Add(valA);
            result.Add(valB);
            return result;

        }

        public static List<int> gradingStudents(List<int> grades)
        {
            var result = new List<int>();
            foreach (var dt in grades)
            {
                result.Add(dt >= 38 && dt % 5 > 2 ? dt + 5 - (dt % 5) : dt);
            }
            return result;
        }

        public static int findDigits(int n)
        {
            var m = n;
            var result = 0;
            while (m > 0)
            {
                int curDigit = m % 10;
                m /= 10; 
                if (curDigit != 0 && n % curDigit == 0)
                {
                    result++;
                }
            }
            return result;
        }

        public static int TotalbirthdayCakeCandles(List<int> candles)
        {
            return candles.Sum();
        } 

        public static int birthdayCakeCandles(List<int> candles)
        {
            Dictionary<string, int> dt = candles.GroupBy(x => x).Where(x => x.Count() > 1).ToDictionary(x => x.Key.ToString(), x => x.Count());
            return dt.Max(x => x.Value);
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            var dt = ar.GroupBy(x => x).Where(x => x.Count() > 1).ToDictionary(x => x.Key.ToString(), x =>  Convert.ToInt32(x.Count() / 2));
            result = dt.Sum(x=> x.Value);
            return result;
        }
         
        public static int pageCount(int n, int p)
        {
            var totalPageFromFront = n / 2;
            var targetPageTurnCountFromFront = p / 2;
            var targetPageTurnCountFromBack = totalPageFromFront - targetPageTurnCountFromFront;
            return Math.Min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);
        }
         
        public static string soal1BukaLapak(int A, int B)
        {
            var result = string.Empty; 
            int iterationA = 0; int iterationB = 0;
            if(A > B || A ==B)
            {
                for (var idx = A; idx > 0; idx--)
                {
                    if(iterationA < 2)
                    {
                        result += "a";
                        A--; iterationA++;
                    }
                    else if( B > 0)
                    {
                        result += "ba";
                        B--; iterationA = 1;
                    } 
                }
                while(B != 0)
                {
                    result += "b";
                    B--;
                }
            }
            else
            {
                for (var idx = B; idx > 0; idx--)
                {
                    if (iterationB < 2)
                    {
                        result += "b";
                        B--; iterationB++;
                    }
                    else if (A> 0)
                    {
                        result += "ab";
                        A--; iterationB= 1;
                    }
                }
                while (A != 0)
                {
                    result += "a";
                    A--;
                }
            }

            return result;
        }

        public static int soal2BukaLapak(List<int> rank)
        {
            var result = 0;
            Dictionary<int, int> dt = rank.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            List<int> distinctData = rank.Distinct().ToList();

            foreach(var idxData in dt)
            {
                int? tempValue = distinctData.Where(x => x == idxData.Key + 1).FirstOrDefault();
                result = tempValue != 0? result + idxData.Value : result;
            }

            return result;
        }
         
        public static int soal3BukaLapak(int N, int K)
        {
            var result = 0;
           // soalnya gak jeals
            return result;
        }

        public static void Main(string[] args)
        {

            #region 4_diagonalDifference

            #endregion

            #region 3_compareTriplets 
            //var a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            //var b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList(); 
            //var result = compareTriplets(a,b);
            #endregion

            #region 5_gradingStudents 
            //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            //var result = gradingStudents(candles);
            #endregion

            #region 6_findDigits
            //var result = findDigits(Convert.ToInt32(Console.ReadLine()));
            #endregion

            #region 1_birthdayCakeCandles
            //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            //int result = birthdayCakeCandles(candles);
            #endregion

            #region 2_TotalbirthdayCakeCandles
            //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            //int result = birthdayCakeCandles(candles);
            #endregion

            #region 7_sockMerchant
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            //int result = sockMerchant(n, ar);
            #endregion

            #region 8_pageCount
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //int p = Convert.ToInt32(Console.ReadLine().Trim());
            //int result = pageCount(n, p);
            #endregion

            #region soal1BukaLapak 

            //int a = Convert.ToInt32(Console.ReadLine().Trim());
            //int b = Convert.ToInt32(Console.ReadLine().Trim());
            //var result = soal1BukaLapak(a,b);
            #endregion

            #region soal2BukaLapak 
            //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            //int result = soal2BukaLapak(ar);
            #endregion

            #region TOKPED 1 
            //var ar = Console.ReadLine().TrimEnd().Split('|').ToList();
            //var result = countMax(ar);
            #endregion

            #region Tokped2
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            var result = subsetA(ar);
            Console.WriteLine(String.Join("\n", result));
            #endregion

            Console.WriteLine(result.ToString());
            Console.ReadLine(); 
        }
    }
}
