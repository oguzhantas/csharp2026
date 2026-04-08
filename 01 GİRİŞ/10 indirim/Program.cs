namespace indirim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fiyat, indirimliFiyat;
            Console.WriteLine("Fiyat giriniz:");
            fiyat = double.Parse(Console.ReadLine());

            indirimliFiyat = fiyat - fiyat *35/100;
            Console.WriteLine("İndirimli Fiyat:"+indirimliFiyat);

        }
    }
}
