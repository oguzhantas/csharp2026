namespace for_asal_kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            bool asal = true;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asal = false;
            }
            if (asal)
                Console.WriteLine("Sayı asal");
            else
                Console.WriteLine("Sayı asal değil");


        }
    }
}
