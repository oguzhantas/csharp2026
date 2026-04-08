namespace if_ikiyebolme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz:");
            sayi = int.Parse(Console.ReadLine());

            if(sayi%2==0)
                Console.WriteLine("Sayı ikiye bölünebilir");
            else
                Console.WriteLine("Sayı ikiye bölünemez");
        }
    }
}
