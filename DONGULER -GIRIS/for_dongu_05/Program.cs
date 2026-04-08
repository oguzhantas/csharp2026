namespace for_dongu_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 200; i >= 100; i -= 5)  
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Döngüden çıkıldı");  
            Console.ReadKey();
           
        }
    }
}
