namespace for_dongu_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int i;
            for (i = 1; i <= 100; i++)
            {
                //toplam= toplam+i;
                toplam+=i;            
            }
            Console.WriteLine("Toplam:"+toplam);
        }
    }
}
