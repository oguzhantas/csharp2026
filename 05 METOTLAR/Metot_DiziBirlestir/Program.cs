namespace Metot_DiziBirlestir
{
    internal class Program
    {
        static string[] birlestir(string[] ad, string[] soyad)
        {
            string[] tamAd = new string[ad.Length];
            for (int i = 0; i < ad.Length; i++)
            {
                tamAd[i] = ad[i] + " " + soyad[i];
            }
            return tamAd;
        }
        static void Main(string[] args)
        {
            string[] isimler= { "Ahmet", "Mehmet", "Ayşe" };
            string[] soyisimler = { "Yılmaz", "Demir", "Kara" };    
            string[] tamisimler = birlestir(isimler, soyisimler);
            for (int i = 0; i < tamisimler.Length; i++) 
                Console.WriteLine(tamisimler[i]);
        }
    }
}
