namespace Dizi_Toplam_Dinamik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi; //referans tanımı
            int elemanSayisi=1, toplam=0;

            Console.Write("Eleman sayısını giriniz:");
            elemanSayisi = int.Parse(Console.ReadLine());

            dizi = new int[elemanSayisi];
            for(int i = 0; i < dizi.Length; i++)
            {
                Console.Write("Dizinin "+i+".elemanını giriniz:");
                dizi[i] = int.Parse(Console.ReadLine());    
            }
            for(int i = 0;i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            Console.WriteLine("Toplam:"+toplam);
        }
    }
}
