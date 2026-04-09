namespace Metot_Varsayılan_Parametre
{
    internal class Program
    {

        static double KDVHesapla(double fiyat, int kdvOrani = 20)
        {
            return fiyat + (fiyat * kdvOrani / 100);
        }

        static void Main(string[] args)
        {
           double f, kdvOran, kdvliFiyat;
            f = 200;
            double sonuc1 = KDVHesapla(f); //Varsayılan %20'ye göre KDV hesaplar
            double sonuc2 = KDVHesapla(f, 10); //KDV Oranı olarak %10 alır.
            Console.WriteLine("%20 ye göre KDVli Fiyat:"+sonuc1);
            Console.WriteLine("%10 a göre KDVli Fiyat:" + sonuc2);

        }
    }
}
