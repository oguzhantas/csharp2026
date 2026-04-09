namespace Metot_Rastgele
{
    internal class Program
    {
        static void essizRastgele(int baslangic, int bitis, int adet)
        {
            int[] dizi = new int[adet];
            Random rast = new Random();
            int sayi, index = 0;

            for (; ; )
            {
                sayi = rast.Next(baslangic, bitis + 1);
                if (!dizi.Contains(sayi))
                {
                    if (index < dizi.Length)
                    {
                        dizi[index] = sayi;
                        index++;
                    }
                }
                else continue;
                if (index == dizi.Length) break;
            } //döngü bitti
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }

static void rastgele(int baslangic, int bitis, int adet)
        {
            Random rastgele = new Random();
            double sayi;
            for (int i = 0; i < adet; i++)
            {
                sayi = rastgele.Next(baslangic, bitis+1);
                Console.WriteLine(sayi);
            }
        }
        static void Main(string[] args)
        {   //1 ile 50 arasında 6 adet sayı üretelim
            rastgele(1,49,6);
            Console.WriteLine("====");
            essizRastgele(1, 49, 6);
        }
    }
}
