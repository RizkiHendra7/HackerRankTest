using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherReferensi.Soal
{
    public class IBM
    {
        public static void soal1_GetSessionCount()
        {
            //NOTES LOGIKA :

            //1. Gabungkan userIds[i] dan timestamps[i] → simpan berdasarkan user.
            //2. Untuk setiap user:
            //  A.Urutkan timestamps miliknya.
            //  b.Hitung session: mulai dari 1, setiap kali jarak antar event > timeout → tambah session.
            //3. Jumlahkan semua session dari semua user.

            //CONTOH INPUT :
            // Contoh input sesuai soal
            int timeout = 10;
            List<string> userIds = new List<string> { "u1", "u1", "u1", "u2", "u2", "u2", "u2" };
            List<int> timestamps = new List<int> { 1, 5, 17, 3, 10, 20, 35 };

            // Panggil function
            int result = getSessionCount(timeout, userIds, timestamps);

            // Tampilkan hasil
            Console.WriteLine("Total Sessions = " + result);
            // Expected Output: 4

        }

        // Function as required
        public static int getSessionCount(int timeout, List<string> userIds, List<int> timestamps)
        {
            // Dictionary untuk simpan data user -> daftar timestamps
            Dictionary<string, List<int>> userEvents = new Dictionary<string, List<int>>();

            for (int i = 0; i < userIds.Count; i++)
            {
                if (!userEvents.ContainsKey(userIds[i]))
                    userEvents[userIds[i]] = new List<int>();

                userEvents[userIds[i]].Add(timestamps[i]);
            }

            int totalSessions = 0;

            // Hitung session per user
            foreach (var pair in userEvents)
            {
                List<int> times = pair.Value;
                times.Sort(); // urutkan event waktu user tersebut

                int sessions = 1; // minimal 1 session jika ada event

                for (int i = 1; i < times.Count; i++)
                {
                    // Jika jarak timestamp lebih besar dari timeout → session baru
                    if (times[i] - times[i - 1] > timeout)
                        sessions++;
                }

                totalSessions += sessions;
            }

            return totalSessions;
        }

        public static void soal2_GraphConnectivity()
        {

        }

    }
}
