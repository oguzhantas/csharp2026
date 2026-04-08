namespace for_dongu_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sayac = 0;
            for (i = 100; i <= 200; i += 5)
            {
                sayac++;
                Console.WriteLine(i);
            }
            Console.WriteLine(sayac + " adet sayı vardır");
            Console.ReadKey();
        }
    }
}
