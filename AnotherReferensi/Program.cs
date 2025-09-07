
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

    string pilihan = Console.ReadLine() ?? "0";
    Console.Clear();

    switch (pilihan)
    {
        case "1":
            BSI.soal1(); break;
        case "2":
            BSI.soal2(); break;
        case "3":
            BSI.soal3(); break;
        case "4":
            Meratus.find_words_with_letters(); break;
        case "5":
            Meratus.jamPasir(); break;
        case "0":
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
