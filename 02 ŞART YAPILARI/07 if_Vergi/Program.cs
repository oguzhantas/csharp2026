namespace if_Vergi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maas, vergi = 0;

            Console.WriteLine("Maaşınızı giriniz:");
            maas= int.Parse(Console.ReadLine());

            if (maas < 5000)
                vergi = 100;
            else if (maas >= 5000 && maas < 6000)
                vergi = 150;
            else if (maas >= 6000 && maas < 7000)
                vergi = 200;
            else if (maas >= 7000)
                vergi = 250;
            Console.WriteLine("Ödenecek Vergi:"+vergi);
        }
    }
}
