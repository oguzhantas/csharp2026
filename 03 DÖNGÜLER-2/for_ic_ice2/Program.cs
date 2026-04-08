namespace for_ic_ice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÇARPIM TABLOSU

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("====");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+i*j);
                }
            }
        }
    }
}
