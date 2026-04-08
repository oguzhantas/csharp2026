namespace foreach_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] karakter = { '%', '+', '@', '/' };

            foreach (char k in karakter)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("=======");
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }
        }
    }
}
