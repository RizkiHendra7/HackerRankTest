using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherReferensi.Soal
{
    public class Meratus
    { 

        /* 
               Jadi yg pertama itu lisan:
               - Ada 2 jam pasir yang 1 10 detik yang 1 lagi 6 detik gmn caranya dia bisa ke 14 detik? (pikirin dlu logicnya kasih tau aku abis itu translate logicnya ke kodingan)
               - ⁠def find_words_with_letters(words, letters):
                   return {word for word in words if all(c in letters for c in word)}

               # Example usage:
               words1 = {"JAVA","POINT","QUIZ"}
               letters1 = {"Q","P","I","V","Z","U"}
               print(find_words_with_letters(words1, letters1))  # Output: {"QUIZ"}

               words2 = {"JAVA","POINT","QUIZ"}
               letters2 = {"N","A","J","T","Z","Q","O","P","I","V"}
               print(find_words_with_letters(words2, letters2))  # Output: {"JAVA", "POINT"}

            */
 
        public static void jamPasir()
        {    
            Console.WriteLine("Opsi mana yang kamu pilih 1 / 2 ? : ");
            var param = Convert.ToInt32(Console.ReadLine()); 

            if(param == 1)
            {
                int jam2Awal = 6;
                int jam2Sisa = 6;
                int printSecond = 0;
                #region Opsi 1
                /*OPSI 1 => Jam 1 running duluan di detik ke 8s dibalik + Jam 2 running 6 detik jadinya 14s 
                  Key = cukup Jam2 lebih kecil*/
                for (int jamGabungan = 1; jamGabungan <= jam2Awal; jamGabungan++)
                {
                    if (printSecond == 14) break;
                    //Jam1Sisa++;
                    jam2Sisa--;
                    printSecond++;
                    Console.WriteLine(printSecond);
                    if (jam2Sisa == 0)
                    {
                        jamGabungan = 0;
                        jam2Sisa = 6;
                    }
                }
                #endregion
            }
            else
            {
                #region OPSI 2
                /*Jika disuruh print 2 2 nya*/

                var totalJamPasir1 = 10;
                var totalJamPasir2 = 6;
                var sisaJamPasir1 = 10;
                var sisaJamPasir2 = 6;
                var totalInSecond = 0;
                var totalPutar = 1;


                for (var idx = 0; idx < totalJamPasir2; idx++)
                {
                    if (totalInSecond == 14) break;

                    totalInSecond++;
                    sisaJamPasir2--;
                    sisaJamPasir1--;
                    Console.WriteLine("Detik ke : " + totalInSecond.ToString());
                    Console.WriteLine("Jam Pasir 1 : " + sisaJamPasir1.ToString());
                    Console.WriteLine("Jam Pasir 2 : " + sisaJamPasir2.ToString());

                    if (sisaJamPasir2 == 0)
                    {
                        Console.WriteLine("=== Putar Jam === ");
                        totalPutar++;
                        sisaJamPasir2 = 6;
                        sisaJamPasir1 = totalPutar % 2 == 1 ? 10 : 6;
                        idx = -1;
                    }

                }




                #endregion
            }









        }
        public static void find_words_with_letters()
        { 
            var words = new HashSet<string> { "JAVA", "POINT", "QUIZ" };
            var letters = new HashSet<string> { "Q", "P", "I", "V", "Z", "U" }; 
            letters = new HashSet<string> { "N", "A", "J", "T", "Z", "Q", "O", "P", "I", "V" };


            var result = new List<string>();

            foreach (var word in words)
            {
                var tempWords = word.ToString();
                foreach (var letter in letters)
                {
                    if (tempWords.Contains(letter))
                    {
                        tempWords = tempWords.Replace(letter, "");
                    }

                    if (string.IsNullOrEmpty(tempWords))
                    {
                        result.Add(word);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }

        public static void flavorWendyDoesntLike()
        {
            /*
             Wendy has 8 flavors of candy with an uneven amount, namely:
            - Orange: 4
            - Lemon: 3
            - Mint: 1
            - Chocolate: 4
            - Coffee: 4
            - Lime: 6
            - Strawberry: 2
            - Mango: 6
                From the list above, there are some candy flavors that Wendy doesn't like. 
                Wendy decided to give the candy flavor he didn't like to other people, 
                and that flavor was the candy with the most amount. 
            Please help Wendy determine how many flavors, what flavors it is, and the total of candy.
            Input:
            [4,3,1,4,4,6,2,6]
            Output:
            Total Disliked Flavors: 2
            Disliked Flavors: Lime Mango
            Sum of Disliked Candy: 12
             */


            var ltCandy = new List<string> { "Orange", "Lemon", "Mint", "Chocolate", "Coffee", "Lime", "Strawberry", "Mango" };
            var input = new List<int>() { 4, 3, 1, 4, 4, 6, 2, 6 };
            string dislikeFlavorsName = "";

            //total dislike
            int maxAmount = input.OrderByDescending(x => x).FirstOrDefault();
            int totalDislike = input.Where(x => x == maxAmount).Count();
            int sumDislike = 0;

            //Dislike Flavors
            for (var idx = 0; idx < input.Count(); idx++)
            {
                if (input[idx] == maxAmount)
                {
                    dislikeFlavorsName += " " + ltCandy[idx];
                    sumDislike += input[idx];
                }
            }




            Console.WriteLine("Total Disliked Flavors: " + totalDislike.ToString());
            Console.WriteLine("Disliked Flavors:" + dislikeFlavorsName);
            Console.WriteLine("Sum of Disliked Candy: " + sumDislike.ToString());
        }

    }
}
