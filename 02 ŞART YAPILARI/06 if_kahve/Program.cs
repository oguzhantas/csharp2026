using System.Net.NetworkInformation;

namespace if_kahve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim, adet, toplam=0;
            Console.WriteLine("1) Latte 60 TL");
            Console.WriteLine("2) Americano 40 TL");
            Console.WriteLine("3) Macchiato 52 TL");
            Console.WriteLine("4) Filtre 45 TL");
            Console.Write("Seçiminiz:");
            secim = int.Parse(Console.ReadLine());
            Console.Write("Kaç adet:");
            adet= int.Parse(Console.ReadLine());

            if (secim == 1)
                toplam = 60 * adet;
            else if (secim == 2)
                toplam = 40 * adet;
            else if (secim == 3)
                toplam = 52 * adet;
            else if (secim == 4)
                toplam = 45 * adet;
            Console.WriteLine("Toplam ödenecek:"+toplam);



        }
    }
}
