namespace Metod_Toplam
{
    internal class Program
    {
        static int topla(int a, int b)
        {
            return(a + b);
        }
        static void Main(string[] args)
        {
            int sonuc = topla(3, 4);
            Console.WriteLine(sonuc);

            int x=5, y=6;
            int sonuc2 = topla(x, y);
            Console.WriteLine(sonuc2);
        }
    }
}
