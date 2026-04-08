namespace YasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas, dogumTarihi;

            Console.WriteLine("Doğum tarihinizi giriniz:");
            dogumTarihi= int.Parse(Console.ReadLine());

            yas = 2026 - dogumTarihi;
            Console.WriteLine("Yaşınız:" + yas);

        }
    }
}
