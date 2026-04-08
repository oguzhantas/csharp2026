
namespace for_while_nufus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nufus = 1000;
            int yil = 0;
            while (true)
            {
                nufus = nufus + nufus * 10 / 100;
                yil++;
                Console.WriteLine(yil + ".yıl sonu:" + nufus);
                if (nufus > 1000000)
                    break;
            }
            Console.WriteLine("Yıl:" + yil);
            Console.WriteLine("Nüfus:"+nufus );
        }
    }
}
