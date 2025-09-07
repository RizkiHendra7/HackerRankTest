using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherReferensi.Soal
{
    public class BSI
    {
        public static void soal1()
        {
            /*
                INPUT 1 : INDONESIA
                INPUT 2 : 2
            return IINDOONEESIIAA
             
             
             */
            Console.Write("Words : ");
            var Words = Console.ReadLine();
            Console.Write("Count : ");
            var count = Convert.ToInt32(Console.ReadLine());
            var vocal = "AIUEO";
            var result = string.Empty;


            foreach (var temp in Words.ToUpper().ToList())
            {
                if (vocal.Contains(temp.ToString()))
                {
                    for (var idx = 0; idx < count; idx++)
                    {
                        result += temp.ToString();
                    }
                }
                else
                {
                    result += temp;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void soal2()
        {
            /*
             INPUTAN : 1,7,6,4,9,3,2
             RESULT :   1**379
                        13**79 
                        137**9
                
             
             */

            Console.Write("INPUT : ");
            var Words = Console.ReadLine();
            Words = Words.Replace(",", string.Empty);
            var ListDt = Words.Select(x => int.Parse(x.ToString())).Where(x => x % 2 == 1).OrderBy(x => x).ToList();
            var SortedList = new List<string>();

            ////Remove genap
            //foreach(var temp in  ListDt)
            //{
            //    if(temp %2 == 1) SortedList.Add(temp.ToString());
            //}

            Console.WriteLine("RESULT : ");

            for (var idx = 0; idx < SortedList.Count - 1; idx++)
            {
                var result = string.Empty;
                for (var idxWords = 0; idxWords < SortedList.Count(); idxWords++)
                {
                    result += idx == idxWords ? SortedList[idxWords] + "**" : SortedList[idxWords];
                }

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        public static void soal3()
        {
            /*

            palindrome check

             1. INPUT : MALAM
                RESULT : TRUE
             
             2. INPUT : MAKAN
                RESULT : False
                          
             3. INPUT : Dia haid
                RESULT : True

             4. INPUT : Kau muak
                RESULT : True
             
             */

            Console.Write("INPUT : ");
            var Words = Console.ReadLine();
            var ListDt = Words.ToUpper().Replace(" ", string.Empty).ToList();
            var Result = true;
            for (int idx = 0, idxNeg = ListDt.Count - 1; idx <= idxNeg; idx++, idxNeg--)
            {
                Result = ListDt[idx].Equals(ListDt[idxNeg]);
                if (!Result) break;
            }



            Console.Write("Result : " + Result.ToString());



        }

    }
}
