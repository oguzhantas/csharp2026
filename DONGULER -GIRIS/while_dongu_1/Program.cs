namespace while_dongu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Döngüden çıkıldı");
            Console.WriteLine("Son i değeri:" + i);
        }
    }
}
