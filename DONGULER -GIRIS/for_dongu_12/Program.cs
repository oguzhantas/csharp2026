namespace for_dongu_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            for(ch='a'; ch<= 'z'; ch++)
            {
                Console.WriteLine(ch+"="+(int)ch);
            }
            for (ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine(ch + "=" + (int)ch);
            }

        }
    }
}
