namespace Metod_05_kdvlifiyat
{
    internal class Program
    {
        static double kdvlifiyat(double fiyat, double kdvOran)
        {
            double sonuc;
            sonuc = fiyat + fiyat * kdvOran / 100;
           
            return (sonuc);
        }
        static void Main(string[] args)
        {
            double f = 200;
            double k = 20; // yüzde yirmi
            double s = kdvlifiyat(f, k);
            Console.WriteLine("KDVli Fiyat:"+s);

        }
    }
}
