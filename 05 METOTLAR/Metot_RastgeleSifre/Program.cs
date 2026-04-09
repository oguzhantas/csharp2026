namespace Metot_RastgeleSifre
{
    internal class Program
    {

        static string rastgeleSifre()
        {
            string buyukharf, kucukharf, rakam, ozelkarakter, sifre="";
            char uretilen;
            Random rastgele= new Random();
            for(int i = 0; i < 2; i++)
            {
                uretilen =(char)(rastgele.Next(65,91));
                sifre+= uretilen;
            }
          
            for (int i = 0; i < 2; i++)
            {
                uretilen = (char)(rastgele.Next(97, 123));
                sifre += uretilen;
            }

            for (int i = 0; i < 2; i++)
            {
                uretilen = (char)(rastgele.Next(48, 58));
                sifre += uretilen;
            }
            for (int i = 0; i < 2; i++)
            {
                uretilen = (char)(rastgele.Next(33, 48));
                sifre += uretilen;
            }

            return sifre;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(rastgeleSifre());
        }
    }
}
