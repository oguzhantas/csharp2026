namespace Dizi_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 4, 7, 10 };
            Console.WriteLine("İlk eleman:"+sayilar[0]);

            Console.WriteLine("Son eleman:" + sayilar[3]);
            Console.WriteLine("Eleman sayısı:"+sayilar.Length);
            Console.WriteLine("Son eleman:"+sayilar[sayilar.Length-1]);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
