namespace dizi_dinamik_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dinamik dizi, eleman sayısını kullanıcı girecek
            int elemanSayisi;
            Console.Write("Dizi kaç elemanlı olsun:");
            elemanSayisi = int.Parse(Console.ReadLine());

            int[] dizi = new int[elemanSayisi];
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("{0}. elemanı giriniz:",i+1);
                dizi[i]=int.Parse(Console.ReadLine());
                toplam += dizi[i];
            }
            double ortalama = toplam /(double)dizi.Length;
            Console.WriteLine("Toplam:"+toplam);
            Console.WriteLine("Ortalama:" + ortalama);

        }
    }
}
