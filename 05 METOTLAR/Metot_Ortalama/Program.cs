using System.Security.Cryptography;

namespace Metot_Ortalama
{
    internal class Program
    {

        static double ortalama(double n1, double n2, double n3)
        {
            double sonuc;
            sonuc = (n1 + n2 + n3) / 3;
            return sonuc;
        } 
        static void Main(string[] args)
        {
            double s1, s2, s3;

            Console.Write("1. notu giriniz:");
            s1 = double.Parse(Console.ReadLine());

            Console.Write("2. notu giriniz:");
            s2= double.Parse(Console.ReadLine());

            Console.Write("3. notu giriniz:");
            s3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ortalama:"+ortalama(s1,s2,s3));
        }
    }
}
