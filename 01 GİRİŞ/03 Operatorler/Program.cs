namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=4; //Tamsayı tipinde
            double b=3.25; //Küsüratlı sayı
            string adi="Oğuzhan"; //Metinsel değişken
            string sayi1 = "5";
            int sayi2 = int.Parse(sayi1);

            char c='A'; //Karakter tipi, tek bir harf, rakam, sembol
            byte dersnotu;
            long uzuntamsayi = 123456789123456789;

            Console.WriteLine("Bir sayı giriniz:");
            dersnotu =byte.Parse(Console.ReadLine());
            Console.WriteLine(dersnotu);

        }
    }
}
