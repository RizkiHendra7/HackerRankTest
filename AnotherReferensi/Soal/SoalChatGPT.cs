using System.Collections.Generic;

namespace AnotherReferensi.Soal
{
    public class SoalChatGPT
    {
        public void Palindrome()
        {
            Console.WriteLine("Palindrome");
            Console.Write("INPUT : ");

            var Words = Console.ReadLine();
            var LtData = Words.Replace(" ",string.Empty).ToUpper().Select(x => x.ToString()).ToList();
            var result = true;

            for(int idx = 0, idxNeg = LtData.Count - 1; idx < LtData.Count(); idx++, idxNeg--)
            {
                result = LtData[idx].Equals(LtData[idxNeg]);
                if (!result) break;
            }

            Console.WriteLine("RESULT : ", result.ToString());

        }

    }
}
