namespace for_sonsuz_dongu_renkler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; ;i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("KIRMIZI");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Beyaz");
                }
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
