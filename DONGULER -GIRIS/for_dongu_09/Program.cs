namespace for_dongu_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sayac=0;
            for (i = 100; i <= 200; i++)
            {
                if (i % 21 == 0)
                {
                    sayac++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Sayaç:"+sayac);
        }
    }
}
