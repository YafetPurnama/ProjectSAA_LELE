using System;

namespace Week11_CobaCoba
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Progam Penampung Data Siswa";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.Write("\n");


            Console.Write("Mau Berapa orang :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mau Berapa mata pelajaran :");
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] Biodata = new string [m,n];
            int[] Totalarray = new int[n];

            for(int a = 0; a < m; a++ )
            {
                Console.Write("Nama :");
                Biodata[a, 0] = Console.ReadLine();
                Console.Write("Asal sekolah :");
                Biodata[a, 1] = Console.ReadLine();
                
                for (int i =  0; i < n; i++)
                {
                    Console.Write("Pelajaran ke - " + (i + 1) + " = ");
                    Totalarray[i] = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("IPA :");
                    //Biodata[i, 0] = Console.ReadLine();
                    //Console.Write("Matematika :");
                    //Biodata[i, 0] = Console.ReadLine();
                    //Console.Write("IPS :");
                    //Biodata[i, 0] = Console.ReadLine();
                    //Console.Write("Bahasa Indonesia :");
                    //Biodata[a, 0] = Console.ReadLine();

                } 
            }
            int maukeberapa;
            while (true)
            {
                Console.Write("Data ke berapa :");
                maukeberapa = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Siswa yang bernama" + Biodata[maukeberapa - 1,2]);
                Console.Write(Biodata[maukeberapa - 1, 0]);
                Console.Write("berasal dari sekolah" + Biodata[1, 3]);
                Console.Write("nilainya dari");


                for (int i = 0; i < n; i++)
                {
                    Console.Write("Pelajaran ke - " + (i + 1) + " = " + "adalah");
                    Console.Write(Totalarray[i]);
                }

                return;
            }


        }
    }
}
