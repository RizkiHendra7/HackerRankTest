
//Soal BSI
using AnotherReferensi.Soal;


while (true)
{
    Console.WriteLine("===== MENU SOAL =====");
    Console.WriteLine("1. [BSI] - Vocal Berulang");
    Console.WriteLine("2. [BSI] - Ganjil ** ");
    Console.WriteLine("3. [BSI] - Paliandrome");
    Console.WriteLine("4. [Meratus] - Find Word in letters");
    Console.WriteLine("5. [Meratus] - Jam Pasir");
    Console.WriteLine("6. [Meratus] - Flavor Wendy Doesnt Like");
    Console.WriteLine("7. [Meratus] - Reverse String Element");
    //Console.WriteLine("=== [MOST POPPULAR CHATGPT] ===");
    //Console.WriteLine("4. Palindrome String");
    //Console.WriteLine("5. Jumlah Digit");
    //Console.WriteLine("6. Balik Kata");
    //Console.WriteLine("7. Hitung Vokal & Konsonan");
    //Console.WriteLine("8. FizzBuzz");
    //Console.WriteLine("9. Angka Prima");
    //Console.WriteLine("10. Sorting Ganjil Genap");
    //Console.WriteLine("11. Two Sum");
    //Console.WriteLine("12. Hitung Karakter Unik");
    //Console.WriteLine("13. Pola Bintang");
    Console.WriteLine("0. Keluar");
    Console.WriteLine("==========================================");

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Input Nomor Soal : ");
    
    string pilihan = Console.ReadLine() ?? "0";
    Console.Clear();

    switch (pilihan)
    {
        case "1":
            #region SOAL
            /*
                INPUT 1 : INDONESIA
                INPUT 2 : 2 
            return IINDOONEESIIAA 
             */
            #endregion
            BSI.soal1(); break;
        case "2":
            #region SOAL
            /*
            INPUTAN : 1,7,6,4,9,3,2
            RESULT :   1**379
                       13**79 
                       137**9 
            */
            #endregion
            BSI.soal2(); break;
        case "3":
            #region SOAL
            /*  palindrome check

           1. INPUT : MALAM
              RESULT : TRUE

           2. INPUT : MAKAN
              RESULT : False

           3. INPUT : Dia haid
              RESULT : True

           4. INPUT : Kau muak
              RESULT : True

           */
            #endregion 
            BSI.soal3(); break;
        case "4":
            #region SOAL
            /*
             * def find_words_with_letters(words, letters):
                   return {word for word in words if all(c in letters for c in word)}

               # Example usage:
               words1 = {"JAVA","POINT","QUIZ"}
               letters1 = {"Q","P","I","V","Z","U"}
               print(find_words_with_letters(words1, letters1))  # Output: {"QUIZ"}

               words2 = {"JAVA","POINT","QUIZ"}
               letters2 = {"N","A","J","T","Z","Q","O","P","I","V"}
               print(find_words_with_letters(words2, letters2))  # Output: {"JAVA", "POINT"}
             */
            #endregion
            Meratus.find_words_with_letters(); break;
        case "5":
            #region Soal
            /* 
             * Ada 2 jam pasir yang 1 10 detik yang 1 lagi 6 detik gmn caranya dia bisa ke 14 detik? 
             * (pikirin dlu logicnya kasih tau aku abis itu translate logicnya ke kodingan)              
             */
            #endregion
            Meratus.jamPasir(); break;
        case "6":
            #region Soal
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
            #endregion
            Meratus.flavorWendyDoesntLike(); break;
        case "7":
            #region SOAL
            /*
                Given a string which contains special characters (!,@,#,$,%,^,&,*,(,),+,=,:) and characters ('a' to 'z' , 'A' to 'Z'),
                create a function to reverse string element order without affecting the special characters.
                Notes: input doesn't contain numbers
 
                Input:   str = "a!b#c"
                Output:  str = "c!b#a"
 
                Input:   str = "Ab+c:de()"
                Output:  str = "ed+c:bA()"
             */
            #endregion
            Meratus.ReverseStringElement(); break;
        case "0":
            #region SOAL

            #endregion
            return;

        default:
            Console.WriteLine("Pilihan tidak valid!");
            break;
    }

    Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
    Console.ReadLine();
    Console.Clear();
    //
    //BSI.soal2();
    //BSI.soal3();

}
