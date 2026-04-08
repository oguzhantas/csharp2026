namespace for_ile_fidan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boy = 1;
            int i;
          
            i = 1;
            while (i <= 10)
            {
                boy += boy * 0.20;
                Console.WriteLine(i + ".yıl sonu boyu:" + boy);
                i++;
            }

        }
    }
}
