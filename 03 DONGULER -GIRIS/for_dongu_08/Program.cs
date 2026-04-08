namespace for_dongu_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long i;
            for (i = 1; i < 10000000000000; i *= 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
