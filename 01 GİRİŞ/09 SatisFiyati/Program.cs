namespace SatisFiyati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fiyat, kar, satisFiyat;

            Console.Write("Fiyatı giriniz:");
            fiyat = double.Parse(Console.ReadLine());

            Console.Write("Karı giriniz:");
            kar = double.Parse(Console.ReadLine());

            satisFiyat = fiyat + kar;
            Console.WriteLine("Satış fiyatı:{0}", satisFiyat);
            Console.ReadKey();

        }
    }
}
