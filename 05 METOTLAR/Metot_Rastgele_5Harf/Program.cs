namespace Metot_Rastgele_5Harf
{
    internal class Program
    {
        static void rastgele(int baslangic, int bitis, int adet)
        {
            Random rastgele = new Random();
            char karakter;
            for (int i = 0; i < adet; i++)
            {
                karakter = (char)rastgele.Next(baslangic, bitis + 1);
                Console.WriteLine(karakter);
            }
        }
        static void Main(string[] args)
        {
            rastgele(65, 90, 5);
        }
    }
}
