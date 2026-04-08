namespace metod_03
{
    internal class Program
    {
        static int topla(int a, int b)
        {
            return (a + b);
        }
        static int carp(int a, int b)
        {
            return (a *b);
        }
        static int cikar(int a, int b)
        {
            return (a - b);
        }
        static double bolum(int a, int b)
        {
            return ((double)a / b);
        }
        static void Main(string[] args)
        {
            int x = 5, y = 6;
            int sonuc;
            sonuc = topla(x, y);
            Console.WriteLine("Sonuç"+sonuc);
            Console.WriteLine("Çarpım sonucu:"+ carp(x,y));
            Console.WriteLine("Çıkarım sonucu:" + cikar(x, y));
            Console.WriteLine("Bölüm sonucu:"+ bolum(x,y));
        }
    }
}
