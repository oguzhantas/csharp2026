using System.Diagnostics;

namespace Metot_Aralik_Topla
{
    internal class Program
    {
        static int AralikTopla(int baslangic, int bitis)
        {
            int toplam = 0;

            for (int i = baslangic; i <= bitis; i++)
            {
                toplam += i;
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            Stopwatch zaman = new Stopwatch();
            zaman.Start();
            Console.WriteLine("1 ile 3 arası toplam:"+AralikTopla(1, 3));
            Console.WriteLine("1 ile 1000000000 arası toplam:"+AralikTopla(1, 1000000000));
            zaman.Stop();
            Console.WriteLine("Geçen süre: " + zaman.ElapsedMilliseconds + " ms");
        }
    }
}
