namespace MerhabaAdSoyad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi, soyadi;
            Console.Write("Adınızı giriniz:");
            adi= Console.ReadLine();

            Console.Write("Soyadınızı giriniz:");
            soyadi = Console.ReadLine();
            
            Console.WriteLine("Merhaba " + adi + " " + soyadi);
            Console.WriteLine("Merhaba {0} {1}",adi,soyadi) ;
           
        }
    }
}
