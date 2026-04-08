namespace while_dongu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor= ConsoleColor.Red;
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("KIRMIZI");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BEYAZ");
                }
                i++;
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
