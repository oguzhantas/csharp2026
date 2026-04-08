namespace for_dongu_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("Döngüden çıkıldı");
        }
    }
}
